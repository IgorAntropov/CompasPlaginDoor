using System;
using System.Diagnostics;
using System.IO;
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
        /// Видимость кнопки "построить"
        /// </summary>
        private void VisBut()
        {
            if (doorHeight.SelectedIndex == -1 || doorWidth.SelectedIndex == -1 || doorThickness.SelectedIndex == -1 ||
                doorHandle.SelectedIndex == -1 || doorPeephole.SelectedIndex == -1)
            {
                pushToKompas.Enabled = false;
            }
            else
            {
                pushToKompas.Enabled = true;
            }
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

        /// <summary>
        /// Отправка данных в компас и проверка решений
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pushToKompas_Click(object sender, EventArgs e)
        {
            var heightDoor = int.Parse(doorHeight.Items[doorHeight.SelectedIndex].ToString());
            var widthDoor = int.Parse(doorWidth.Items[doorWidth.SelectedIndex].ToString());
            var weigthDoor = int.Parse(doorThickness.Items[doorThickness.SelectedIndex].ToString());
            var yKey = int.Parse(doorHandle.Items[doorHandle.SelectedIndex].ToString());
            var yEye = int.Parse(doorPeephole.Items[doorPeephole.SelectedIndex].ToString());
            bool? isOpen = null;

            if (checkAnimal.Checked)
            {
                if (openAnimalDoor.Checked)
                {
                    isOpen = true;
                }
                if (closeAnimalDoor.Checked)
                {
                    isOpen = false;
                }
            }

            var door = new DoorParameters(heightDoor, widthDoor, weigthDoor, yKey, yEye, isOpen);

            if (_kompas3D.Kompas3D == null)
                _kompas3D.RunKompas();

            _kompas3D.BuildDoor(door);
        }

        /// <summary>
        /// Параметры загрузки формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Load_1(object sender, EventArgs e)
        {
            pictureBox.Load(
                "C://Users//Igor'//Desktop//учеба//ОРСАПР//ORSAPR//KompasLib//1.jpg");
            openAnimalDoor.Enabled = false;
            closeAnimalDoor.Enabled = false;
            closeAnimalDoor.Checked = true;
            checkAnimal.Checked = false;
            pushToKompas.Enabled = false;
            test100.Enabled = false;
        }

        /// <summary>
        /// Нагрузочный тест
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void test100_Click_1(object sender, EventArgs e)
        {
            Stopwatch stopWatch = new Stopwatch();

            string fileName = DateTime.Now.ToString("yyyy.MM.dd_HH-mm-ss-") + "test.txt";
            demoVariable_Click_1(sender, e);
            for (int i = 0; i < 101; i++)
            {
                stopWatch.Start();

                pushToKompas_Click(sender, e);

                stopWatch.Stop();
                FileStream file = new FileStream(fileName, FileMode.Append);
                StreamWriter writer = new StreamWriter(file);

                string elapsedTime = String.Format("{0}",
                    stopWatch.Elapsed.Milliseconds + stopWatch.Elapsed.Seconds * 1000 +
                    stopWatch.Elapsed.Minutes * 60 * 1000);
                writer.Write("({0};{1})", i, elapsedTime);
                writer.Close();
                stopWatch.Reset();
            }
        }

        /// <summary>
        /// Проверка собачьей заслонки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkAnimal_CheckedChanged(object sender, EventArgs e)
        {
            if (checkAnimal.Checked == true)
            {
                openAnimalDoor.Enabled = true;
                closeAnimalDoor.Enabled = true;
            }
            else
            {
                openAnimalDoor.Enabled = false;
                closeAnimalDoor.Enabled = false;
            }
        }

        /// <summary>
        /// Валидация дверного глазка
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void doorPeephole_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            try
            {
                int.Parse(doorPeephole.SelectionLength.ToString());
            }
            catch
            {
                throw new ArgumentException("Высота глазка не указана!");
            }
        }

        /// <summary>
        /// Валидация дверной ручки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void doorHandle_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            try
            {
                int.Parse(doorPeephole.SelectionLength.ToString());
            }
            catch
            {
                throw new ArgumentException("Высота ручки не указана!");
            }
        }

        /// <summary>
        /// Валидация толщины двери
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void doorThickness_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                int.Parse(doorPeephole.SelectionLength.ToString());
            }
            catch
            {
                throw new ArgumentException("Толщина двери не указана!");
            }
        }

        /// <summary>
        /// Валидация ширины двери
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void doorWidth_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                int.Parse(doorPeephole.SelectionLength.ToString());
            }
            catch
            {
                throw new ArgumentException("Ширина двери не указана!");
            }
        }

        /// <summary>
        /// Валидация высоты двери
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void doorHeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                int.Parse(doorPeephole.SelectionLength.ToString());
            }
            catch
            {
                throw new ArgumentException("Высота двери не указана!");
            }
        }

        /// <summary>
        /// Быстрое заполенение формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void demoVariable_Click_1(object sender, EventArgs e)
        {
            doorHeight.SelectedIndex = 1;
            doorWidth.SelectedIndex = 1;
            doorThickness.SelectedIndex = 1;
            doorHandle.SelectedIndex = 1;
            doorPeephole.SelectedIndex = 1;
        }
    }
}
