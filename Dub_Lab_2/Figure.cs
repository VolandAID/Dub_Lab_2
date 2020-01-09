using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    /// <summary>
    /// Абстрактный класс Геометрическая фигура
    /// </summary>
    abstract class Figure
    {
        /// Виртуальный метод вычисляющий площадь фигуры
        public virtual double Area()
        {
            return 0;
        }
    }
}