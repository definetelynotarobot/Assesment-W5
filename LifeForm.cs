using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsPractice
{

    public class LifeForm
    {
        public void Move(List<int> numbers, Point point)
        {
            for (int i = 0; i + 1 < numbers.Count; i += 2)
            {
                point.X += numbers[i];
                point.Y += numbers[i + 1];
            }

        }
        public virtual void PrintPosition(Point point)
        {
            Console.WriteLine("Koordinatlarınız: ({0}, {1})", point.X, point.Y);
        }
        public static LifeForm CreateLifeForm(int secim)
        {
            if (secim == 1)
            {
                return new Human();
            }
            else if(secim == 2)
            {
                return new Alien();
            }
            else
            {
                Console.WriteLine("Lütfen 1 yada 2 seçeneklerini seçiniz.");
                return null;
            }
        }
        public class Human : LifeForm
        {
            public override void PrintPosition(Point point)
            {
                Console.WriteLine("İnsan koordinatları: ({0}, {1})", point.X, point.Y);
            }
        }

        public class Alien : LifeForm
        {
            public override void PrintPosition(Point point)
            {
                Console.WriteLine("Uzaylı koordinatlari: ({0}, {1})", point.Y, point.X);
            }
        }
    }
    }
        

