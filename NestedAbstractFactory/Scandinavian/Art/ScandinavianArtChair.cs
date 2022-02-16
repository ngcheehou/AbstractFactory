using NestedAbstractFactory.Interfaces.Furnitures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedAbstractFactory.Scandinavian.Art
{
    public class ScandinavianArtChair : IArtFurniture
    {
        public void FurnitureFunction()
        {
            Console.WriteLine("Function: I'm used for sitting");
        }

        public void FurnitureStyle()
        {
            Console.WriteLine("Style: I'm a Scandinavian Art Chair!");
        }

        public void FictionOrMythStory()
        {
            Console.WriteLine("Myth Story: Odin's Seat!");
        }

        
    }
}
