using NestedAbstractFactory.Interfaces.Furnitures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedAbstractFactory.Contemporary.Art
{
    public class ContemporaryArtDiningTable : IArtFurniture 
    {
        public void FurnitureFunction()
        {
            Console.WriteLine("Function: People enjoying their food on me.");
        }

        public void FurnitureStyle()
        {
            Console.WriteLine("Style: I'm a Contemporary Art Dining Table!");
        }

        public void FictionOrMythStory()
        {
            Console.WriteLine("Science Fiction Story: High Tech IoT Dining Table!");
        }

        
    }
}
