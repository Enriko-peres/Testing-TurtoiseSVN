using System;

namespace Inside_The_Building
{
    class Program
    {
        static void Main(string[] args)
        {
            int h = int.Parse(Console.ReadLine());

            Rect rect1 = new Rect(0, 0, 3 * h, h);
            Rect rect2 = new Rect(h, h, h, 3 * h);

            int[] points = new int[10];
            for (int i = 0; i < 10; i++)
            {
                points[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < 10; i += 2)
            {
                if (rect1.contains(points[i], points[i+1]) || rect2.contains(points[i], points[i+1]))
                {
                    Console.WriteLine("inside");
                }
                else
                {
                    Console.WriteLine("outside");
                }
            }
        }
    }

    public class Rect
    {
        int x, y, width, height;
        public Rect(int x, int y, int width, int height)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
        }

        public bool contains(int x, int y)
        {
            if (this.x <= x && this.x + this.width >= x && this.y <= y && this.y + this.height >= y)
            {
                return true;
            }
            return false;
        }
    }
}
