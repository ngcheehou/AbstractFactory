using AbstractFactoryWith_InheritanceAndBaseClass.BaseClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryWith_InheritanceAndBaseClass.Scandinavian
{
    public class ScandinavianFactory : FurnitureFactory
    {
        public override Furniture CreateCabinet()
        {
            return new ScandinavianCabinet();
        }

        public override Furniture CreateChair()
        {
            return new ScandinavianChair();
        }

        public override Furniture CreateDiningTable()
        {
            return new ScandinavianDiningTable();
        }
    }
}
