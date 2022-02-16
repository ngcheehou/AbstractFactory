using AbstractFactoryTwoByStyle.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryTwoByStyle.Contemporary
{
    public class ContemporaryFurnitureFactory : IFurnitureFactory
    {
        

        public IFurniture CreateCabinet()
        {
            return new ContemporaryCabinet();
        }

        public IFurniture CreateChair()
        {
            return new ContemporaryChair();
        }

        public IFurniture CreateDiningTable()
        {
            return new ContemporaryDiningTable();
        }
    }
}
