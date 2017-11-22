using System;
using System.Windows.Forms;

namespace KompasLib
{
    public partial class MainForm : Form
    {
        private readonly Kompas _kompas3D = new Kompas();

        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        ///     Видимость кнопки "построить"
        /// </summary>
        private void VisBut()
        {
            if (HeightDoor.SelectedIndex == -1 || WidthDoor.SelectedIndex == -1 || ThicknessDoor.SelectedIndex == -1 ||
                DoorHandle.SelectedIndex == -1 || DoorPeephole.SelectedIndex == -1)
            {
                PushToKompas.Enabled = false;
            }
            else
            {
                PushToKompas.Enabled = true;
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Load(
                "C://Users//Igor' Antropov//Documents//Visual Studio 2015//Projects//ORSAPR//KompasLib//1.jpg");
            pictureBox2.Load(
                "C://Users//Igor' Antropov//Documents//Visual Studio 2015//Projects//ORSAPR//KompasLib//2.jpg");
            PushToKompas.Enabled = false;
        }

        private void WidthDoor_SelectedIndexChanged(object sender, EventArgs e)
        {
            VisBut();
        }

        private void HeightDoor_SelectedIndexChanged(object sender, EventArgs e)
        {
            VisBut();
        }

        private void DoorPeephole_SelectedIndexChanged(object sender, EventArgs e)
        {
            VisBut();
        }

        private void DoorHandle_SelectedIndexChanged(object sender, EventArgs e)
        {
            VisBut();
        }

        private void ThicknessDoor_SelectedIndexChanged(object sender, EventArgs e)
        {
            VisBut();
        }

        public void PushToKompas_Click(object sender, EventArgs e)
        {
            //объявление и присвоение переменных
            var heightDoor = int.Parse(HeightDoor.Items[HeightDoor.SelectedIndex].ToString()); //высота двери
            var widthDoor = int.Parse(WidthDoor.Items[WidthDoor.SelectedIndex].ToString()); //ширина двери
            var weigthDoor = int.Parse(ThicknessDoor.Items[ThicknessDoor.SelectedIndex].ToString()); //толщина двери
            var yKey = int.Parse(DoorHandle.Items[DoorHandle.SelectedIndex].ToString()); //высота ручки
            var yEye = int.Parse(DoorPeephole.Items[DoorPeephole.SelectedIndex].ToString()); //высота глазка

            var door = new DoorParameters(heightDoor, widthDoor, weigthDoor, yKey, yEye);

            //Вызов классов
            if (_kompas3D.Kompas3D == null)
                _kompas3D.RunKompas();

            _kompas3D.BuildDoor(door);
        }

        /// <summary>
        ///     Валидация
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HeightDoor_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                int.Parse(DoorPeephole.SelectionLength.ToString());
            }
            catch
            {
                throw new ArgumentException("Высота двери не указана!");
            }
        }

        //public void Validation()
        //{

        //}

        /// <summary>
        ///     Валидация
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WidthDoor_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                int.Parse(DoorPeephole.SelectionLength.ToString());
            }
            catch
            {
                throw new ArgumentException("Ширина двери не указана!");
            }
        }

        /// <summary>
        ///     Валидация
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ThicknessDoor_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                int.Parse(DoorPeephole.SelectionLength.ToString());
            }
            catch
            {
                throw new ArgumentException("Толщина двери не указана!");
            }
        }

        /// <summary>
        ///     Валидация
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DoorHandle_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                int.Parse(DoorPeephole.SelectionLength.ToString());
            }
            catch
            {
                throw new ArgumentException("Высота ручки не указана!");
            }
        }

        /// <summary>
        ///     Валидация
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DoorPeephole_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                int.Parse(DoorPeephole.SelectionLength.ToString());
            }
            catch
            {
                throw new ArgumentException("Высота глазка не указана!");
            }
        }
    }
}
