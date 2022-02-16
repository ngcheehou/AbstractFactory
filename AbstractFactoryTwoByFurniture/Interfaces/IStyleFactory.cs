using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryByFurnitureStyles
{
    public interface IStyleFactory
    {
        IStyles CreateClassic();
        IStyles CreateContemporary();
        IStyles CreateScandinavian();

    }
}
