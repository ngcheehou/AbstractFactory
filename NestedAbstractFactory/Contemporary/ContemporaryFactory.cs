using NestedAbstractFactory.Scandinavian;
using NestedAbstractFactory.Contemporary.Art;
using NestedAbstractFactory.Interfaces.Factories;
using NestedAbstractFactory.Interfaces.Furnitures;
using NestedAbstractFactory.Scandinavian.Art;
using NestedAbstractFactory.Contemporary.Commercial;

namespace NestedAbstractFactory.Contemporary
{
     public class ContemporaryFactory : IDesignFactory
    { 
 
         


        public IFurnitureFactory GetMarketingFactory(string marketingFactoryType)
        {
            switch (marketingFactoryType)
            {
                case nameof(ArtFactory):
                    return new ArtFactory(nameof(ContemporaryFactory));

                case nameof(CommercialFactory):
                    return new CommercialFactory(nameof(ContemporaryFactory));


                default:
                    return null;
            }
        }

    }
}
