using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryWith_InheritanceAndBaseClass.BaseClasses
{
    public abstract class FurnitureFactory
    {
        public abstract Furniture CreateCabinet();
        public abstract Furniture CreateChair();
        public abstract Furniture CreateDiningTable();
    }
}
