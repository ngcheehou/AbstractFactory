using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedAbstractFactory.Interfaces.Factories
{
    public interface IDesignFactory 
    {
        IFurnitureFactory GetMarketingFactory(string marketingFactoryType);
        
    }
}
