using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    /// Класс Круг
    class Circle : Figure, IPrint
    {
        /// Радиус
        protected double Radius;

        /// Конструктор
        public Circle(double radius)
        {
            this.Radius = radius;
        }

        /// Площадь Круга
        public override double Area()
        {
            return this.Radius * this.Radius * Math.PI;
        }

        /// Переопределенный метод преобразования в строку
        public override string ToString()
        {
            return "Круг: радиус = " + this.Radius + "; площадь = " + this.Area();
        }

        /// Метод вывода на консоль
        public void Print()
        {
            Console.WriteLine(this.ToString());
        }
    }
}
