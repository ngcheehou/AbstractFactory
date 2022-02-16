using NestedAbstractFactory.Interfaces.Furnitures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedAbstractFactory.Contemporary.Commercial
{
    public class ContemporaryCommercialChair: ICommercialFurniture 
    {
        public void FurnitureFunction()
        {
            Console.WriteLine("Function: I'm used for sitting.");
        }

        public void FurnitureStyle()
        {
            Console.WriteLine("Style: I'm a Contemporary Commercial Chair!");
        }

        public void Price()
        {
            Console.WriteLine("Price: I worth 100 dollar.");
        }

        
    }
}
