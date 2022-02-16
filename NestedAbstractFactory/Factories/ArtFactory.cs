using NestedAbstractFactory.Contemporary;
using NestedAbstractFactory.Contemporary.Art;
using NestedAbstractFactory.Interfaces.Furnitures;
using NestedAbstractFactory.Scandinavian;
using NestedAbstractFactory.Scandinavian.Art;

namespace NestedAbstractFactory.Interfaces.Factories
{
    public class ArtFactory : IFurnitureFactory
    {
        private readonly string DesignName;

        public ArtFactory()
        {

        }
        public ArtFactory(string designName)
        {
            DesignName = designName;
        }
        public IFurniture CreateChair()
        {
            switch (DesignName)
            {
                case nameof(ScandinavianFactory):
                    return new ScandinavianArtChair();
                   
                case nameof(ContemporaryFactory):
                    return new ContemporaryArtChair();

                default:
                    return null;
                    
            }
        }

        public IFurniture CreateDiningTable()
        {
            switch (DesignName)
            {
                case nameof(ScandinavianFactory):
                    return new ScandinavianArtDiningTable();

                case nameof(ContemporaryFactory):
                    return new ContemporaryArtDiningTable();

                default:
                    return null;

            }
        }
    }
}
