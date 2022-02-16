using AbstractFactoryWith_InheritanceAndBaseClass.BaseClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryWith_InheritanceAndBaseClass.Classic
{
    public class ClassicFactory : FurnitureFactory
    {
        public override Furniture CreateCabinet()
        {
            return new ClassicCabinet();
        }

        public override Furniture CreateChair()
        {
            return new ClassicChair();
        }

        public override Furniture CreateDiningTable()
        {
            return new ClassicDiningTable();
        }
    }
}
