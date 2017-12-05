using System;
using System.Runtime.InteropServices;
using Kompas6API5;
using Kompas6Constants;
using Kompas6Constants3D;

namespace KompasLib
{
    internal class Kompas
    {
        /// <summary>
        ///     Конструктор
        /// </summary>
        public KompasObject Kompas3D => _kompas;

        public KompasObject _kompas;

        public void RunKompas()
        {
            if (_kompas == null)
            {
                var t = Type.GetTypeFromProgID("KOMPAS.Application.5");
                _kompas = (KompasObject) Activator.CreateInstance(t);
            }
            RunningKompas();
            if (_kompas != null)
            {
                _kompas.Visible = true;
                _kompas.ActivateControllerAPI();
            }
        }

        /// <summary>
        ///     Создание двери
        /// </summary>
        /// <param name="doorParameters"></param>
        public void BuildDoor(DoorParameters doorParameters)
        {
            RunningKompas();
            //создание документа в компасе
            ksDocument3D doc = _kompas.Document3D();
            doc.Create();

            //определяем плоскость, создаем эскиз
            ksPart doorPart = doc.GetPart((short) Part_Type.pTop_Part);
            ksEntity planeXoY = doorPart.GetDefaultEntity((short) Obj3dType.o3d_planeXOY);
            ksEntity sketch = doorPart.NewEntity((short) Obj3dType.o3d_sketch);
            ksSketchDefinition sd = sketch.GetDefinition();
            sd.SetPlane(planeXoY);
            sketch.Create();
            ksDocument2D topSketch = sd.BeginEdit();

            //"основание двери"
            DrawRectangle(doorParameters, topSketch, -doorParameters.HeightDoor/2, -doorParameters.WidthDoor/2,
                doorParameters.HeightDoor, doorParameters.WidthDoor,
                null);
            sd.EndEdit();
            Extrude(doorParameters, doorPart, sketch, doorParameters.WeigthDoor, (short) Direction_Type.dtNormal);

            //"основание двери"->"глазок"
            ksEntity eyePlaneOffset = doorPart.NewEntity((short) Obj3dType.o3d_planeOffset);
            //создаем переменную смещенной поверхности 
            ksPlaneOffsetDefinition eyeDefinition = eyePlaneOffset.GetDefinition();
            // получаем указатель на её настройки 
            eyeDefinition.SetPlane(planeXoY); // ХУ плоскость установим как исходную, чтобы отталкиватся от неё 
            eyeDefinition.offset = doorParameters.WeigthDoor; //смещаемся на десять 
            eyePlaneOffset.Create(); // создаем саму плоскость 
            ksEntity eyeSketch = doorPart.NewEntity((short) Obj3dType.o3d_sketch);
            //создаем переменную эскиза 
            ksSketchDefinition eyeSketchDefinition = eyeSketch.GetDefinition(); //получим указатель на параметры эскиза 
            eyeSketchDefinition.SetPlane(eyePlaneOffset); //зададим плоскость на которой создаем эскиз 

            eyeSketch.Create(); // создаем эскизa 

            ksDocument2D eye = eyeSketchDefinition.BeginEdit();
            eye.ksCircle(doorParameters.YEye/2, 0, 15, 1);

            eyeSketchDefinition.EndEdit();

            Cut(doorParameters, doorPart, eyeSketch, doorParameters.WeigthDoor);

            //"основание двери"->"основание ручки"
            ksEntity floorKeySketch = doorPart.NewEntity((short) Obj3dType.o3d_sketch);
            //создаем переменную эскиза 
            ksSketchDefinition floorKeyDifinition = floorKeySketch.GetDefinition();
            //получим указатель на параметры эскиза 
            floorKeyDifinition.SetPlane(eyePlaneOffset); //зададим плоскость на которой создаем эскиз 
            floorKeySketch.Create(); // создаем эскизa 

            ksDocument2D floorKey = floorKeyDifinition.BeginEdit();
            DrawRectangle(doorParameters, floorKey, doorParameters.YKey/2, doorParameters.WidthDoor - 470, 15, 14,
                null);

            floorKeyDifinition.EndEdit();

            Extrude(doorParameters, doorPart, floorKeySketch, 15, (short) Direction_Type.dtNormal);

            //"основание ручки"->"ручка"
            ksEntity keyPlaneOffset = doorPart.NewEntity((short) Obj3dType.o3d_planeOffset);
            //создаем переменную смещенной поверхности 
            ksPlaneOffsetDefinition pod5 = keyPlaneOffset.GetDefinition(); // получаем указатель на её настройки 
            pod5.SetPlane(eyePlaneOffset); // ХУ плоскость установим как исходную, чтобы отталкиватся от неё 
            pod5.offset = 15; //смещаемся на 15 
            keyPlaneOffset.Create(); // создаем саму плоскость 
            ksEntity keySketch = doorPart.NewEntity((short) Obj3dType.o3d_sketch);
            //создаем переменную эскиза 
            ksSketchDefinition keySketchDefinition = keySketch.GetDefinition(); //получим указатель на параметры эскиза 
            keySketchDefinition.SetPlane(keyPlaneOffset); //зададим плоскость на которой создаем эскиз 
            keySketch.Create(); // создаем эскизa 
            ksDocument2D key = keySketchDefinition.BeginEdit();

            DrawRectangle(doorParameters, key, doorParameters.YKey/2, doorParameters.WidthDoor - 430, 150, 26, -90);
            keySketchDefinition.EndEdit();

            Extrude(doorParameters, doorPart, keySketch, 5, (short) Direction_Type.dtNormal);
        }

