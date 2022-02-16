using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactoryWith_InheritanceAndBaseClass.BaseClasses;

namespace AbstractFactoryWith_InheritanceAndBaseClass.Scandinavian
{
    public class ScandinavianCabinet : Furniture
    {
        public override void FurnitureFunction()
        {
            Console.WriteLine("I'm used for storing item");
        }

        public override void ShowStyle()
        {
            Console.WriteLine("I'm a Scandinavian cabinet ");
        }
    }
}
