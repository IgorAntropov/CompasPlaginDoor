using System;

namespace KompasLib
{
    public class DoorParameters
    {
        /// <summary>
        /// Переприсвоение
        /// </summary>
        /// <param name="weigthDoor"></param>
        /// <param name="yKey"></param>
        /// <param name="yEye"></param>
        /// <param name="isOpen"></param>
        /// <param name="heightDoor"></param>
        /// <param name="widthDoor"></param>
        public DoorParameters(int weigthDoor, int yKey,
            int yEye, bool? isOpen, int heightDoor, int widthDoor)
        {
            HeightDoor = heightDoor;
            WidthDoor = widthDoor;
            WeigthDoor = weigthDoor;
            YKey = yKey;
            YEye = yEye;
            IsOpen = isOpen;
        }
        
        /// <summary>
        /// Гет сет высоты + валидация
        /// </summary>
        public int HeightDoor
        {
            get { return _heightDoor; }
            private set
            {
                if (value < 1900 || value > 2200)
                {
                    throw new ArgumentException("Высота двери " +
                                                "должна быть от 1900 до 2200!");
                }  
                _heightDoor = value;
            }
        }
        
        /// <summary>
        /// Гет сет ширины + валидация
        /// </summary>
        public int WidthDoor
        {
            get { return _widthDoor; }
            private set
            {
                if (value < 800 || value > 900)
                {
                    throw new ArgumentException("Ширина двери " +
                                                "должна быть от 800 до 900!");
                }
                _widthDoor = value;
            }
        }
        
        /// <summary>
        /// Гет сет толщины + валидация
        /// </summary>
        public int WeigthDoor
        {
            get { return _weigthDoor; }
            private set
            {
                if (value < 50 || value > 100)
                {
                    throw new ArgumentException("Толщина двери " +
                                                "должна быть от 50 до 100!");
                }
                _weigthDoor = value;
            }
        }
        
        /// <summary>
        /// Гет сет ручки + валидация
        /// </summary>
        public int YKey
        {
            get { return _yKey; }
            private set
            {
                if (value < 100 || value > 900)
                {
                    throw new ArgumentException("Высота ручки " +
                                                "должна быть от 100 до 900!");
                }
                _yKey = value;
            }
        }
        
        /// <summary>
        /// Гет сет глазка + валидация
        /// </summary>
        public int YEye
        {
            get { return _yEye; }
            private set
            {
                if (value < 900 || value > 1600)
                {
                    throw new ArgumentException("Высота глазка " +
                                                "должна быть от 900 до 1600!");
                }   
                _yEye = value;
            }
        }
        
        /// <summary>
        /// Гет сеттер переменной заслонки
        /// </summary>
        public bool? IsOpen { get; set; }

        /// <summary>
        /// Обращение
        /// </summary>
        private int _heightDoor;

        /// <summary>
        /// Обращение
        /// </summary>
        private int _yEye;

        /// <summary>
        /// Обращение
        /// </summary>
        private int _yKey;

        /// <summary>
        /// Обращение
        /// </summary>
        private int _weigthDoor;

        /// <summary>
        /// Обращение
        /// </summary>
        private int _widthDoor;
    }
}
