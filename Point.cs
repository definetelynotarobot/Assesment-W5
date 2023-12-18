namespace MethodsPractice
{
    public class Point
    {
        public int X = 0;
        public int Y = 0;

        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public void Move(int a0, int a1, int a2, int a3)
        {
            this.X = X + a0 + a2;
            this.Y = Y + a1 + a3;
            Console.WriteLine("Yeni konumunuz: ({0}, {1})", X, Y);
        }
    }
}
