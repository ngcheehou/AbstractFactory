using NestedAbstractFactory.Interfaces.Furnitures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedAbstractFactory.Interfaces.Factories
{
    public interface IFurnitureFactory
    {
          IFurniture CreateChair();
          IFurniture CreateDiningTable();
    }
}
