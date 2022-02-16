using NestedAbstractFactory.Interfaces.Furnitures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedAbstractFactory.Contemporary.Art
{
  public  class ContemporaryArtChair: IArtFurniture  
    {
        public void FurnitureFunction()
        {
            Console.WriteLine("Function: I'm used for sitting.");
        }

        public void FurnitureStyle()
        {
            Console.WriteLine("Style: I'm a Contemporary Art Chair!");
        }

        public void FictionOrMythStory()
        {
            Console.WriteLine("Fiction Story: Professor X's wheel chair!");
        }

         
    }
}
