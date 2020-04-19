using System;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericPrinter<int> intobject = new GenericPrinter<int>(10, 20);

            intobject.Print();

            GenericPrinter<string> stringobject = new GenericPrinter<string>("Generic Method", "Generic Class");

            stringobject.Print();

            Console.Read();
        }
    }
}
