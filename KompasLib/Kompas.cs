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
        /// Конструктор
        /// </summary>
        public KompasObject Kompas3D => _kompas;

        /// <summary>
        /// Объект компас
        /// </summary>
        private KompasObject _kompas;

        /// <summary>
        /// Запуск компаса
        /// </summary>
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
        /// Создание двери
        /// </summary>
        /// <param name="doorParameters"></param>
        public void BuildDoor(DoorParameters doorParameters)
        {
            RunningKompas();

            ksDocument3D doc = _kompas.Document3D();
            doc.Create();

            ksPart doorPart = doc.GetPart((short) 
                Part_Type.pTop_Part);
            ksEntity planeXoY = doorPart.GetDefaultEntity((short) 
                Obj3dType.o3d_planeXOY);
            ksEntity sketch = doorPart.NewEntity((short) 
                Obj3dType.o3d_sketch);
            ksSketchDefinition sd = sketch.GetDefinition();
            sd.SetPlane(planeXoY);
            sketch.Create();
            ksDocument2D topSketch = sd.BeginEdit();

            DrawRectangle(topSketch,
                -doorParameters.HeightDoor/2.0, -doorParameters.WidthDoor/2.0,
                doorParameters.HeightDoor, doorParameters.WidthDoor,
                null);
            sd.EndEdit();
            Extrude(doorPart, sketch, doorParameters.WeigthDoor, 
                (short) Direction_Type.dtNormal);
            DoorModification(doorParameters, doorPart, planeXoY);
        }

        /// <summary>
        /// Добавление элементов на полотно двери
        /// </summary>
        /// <param name="doorParameters"></param>
        /// <param name="doorPart"></param>
        /// <param name="planeXoY"></param>
        private void DoorModification(DoorParameters doorParameters,
            ksPart doorPart, ksEntity planeXoY)
        {
            ksEntity eyePlaneOffset = doorPart.NewEntity((short) 
                Obj3dType.o3d_planeOffset);
            ksPlaneOffsetDefinition eyeDefinition = eyePlaneOffset.GetDefinition();
            eyeDefinition.SetPlane(planeXoY);
            eyeDefinition.offset = doorParameters.WeigthDoor;
            eyePlaneOffset.Create();
            ksEntity eyeSketch = doorPart.NewEntity((short) 
                Obj3dType.o3d_sketch);
            ksSketchDefinition eyeSketchDefinition = eyeSketch.GetDefinition();
            eyeSketchDefinition.SetPlane(eyePlaneOffset);
            eyeSketch.Create();
            ksDocument2D eye = eyeSketchDefinition.BeginEdit();
            eye.ksCircle(doorParameters.YEye/2.0, 0, 15, 1);
            eyeSketchDefinition.EndEdit();
            Cut(doorPart, eyeSketch, doorParameters.WeigthDoor);
            AnimalDoor(doorParameters, doorPart, eyePlaneOffset);
            DoorKnob(doorParameters, doorPart, eyePlaneOffset);
        }

        /// <summary>
        /// Собачья заслонка
        /// </summary>
        /// <param name="doorParameters"></param>
        /// <param name="doorPart"></param>
        /// <param name="eyePlaneOffset"></param>
        private void AnimalDoor(DoorParameters doorParameters,
            ksPart doorPart, ksEntity eyePlaneOffset)
        {
            var x = -doorParameters.HeightDoor/2;
            var y = -doorParameters.WidthDoor/2 + 350;
            var animalHoleHeight = 200;
            if (doorParameters.IsOpen == true)
            {
                ksEntity animalDoorHoleSketch = doorPart.NewEntity((short) 
                    Obj3dType.o3d_sketch);
                ksSketchDefinition animalDoorHoleSketchDefinition = animalDoorHoleSketch.GetDefinition();
                animalDoorHoleSketchDefinition.SetPlane(eyePlaneOffset);
                animalDoorHoleSketch.Create();

                ksDocument2D animalDoorHole = animalDoorHoleSketchDefinition.BeginEdit();
                DrawRectangle(animalDoorHole, x, y, 
                    animalHoleHeight, 
                    animalHoleHeight, null);
                animalDoorHoleSketchDefinition.EndEdit();
                Cut(doorPart, animalDoorHoleSketch, 
                    doorParameters.WeigthDoor);

                ksEntity animalDoorSketch = doorPart.NewEntity((short) 
                    Obj3dType.o3d_sketch);
                ksSketchDefinition animalDoorSketchDefinition = animalDoorSketch.GetDefinition();
                animalDoorSketchDefinition.SetPlane(eyePlaneOffset);
                animalDoorSketch.Create();

                ksDocument2D animalDoor = animalDoorSketchDefinition.BeginEdit();
                DrawRectangle(animalDoor, x + animalHoleHeight, y, 
                    animalHoleHeight/10.0, animalHoleHeight,
                    null);
                animalDoorSketchDefinition.EndEdit();
                Extrude(doorPart, animalDoorSketch, animalHoleHeight,
                    (short) Direction_Type.dtNormal);
            }
            if (doorParameters.IsOpen == false)
            {
                ksEntity animalDoorHoleSketch = doorPart.NewEntity((short) 
                    Obj3dType.o3d_sketch);
                ksSketchDefinition animalDoorHoleSketchDefinition = animalDoorHoleSketch.GetDefinition();
                animalDoorHoleSketchDefinition.SetPlane(eyePlaneOffset);
                animalDoorHoleSketch.Create();

                ksDocument2D animalDoorHole = animalDoorHoleSketchDefinition.BeginEdit();
                DrawRectangle(animalDoorHole, x, y, animalHoleHeight, 
                    animalHoleHeight, null);
                animalDoorHoleSketchDefinition.EndEdit();
                Cut(doorPart, animalDoorHoleSketch, 0.2);
            }
        }

        /// <summary>
        /// Дверная ручка
        /// </summary>
        /// <param name="doorParameters"></param>
        /// <param name="doorPart"></param>
        /// <param name="eyePlaneOffset"></param>
        private void DoorKnob(DoorParameters doorParameters,
            ksPart doorPart, ksEntity eyePlaneOffset)
        {
            ksEntity floorKeySketch = doorPart.NewEntity((short) 
                Obj3dType.o3d_sketch);
            ksSketchDefinition floorKeyDifinition = floorKeySketch.GetDefinition();
            floorKeyDifinition.SetPlane(eyePlaneOffset);
            floorKeySketch.Create();
            ksDocument2D floorKey = floorKeyDifinition.BeginEdit();
            DrawRectangle(floorKey, doorParameters.YKey/2.0, 
                doorParameters.WidthDoor - 470, 18, 18,
                null);
            floorKeyDifinition.EndEdit();
            Extrude(doorPart, floorKeySketch, 25, 
                (short) Direction_Type.dtNormal);
            HandleBase(doorParameters, doorPart, 
                eyePlaneOffset);
        }

        /// <summary>
        /// Основание ручки
        /// </summary>
        /// <param name="doorParameters"></param>
        /// <param name="doorPart"></param>
        /// <param name="eyePlaneOffset"></param>
        private void HandleBase(DoorParameters doorParameters,
            ksPart doorPart, ksEntity eyePlaneOffset)
        {
            ksEntity keyPlaneOffset = doorPart.NewEntity((short) 
                Obj3dType.o3d_planeOffset);
            ksPlaneOffsetDefinition pod5 = keyPlaneOffset.GetDefinition();
            pod5.SetPlane(eyePlaneOffset);
            pod5.offset = 25;
            keyPlaneOffset.Create();
            ksEntity keySketch = doorPart.NewEntity((short) 
                Obj3dType.o3d_sketch);
            ksSketchDefinition keySketchDefinition = keySketch.GetDefinition();
            keySketchDefinition.SetPlane(keyPlaneOffset);
            keySketch.Create();
            ksDocument2D key = keySketchDefinition.BeginEdit();
            DrawRectangle(key, doorParameters.YKey/2.0, 
                doorParameters.WidthDoor - 430, 200, 26, -90);
            keySketchDefinition.EndEdit();
            Extrude(doorPart, keySketch, 5, 
                (short) Direction_Type.dtNormal);
        }

        /// <summary>
        /// Рисование прямоугольника
        /// </summary>
        /// <param name="doc2D"></param>
        /// <param name="xStart"></param>
        /// <param name="yStart"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <param name="ang"></param>
        private void DrawRectangle(ksDocument2D doc2D, 
            double xStart, double yStart,
            double width,
            double height, double? ang)
        {
            var param = (ksRectangleParam) _kompas.GetParamStruct((short) 
                StructType2DEnum.ko_RectangleParam);
            param.x = xStart;
            param.y = yStart;
            param.width = width;
            param.height = height;
            if (ang != null)
                param.ang = (double) ang;
            param.style = 1;
            doc2D.ksRectangle(param);
        }

        /// <summary>
        /// Вырезание
        /// </summary>
        /// <param name="part"></param>
        /// <param name="sketch"></param>
        /// <param name="heigth"></param>
        private static void Cut(ksPart part, 
            ksEntity sketch, double heigth)
        {
            ksEntity cutExtrude = part.NewEntity((short) 
                Obj3dType.o3d_cutExtrusion);
            ksCutExtrusionDefinition cutextrDef = cutExtrude.GetDefinition();
            cutextrDef.directionType = (short) Direction_Type.dtNormal;
            cutextrDef.SetSketch(sketch);
            ksExtrusionParam cutExtrParam = cutextrDef.ExtrusionParam();
            cutExtrParam.depthNormal = heigth;
            cutExtrude.Create();
        }

        /// <summary>
        /// Выдавливание
        /// </summary>
        /// <param name="part"></param>
        /// <param name="sketch"></param>
        /// <param name="length"></param>
        /// <param name="type"></param>
        private static void Extrude(ksPart part, 
            ksEntity sketch, int length, short type)
        {
            ksEntity extrude = part.NewEntity((short) 
                Obj3dType.o3d_bossExtrusion);
            ksBossExtrusionDefinition extrDef = extrude.GetDefinition();
            extrDef.directionType = type;
            extrDef.SetSketch(sketch);
            ksExtrusionParam extrudeParam = extrDef.ExtrusionParam();
            extrudeParam.depthNormal = length;

            extrude.Create();
        }

        /// <summary>
        /// Запуск в 1 окне
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
