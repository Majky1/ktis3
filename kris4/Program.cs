using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kris4
{
    class Program
    {
        public String Name { get; set; }

        public String Num { get; set; }

        public int Summa { get; set; }

        public Program()
        {

        }

        static void Main(string[] args)
        {
            Program scr = new Program();
            scr.Input();
            scr.Print();
            Console.ReadKey();

        }
    }
}
