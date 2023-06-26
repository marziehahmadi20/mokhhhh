using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mokhhhht
{
    class mokhtasat
    {
        private int x1;
        private int y1;
        private int x2;
        private int y2;
        public int X1 
        {
            get { return x1; }
            set { x1 = value; }
        }
        public int X2
        {
            get { return x2; }
            set { x2 = value; }
        }
        public int Y1
        {
            get { return y1; }
            set { y1 = value; }
        }
        public int Y2
        {
            get { return y2; }
            set { y2 = value; }
        }
        public mokhtasat() { }
        public mokhtasat(int X1, int X2, int Y1,int Y2) 
        {
            x1 = X1;
            y1 = Y1;
            x2 = X2;
            y2 = Y2;
        }
        public double distance()
        {
            double result = Math.Sqrt(Math.Pow(x2-x1,2) + Math.Pow(y2-y1,2)) ;
            return result;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("lin1");
            Console.WriteLine("x1");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("y1");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("x2");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("y2");
            int y2 = Convert.ToInt32(Console.ReadLine());
            mokhtasat line1 = new mokhtasat(x1, y1, x2, y2);
            double l1 = line1.distance();
            Console.WriteLine("line2");
            Console.WriteLine("x3");
            int x3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("y3");
            int y3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("x4");
            int x4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("y4");
            int y4 = Convert.ToInt32(Console.ReadLine());
            mokhtasat line2 = new mokhtasat(x3,y3,x4,y4);
            double l2 = line2.distance();
            if(l1>l2)
                {
                Console.WriteLine("l1 is longer");
            }
            else
            {
                Console.WriteLine("l2 is hokger");
            }
        }
    }
}
