using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Areas_Library
{
    public class Area
    {
        /// <summary>
        /// возвращает площадь круга. передайте радиус круга 
        /// </summary>
        static public double Circle(double r)
        {

            return (Math.PI * (r * r));

        }
        /// <summary>
        /// возвращает площадь квадрата. передайте длинну стороны
        /// </summary>
        static public double square_or_rectangle(double l)
        {
            return (l * l);
        }
        /// <summary>
        /// возвращает площадь прямоугольника. передайте длинны сторон
        /// </summary>
        static public double square_or_rectangle(double l0, double l1)
        {
            return (l0 * l1);
        }
        /// <summary>
        /// возвращает площадь триугольника. передайте длинны сторон. если 0 - то не триугольник
        /// </summary>
        static public double triangle(double l0, double l1, double l2)
        {
            double P;
            if (l0 >= l1 + l2)
                return 0;
            if (l1 >= l0 + l2)
                return 0;
            if (l2 >= l0 + l1)
                return 0;
            P = (l0 + l1 + l2) / 2;
            return (Math.Sqrt(P * (P - l0) * (P - l1) * (P - l2)));
        }
        /// <summary>
        /// возвращает площадь триугольника и проверяет прямоугольный ли триугольник. передайте длинны сторон и параметр для проверки.
        /// если 0 - то не триугольник
        /// </summary>
        static public double triangle(double l0, double l1, double l2, ref bool rectangular)
        {
            double P;
            if (l0 >= l1 + l2)
                return 0;
            if (l1 >= l0 + l2)
                return 0;
            if (l2 >= l0 + l1)
                return 0;
            P = (l0 + l1 + l2) / 2;
            rectangular = false;
            if (l1 > l2 && l1 > l0)
            {
                if (l1 * l1 == (l0 * l0) + (l2 * l2))
                {
                    rectangular = true;
                }
            }
            if (l2 > l1 && l2 > l0)
            {
                if (l2 * l2 == (l0 * l0) + (l1 * l1))
                {
                    rectangular = true;
                }
            }
            if (l0 > l1 && l0 > l2)
            {
                if (l0 * l0 == (l1 * l1) + (l2 * l2))
                {
                    rectangular = true;
                }
            }
            return (Math.Sqrt(P * (P - l0) * (P - l1) * (P - l2)));
        }
    }
}
