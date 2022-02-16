using AbstractFactoryWith_InheritanceAndBaseClass.BaseClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryWith_InheritanceAndBaseClass.Classic
{
    public class ClassicDiningTable : Furniture
    {
        public override void FurnitureFunction()
        {
            Console.WriteLine("People enjoying their food on me");
        }

        public override void ShowStyle()
        {
            Console.WriteLine("I'm a Classical dining table ");
        }
    }
}
