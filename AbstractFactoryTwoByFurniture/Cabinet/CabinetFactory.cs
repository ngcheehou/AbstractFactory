using AbstractFactoryByFurnitureStyles;
using AbstractFactoryByFurnitureStyles.Cabinet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryByFurnitureStyles
{
    public class CabinetFactory : IStyleFactory
    {
        public IStyles CreateClassic()
        {
            return new ClassicCabinet();
        }

        public IStyles CreateContemporary()
        {
            return new ContemporaryCabinet();
        }

        public IStyles CreateScandinavian()
        {
            return new ScandinavianCabinet();
        }
    }
}
