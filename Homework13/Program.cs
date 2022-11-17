using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Building building = new Building("адрес1", 100, 14, 25);
            Console.WriteLine(building.Print());
            Multibuilding multi = new Multibuilding("адрес 2", 25, 14, 9, 3);
            Console.WriteLine(multi.Print());
            Console.ReadLine();
        }
    }
}
