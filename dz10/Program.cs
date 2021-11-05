using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz10
{
    class Program
    {
        static void Main(string[] args)
        {
            Angle angle = new Angle(-303, 56, 26);
            angle.Toradians();
            Console.ReadKey();
        }
    }
    class Angle
    {
        double gradus;
        double min;
        double sec;

        public double Gradus
        {
            set
            {
                if (value <= 360 && value >= -360)
                {
                    gradus = value;
                }
                else
                {
                    Console.WriteLine("Значение градусов угла находятся в диапозоне от -360 до 360");
                }
            }
            get
            {
                return gradus;
            }
        }
        public double Min
        {
            set
            {
                if (value < 60 && value > 0)
                {
                    min = value;
                }
                else
                {
                    Console.WriteLine("Значение минут угла находятся в диапозоне от 0 до 60");
                }
            }
            get
            {
                return min;
            }
        }
        public double Sec
        {
            set
            {
                if (value < 60 && value > 0)
                {
                    sec = value;
                }
                else
                {
                    Console.WriteLine("Значение секунд угла находятся в диапозоне от 0 до 60");
                }
            }
            get
            {
                return sec;
            }
        }
        public Angle(double gradus, double min, double sec)
        {
            Gradus = gradus;
            Min = min;
            Sec = sec;
        }
        public void Toradians()
        {
            double gradusrad = gradus * (Math.PI / 180.0);
            double minrad = (min / 60) * (Math.PI / 180.0);
            double secrad = (sec / 360) * (Math.PI / 180.0);
            double Rad = gradusrad + minrad + secrad;
            Console.WriteLine("Угол в радианах равен {0}", Rad);
        }
    }
}









