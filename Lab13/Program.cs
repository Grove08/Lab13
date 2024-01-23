using System;

namespace Lab13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MultiBuilding multiBuilding = new MultiBuilding("Невский проспект", 30000, 35000, 30000, 50);
            Console.WriteLine(multiBuilding.Print());
            Console.ReadKey();
        }
    }
}
