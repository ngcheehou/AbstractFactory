using NestedAbstractFactory.Contemporary;
using NestedAbstractFactory.Interfaces.Factories;
using NestedAbstractFactory.Interfaces.Furnitures;
using NestedAbstractFactory.Scandinavian;
using System;

namespace NestedAbstractFactory
{
    public class Program
    {
        static void Main(string[] args)
        {
            int design = 0;
            int marketing = 0;
            int furniture = 0;
            string designstyle = string.Empty;

            Console.WriteLine("Multiple Abstract Factory");

            IFurnitureFactory furnitureFactory = null;
            IFurniture product = null;
            IDesignFactory designFactory = null;


            do
            {
                Console.WriteLine("Please select your preference design style: [1]Contemporary, [2]Scandinavian");
                int.TryParse(Console.ReadLine(), out design);
            } while (design <= 0 || design > 2);



            switch (design)
            {
                case 1:
                    Console.WriteLine("Seems like you prefer Contemporary design!");
                    designFactory =    new ContemporaryFactory();
                    break;
                case 2:
                    Console.WriteLine("Seems like you prefer Scandinavian design!");
                    designFactory =  new ScandinavianFactory();
                    break;
                default:
                    designFactory = null;
                    break;
            }

            do
            {
                Console.WriteLine("Now, please select your preference type : [1]Art, [2]Commercial");
                int.TryParse(Console.ReadLine(), out marketing);
            } while (marketing <= 0 || marketing > 2);



            switch (marketing)
            {
                case 1:
                    Console.WriteLine("Cool! Seems like you are an artistic person!");
                    furnitureFactory = designFactory.GetMarketingFactory(nameof(ArtFactory)) ;
                    
                    break;
                case 2:
                    Console.WriteLine("Cool! Seems like you are fond with commercial world!");
                    furnitureFactory = designFactory.GetMarketingFactory(nameof(CommercialFactory));
                    break;
                default:
                    furnitureFactory = null;
                    break;
            }


            do
            {
                Console.WriteLine("Finally, please select your desired furniture: [1]Chair, [2]Dining Table");
                int.TryParse(Console.ReadLine(), out furniture);
            } while (furniture <= 0 || furniture > 2);


            switch (furniture)
            {
                case 1:
                    Console.WriteLine("Terrific choice! We sell the best chair in the town!");
                 
                    product = furnitureFactory.CreateChair();
                    break;
                case 2:
                    Console.WriteLine("Terrific choice! We sell the best dining table in the town!");
                    product = furnitureFactory.CreateDiningTable();
                    break;
                default:
                    product = null;
                    break;
            }

            Console.WriteLine();
            Console.WriteLine("Product created: ");
            Console.WriteLine("/*********************************************/");
            product.FurnitureStyle();
            product.FurnitureFunction();

             
           
            if (product is IArtFurniture artProduct)
            {
                
                Console.Write("The myth or fiction for this furniture is: ");
                artProduct.FictionOrMythStory();

            }
            else if (product is ICommercialFurniture commProduct)
            {
                Console.Write("The price of this furniture is: " );
                commProduct.Price();
            }
            Console.WriteLine("/*********************************************/");
            Console.ReadLine();

        }
    }
}
