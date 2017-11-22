using System;
using System.ComponentModel.DataAnnotations;

namespace KompasLib
{
    internal class DoorParameters
    {
        /// <summary>
        ///     Переприсвоение
        /// </summary>
        /// <param name="heightDoor"></param>
        /// <param name="widthDoor"></param>
        /// <param name="weigthDoor"></param>
        /// <param name="yKey"></param>
        /// <param name="yEye"></param>
        public DoorParameters(int heightDoor, int widthDoor, int weigthDoor, int yKey, int yEye)
        {
            HeightDoor = heightDoor;
            WidthDoor = widthDoor;
            WeigthDoor = weigthDoor;
            YKey = yKey;
            YEye = yEye;
        }


        /// <summary>
        ///     Высота
        /// </summary>
        public int HeightDoor
        {
            get { return _heightDoor; }
            private set
            {
                if (value < 1900 || value > 2200)
                    throw new ArgumentException("Высота двери должна быть от 1900 до 2200!");
                _heightDoor = value;
            }
        }

        /// <summary>
        ///     Валидация
        /// </summary>
        [Required] [Range(1900, 2200)] private int _heightDoor;

        /// <summary>
        ///     Ширина
        /// </summary>
        public int WidthDoor
        {
            get { return _widthDoor; }
            private set
            {
                if (value < 800 || value > 900)
                    throw new ArgumentException("Ширина двери должна быть от 800 до 900!");
                _widthDoor = value;
            }
        }

        /// <summary>
        ///     Валидация
        /// </summary>
        [Required] [Range(800, 900)] private int _widthDoor;

        /// <summary>
        ///     Толщина
        /// </summary>
        public int WeigthDoor
        {
            get { return _weigthDoor; }
            private set
            {
                if (value < 50 || value > 100)
                    throw new ArgumentException("Толщина двери должна быть от 50 до 100!");
                _weigthDoor = value;
            }
        }

        /// <summary>
        ///     Валидация
        /// </summary>
        [Required] [Range(50, 100)] private int _weigthDoor;

        /// <summary>
        ///     Ручка
        /// </summary>
        public int YKey
        {
            get { return _yKey; }
            private set
            {
                if (value < 100 || value > 900)
                {
                    throw new ArgumentException("Высота ручки должна быть от 100 до 900!");
                }
                _yKey = value;
            }
        }

        /// <summary>
        ///     Валидация
        /// </summary>
        [Required] [Range(100, 900)] private int _yKey;

        /// <summary>
        ///     Глазок
        /// </summary>
        public int YEye
        {
            get { return _yEye; }
            private set
            {
                if (value < 900 || value > 1600)
                    throw new ArgumentException("Высота глазка должна быть от 900 до 1600!");
                _yEye = value;
            }
        }

        /// <summary>
        ///     Валидация
        /// </summary>
        [Required] [Range(900, 1600)] private int _yEye;
    }
}
