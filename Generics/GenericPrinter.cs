using System;

namespace Generics
{
    class GenericPrinter<T>
    {
        private T _firstProperty;
        private T _secondProperty;

        public GenericPrinter(T firstProperty, T secondProperty)
        {
            _firstProperty = firstProperty;
            _secondProperty = secondProperty;
        } 

        public void Print()
        {
            Console.WriteLine($"First property is: {_firstProperty}");
            Console.WriteLine($"Second property is: {_secondProperty}");
        }
    }
}
