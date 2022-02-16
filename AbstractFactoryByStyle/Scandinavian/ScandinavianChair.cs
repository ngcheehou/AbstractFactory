using AbstractFactoryTwoByStyle.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryTwoByStyle.Scandinavian
{
    public class ScandinavianChair : IFurniture
    {
        public void FurnitureFunction()
        {
            Console.WriteLine("I'm used for sitting");
        }

        public void ShowStyle()
        {
            Console.WriteLine("I'm a Scandinavian chair ");
        }
    }
}
