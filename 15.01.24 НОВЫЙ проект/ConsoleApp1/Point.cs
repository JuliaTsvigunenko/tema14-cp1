using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Point
    {
        /// <summary>
        /// переменные x
        /// </summary>
        private double x;
        /// <summary>
        /// переменные y
        /// </summary>
        private double y;

        /// <summary>
        /// поле для подсчета количества созданных экземпляров класса
        /// </summary>
        public static double count;

        /// <summary>
        /// поле метода доступа к внутренним переменным x, y
        /// </summary>
        public double X
        { get { return x; } set { x = value; } }
        public double Y
        { get { return y; } set { y = value; } }




        /// <summary>
        /// конструктор с двумя параметрами, которые инициализируют одноименные внутренние поля класса
        /// </summary>
        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
            count = +1;
        }
        
        public Point()
        {
            double x = 1.0;
            double y = 1.0;
            
        }
        static Point()
        {
            count = 0;
        }


    }
}
