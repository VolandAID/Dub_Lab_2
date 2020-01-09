using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    /// Класс Прямоугольник
    class Rectangle : Figure, IPrint
    {
        /// Ширина прямоугольника
        protected double Width;

        /// Высота прямоугольника
        protected double Height;

        /// Конструктор
        /// <param name="width">Ширина</param>
        /// <param name="height">Высота</param>
        public Rectangle(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        /// Площадь прямоугольника
        public override double Area()
        {
            return Width * Height;
        }

        /// Переопределенный метод преобразования в строку
        public override string ToString()
        {
            return "Прямоугольник: ширина = " + this.Width + "; высота = " + this.Height +
                   "; площадь: " + this.Area();
        }

        /// Метод вывода на консоль
        public void Print()
        {
            Console.WriteLine(this.ToString());
        }
    }
}