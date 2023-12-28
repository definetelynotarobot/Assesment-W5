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

            string input = Console.ReadLine();
            string[] numberStrings = input.Split(',');

            // Listeye sayıları ekliyoruz
            List<int> numbers = new List<int>();

            foreach (string numberString in numberStrings)
            {
                if (int.TryParse(numberString.Trim(), out int number))
                {
                    numbers.Add(number);
                }
            }
            /*
            Console.WriteLine("Girilen sayılar:");

            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            } */

            Console.WriteLine("İnsan(1) olarak mı Uzaylı(2) olarak mı ilerlemek istersiniz?");
            var secim = int.Parse(Console.ReadLine());

           // LifeForm.Move(numbers,point);

            LifeForm lifeForm = LifeForm.CreateLifeForm(secim);

            if (lifeForm != null)
            {
                lifeForm.Move(numbers, point);
                lifeForm.PrintPosition(point);
            }
            else
            {
                Console.WriteLine("Geçersiz seçim. Çıkılıyor.");
            }
        }
    }
}