        /// <summary>
        ///     Рисование прямоугольника
        /// </summary>
        /// <param name="doc2d"></param>
        /// <param name="xStart"></param>
        /// <param name="yStart"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <param name="ang"></param>
        private void DrawRectangle(DoorParameters doorParameters, ksDocument2D doc2d, double xStart, double yStart,
            double width,
            double height, double? ang)
        {
            var param = (ksRectangleParam) _kompas.GetParamStruct((short) StructType2DEnum.ko_RectangleParam);
            param.x = xStart;
            param.y = yStart;
            param.width = width;
            param.height = height;

            if (ang != null)
                param.ang = (double) ang;

            param.style = 1;
            doc2d.ksRectangle(param, 0);
        }

        /// <summary>
        ///     Вырезание
        /// </summary>
        /// <param name="part"></param>
        /// <param name="sketch"></param>
        /// <param name="heigth"></param>
        private static void Cut(DoorParameters doorParameters, ksPart part, ksEntity sketch, int heigth)
        {
            ksEntity cutExtrude = part.NewEntity((short) Obj3dType.o3d_cutExtrusion);
            ksCutExtrusionDefinition cutextrDef = cutExtrude.GetDefinition();
            cutextrDef.directionType = (short) Direction_Type.dtNormal;
            cutextrDef.SetSketch(sketch);
            ksExtrusionParam cutExtrParam = cutextrDef.ExtrusionParam();
            cutExtrParam.depthNormal = heigth;
            cutExtrude.Create();
        }

        /// <summary>
        ///     Выдавливание
        /// </summary>
        /// <param name="part"></param>
        /// <param name="sketch"></param>
        /// <param name="length"></param>
        /// <param name="type"></param>
        private static void Extrude(DoorParameters doorParameters, ksPart part, ksEntity sketch, int length, short type)
        {
            ksEntity extrude = part.NewEntity((short) Obj3dType.o3d_bossExtrusion);
            ksBossExtrusionDefinition extrDef = extrude.GetDefinition();
            extrDef.directionType = type;
            extrDef.SetSketch(sketch);
            ksExtrusionParam extrudeParam = extrDef.ExtrusionParam();
            extrudeParam.depthNormal = length;

            extrude.Create();
        }

        /// <summary>
        ///     Запуск в 1 окне
        /// </summary>
        private void RunningKompas()
        {
            try
            {
                if (_kompas != null)
                {
                    _kompas.Visible = true;
                    _kompas.ActivateControllerAPI();
                }
            }
            catch (COMException)
            {
                _kompas = null;
                RunKompas();
            }
        }
    }
}
