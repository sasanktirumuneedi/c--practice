using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tutorials
{
    class specifier
    {
        private double width;
        public double length;

        public void Acceptdetails()
        {

        }
        public void GetArea()
        {

        }
        public void Display()
        {

        }
    }
    class ExecuteRectangle{
        static void Main(string[] args)
        {
            specifier r = new specifier();
            r.Acceptdetails();
            r.Display();
            //Console.WriteLine("test " + length);
            Console.ReadLine();
        }

    }
}
