using NestedAbstractFactory.Interfaces.Furnitures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedAbstractFactory.Scandinavian.Art
{
   public class ScandinavianArtDiningTable : IArtFurniture 
    {
        public void FurnitureFunction()
        {
            Console.WriteLine("Function: People enjoying their food on me.");
        }

        public void FurnitureStyle()
        {
            Console.WriteLine("Style: I'm a Scandinavian Art Dining Table!");
        }

        public void FictionOrMythStory()
        {
            Console.WriteLine("Myth Story: Thor's Dining Table!");
        }

        
    }
}
