using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactoryWith_InheritanceAndBaseClass.BaseClasses;

namespace AbstractFactoryWith_InheritanceAndBaseClass.Scandinavian
{
    public class ScandinavianDiningTable : Furniture
    {
        public override void FurnitureFunction()
        {
            Console.WriteLine("People enjoying their food on me");
        }

        public override void ShowStyle()
        {
            Console.WriteLine("I'm a Scandinavian Dining table ");
        }
    }
}
