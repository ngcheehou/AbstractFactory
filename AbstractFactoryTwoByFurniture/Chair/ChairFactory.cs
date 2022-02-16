using AbstractFactoryByFurnitureStyles;
using AbstractFactoryTwoByFurniture.Chair;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryByFurnitureStyles
{
    public class ChairFactory : IStyleFactory
    {
        public IStyles CreateClassic()
        {
            return new ClassicChair();
        }

        public IStyles CreateContemporary()
        {
            return new ContemporaryChair();
        }

        public IStyles CreateScandinavian()
        {
            return new ScandinavianChair();
        }
    }
}
