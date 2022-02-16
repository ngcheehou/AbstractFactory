using NestedAbstractFactory.Contemporary;
using NestedAbstractFactory.Contemporary.Commercial;
using NestedAbstractFactory.Interfaces.Furnitures;
using NestedAbstractFactory.Scandinavian;
using NestedAbstractFactory.Scandinavian.Commercial;

namespace NestedAbstractFactory.Interfaces.Factories
{
    public class CommercialFactory : IFurnitureFactory 
    { 
        private readonly string DesignName;

        
        public CommercialFactory(string designName)
        {
            DesignName = designName;
        }
        public IFurniture CreateChair()
        {
            switch (DesignName)
            {
                case nameof(ScandinavianFactory):
                    return new ScandinavianCommercialChair();

                case nameof(ContemporaryFactory):
                    return new ContemporaryCommercialChair();

                default:
                    return null;

            }
        }

        public IFurniture CreateDiningTable()
        {
            switch (DesignName)
            {
                case nameof(ScandinavianFactory):
                    return new ScandinavianCommercialDiningTable();

                case nameof(ContemporaryFactory):
                    return new ContemporaryCommercialDiningTable();

                default:
                    return null;

            }
        }
    }

}
