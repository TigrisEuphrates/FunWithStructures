using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithStructures
{
    public struct Point
    {
        public int X;
        public int Y;

        public Point(int XP, int YP)
        {
            X = XP;
            Y = YP;
        }

        public void Increment()
        {
            X++;Y++;
        }
        public void Decrement()
        {
            X--;Y--;
        }
        public void Display()
        {
            Console.WriteLine("X={0}, Y={1}", X, Y);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A First Look at Structures\n");
            Point myPoint;
            myPoint.X = 349;
            myPoint.Y = 76;
            myPoint.Display();
            myPoint.Increment();
            myPoint.Display();

            Point p1 = new Point();
            p1.Display();

            Point p2 = new Point(50, 60);
            p2.Display();

            Console.ReadLine();
            //keyword "new" fills fields with standard values
        }
    }
}
