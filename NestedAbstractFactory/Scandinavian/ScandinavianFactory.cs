using NestedAbstractFactory.Contemporary;
using NestedAbstractFactory.Contemporary.Art;
using NestedAbstractFactory.Interfaces.Factories;
using NestedAbstractFactory.Interfaces.Furnitures;
using NestedAbstractFactory.Scandinavian.Art;
using NestedAbstractFactory.Scandinavian.Commercial;

namespace NestedAbstractFactory.Scandinavian
{
    public class ScandinavianFactory : IDesignFactory
    {


        public ScandinavianFactory()
        {

        }
         


        public IFurnitureFactory GetMarketingFactory(string marketingFactoryType)
        {
            switch (marketingFactoryType)
            {
                case nameof(ArtFactory):
                    return new ArtFactory(nameof(ScandinavianFactory));

                case nameof(CommercialFactory):
                    return new CommercialFactory(nameof(ScandinavianFactory));

                default:
                    return null;
            }
        }
 



        //public IFurniture CreateDiningTable()
        //{
        //    switch (_marketingFactoryType)
        //    {
        //        case nameof(ArtFactory):
        //            return new ScandinavianArtDiningTable();

        //        case nameof(CommercialFactory):
        //            return new ScandinavianCommercialDiningTable();

        //        default:
        //            return null;
        //    }
        //}


       
    }
}
