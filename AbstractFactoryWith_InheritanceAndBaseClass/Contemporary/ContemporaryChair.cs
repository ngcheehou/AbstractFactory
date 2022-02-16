using AbstractFactoryWith_InheritanceAndBaseClass.BaseClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryWith_InheritanceAndBaseClass.Contemporary
{
    public class ContemporaryChair : Furniture
    {
        public override void FurnitureFunction()
        {
            Console.WriteLine("I'm used for sitting");
        }

        public override void ShowStyle()
        {
            Console.WriteLine("I'm a Contemporary chair ");
        }
    }
}
