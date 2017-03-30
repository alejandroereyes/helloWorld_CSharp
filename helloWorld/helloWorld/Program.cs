using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string subject = "World";

            if (args.Length > 0)
            {

                subject = args[0];
            }

            Console.WriteLine($"Hello {subject}!");
        }
    }
}
