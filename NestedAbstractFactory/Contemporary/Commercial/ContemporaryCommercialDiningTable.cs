using NestedAbstractFactory.Interfaces.Furnitures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedAbstractFactory.Contemporary.Commercial
{
  public  class ContemporaryCommercialDiningTable : ICommercialFurniture
    {
        public void FurnitureFunction()
        {
            Console.WriteLine("Function: People enjoying their food on me.");
        }

        public void FurnitureStyle()
        {
            Console.WriteLine("Style: I'm a Contemporary Commercial Dining Table!");
        }

        public void Price()
        {
            Console.WriteLine("Price: I'm worth 500 dollar.");
        }

        
    }
}
