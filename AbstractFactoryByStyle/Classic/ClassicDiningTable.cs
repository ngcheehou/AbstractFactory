using AbstractFactoryTwoByStyle.Interfaces;
using System;

namespace AbstractFactoryTwoByStyle.Classic
{
    public class ClassicDiningTable : IFurniture
    {
        public void FurnitureFunction()
        {
            Console.WriteLine("People enjoying their food on me");
        }

        public void ShowStyle()
        {
            Console.WriteLine("I'm a Classical dining table ");
        }
    }
}
