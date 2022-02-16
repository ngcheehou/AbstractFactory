using AbstractFactoryTwoByStyle.Interfaces;
using System;

namespace AbstractFactoryTwoByStyle.Scandinavian
{
    public class ScandinavianDiningTable : IFurniture
    {
        public void FurnitureFunction()
        {
            Console.WriteLine("People enjoying their food on me");
        }

        public void ShowStyle()
        {
            Console.WriteLine("I'm a Scandinavian Dining table ");
        }
    }
}
