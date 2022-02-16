using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryWith_InheritanceAndBaseClass.BaseClasses
{
    public abstract class Furniture
    {
        public virtual void FurnitureFunction()
        { 
            Console.WriteLine("Dummy furniture function");
        }


        public virtual void ShowStyle() 
        {
            Console.WriteLine("Dummy styles");
        }
    }
}
