using AbstractFactoryTwoByStyle.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryTwoByStyle.Contemporary
{
    public class ContemporaryCabinet : IFurniture
    {
        public void FurnitureFunction()
        {
            Console.WriteLine("I'm used for storing item");
        }

        public void ShowStyle()
        {
            Console.WriteLine("I'm a Contemporary cabinet ");
        }
    }
}
