using AbstractFactoryTwoByStyle.Interfaces;
using System;

namespace AbstractFactoryTwoByStyle.Contemporary
{
    public class ContemporaryDiningTable : IFurniture
    {
        public void FurnitureFunction()
        {
            Console.WriteLine("People enjoying their food on me");
        }

        public void ShowStyle()
        {
            Console.WriteLine("I'm a Contemporary dining table");
        }
    }
}
