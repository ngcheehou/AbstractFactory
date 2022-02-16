using AbstractFactoryTwoByStyle.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryTwoByStyle.Contemporary
{
    public class ContemporaryChair : IFurniture
    {
        public void FurnitureFunction()
        {
            Console.WriteLine("I'm used for sitting");
        }

        public void ShowStyle()
        {
            Console.WriteLine("I'm a Contemporary chair ");
        }
    }
}
