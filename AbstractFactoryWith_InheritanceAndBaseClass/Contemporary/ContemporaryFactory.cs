using AbstractFactoryWith_InheritanceAndBaseClass.BaseClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryWith_InheritanceAndBaseClass.Contemporary
{
    public class ContemporaryFactory : FurnitureFactory
    {
        public override Furniture CreateCabinet()
        {
           return new ContemporaryCabinet();  
        }

        public override Furniture CreateChair()
        {
            return new ContemporaryChair();
        }

        public override Furniture CreateDiningTable()
        {
            return new ContemporaryDiningTable();
        }
    }
}
