using AbstractFactoryByFurnitureStyles;
using AbstractFactoryByFurnitureStyles.DiningTable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryByFurnitureStyles
{
    public class DiningTableFactory : IStyleFactory
    {
        public IStyles CreateClassic()
        {
            return new ClassicDiningTable();
        }

        public IStyles CreateContemporary()
        {
            return new ContemporaryDiningTable();
        }

        public IStyles CreateScandinavian()
        {
            return new ScandinavianDiningTable();
        }
    }
}
