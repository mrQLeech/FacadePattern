using DifficultLibrary;
using FacadeObject;
using System;

namespace FacadeTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var obj1 = new DifficultObjectA();
            var obj2 = new DifficultObjectB();
            var facade = new Facade(obj1, obj2);
            facade.Operate();
            Console.ReadLine();
        }
    }
}
