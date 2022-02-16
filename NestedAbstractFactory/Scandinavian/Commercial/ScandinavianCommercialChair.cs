using NestedAbstractFactory.Interfaces.Furnitures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedAbstractFactory.Scandinavian.Commercial
{
    public class ScandinavianCommercialChair : ICommercialFurniture 
    {
       

        public void FurnitureFunction()
        {
            Console.WriteLine("Function: I'm used for sitting.");
        }

        public void FurnitureStyle()
        {
            Console.WriteLine("Style: I'm a Scandinavian Commercial Chair!");
        }

        public void Price()
        {
            Console.WriteLine("Price: I'm worth 100 dollar.");
        }

        
    }
}
