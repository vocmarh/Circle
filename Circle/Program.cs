using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle
{
    internal class Program
    {
        static void Main(string[] args)
        {            
            Circle circle = new Circle();
            circle.Square();
            circle.Circuit();
            circle.Accessory();            
            Console.ReadKey();
        }

         public class Circle
        {
            public double l;
            public static double r = 3.3;
            public double S;
            public static double x = 10;
            public static double y = 10;
            public static double x0 = 8;
            public static double y0 = 8;

            public void Circuit()
            {                
                l = 2 * Math.PI * r;
                Console.WriteLine($"Длина окружности l равна: {l}");
            }
            public void Square()
            {
                S = Math.PI * Math.Pow(r,2);
                Console.WriteLine($"Площадь круга S равна: {S}");
            }
            public void Accessory()
            {
                if (x0 + r < x && y0+r < y)
                {
                    Console.WriteLine("Точка с координатами x и y находятся за пределами круга");
                }
                else
                {
                    Console.WriteLine("Точка с координатами x и y находятся в пределах круга");
                }
            }
        }
    }
}
