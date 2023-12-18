using System;

namespace MethodsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Haritanın enini ve boyunu giriniz:");
            var haritaX = int.Parse(Console.ReadLine());
            var haritaY = int.Parse(Console.ReadLine());

            Console.WriteLine("Başlangıç noktası: (0, 0)");

            Point point = new Point(0, 0);

            Console.WriteLine("Hareket koordinatlarını giriniz:");
            var a0 = int.Parse(Console.ReadLine());
            var a1 = int.Parse(Console.ReadLine());
            var a2 = int.Parse(Console.ReadLine());
            var a3 = int.Parse(Console.ReadLine());

            point.Move(a0, a1, a2, a3);

            Console.WriteLine("Yeni konumunuz: ({0}, {1})", point.X, point.Y);

            Console.WriteLine("İnsan(1) olarak mı Uzaylı(2) olarak mı ilerlemek istersiniz?");
            var secim = int.Parse(Console.ReadLine());

        }
    }
}
