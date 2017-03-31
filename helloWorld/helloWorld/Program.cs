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
            string subject = (args.Length > 0) ? args[0] : "World";

            Console.WriteLine($"Hello {subject}!");
        }
    }
}
