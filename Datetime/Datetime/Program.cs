using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datetime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime today = DateTime.Now;
            DateTime Future = today.AddDays(26);
            Console.WriteLine(today);
            Console.WriteLine(Future);
            var difference = Future - today;
            Console.WriteLine(difference);
            Console.ReadKey();

        }
    }
}
