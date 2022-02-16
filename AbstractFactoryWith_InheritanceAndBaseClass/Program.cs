using AbstractFactoryWith_InheritanceAndBaseClass.BaseClasses;
using AbstractFactoryWith_InheritanceAndBaseClass.Classic;
using AbstractFactoryWith_InheritanceAndBaseClass.Contemporary;
using AbstractFactoryWith_InheritanceAndBaseClass.Scandinavian;
using System;

namespace AbstractFactoryWith_InheritanceAndBaseClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            int style;
            int furniture;
            Console.WriteLine("With Abstract Factory by using base class and inheritance");
            do
            {
                Console.WriteLine("Please select your furniure style:");
                Console.WriteLine("[1]Classic, [2]Contemporary, [3]Scandinavian");
                int.TryParse(Console.ReadLine(), out style);
            }

            while (style == 0 || style > 3);

            FurnitureFactory Factory = null;
            switch (style)
            {
                case 1:
                    Factory = new ClassicFactory();
                    break;
                case 2:
                    Factory = new ContemporaryFactory();
                    break;
                case 3:
                    Factory = new ScandinavianFactory();
                    break;
            }

            do
            {
                Console.WriteLine("Please select your furniure :");
                Console.WriteLine("[1]Cabinet, [2]Chair, [3]Dining Table");
                int.TryParse(Console.ReadLine(), out furniture);
            }

            while (furniture == 0 || furniture > 3);

            Furniture furnitureProduct = null ;
            switch (furniture)
            {
                case 1:
                    furnitureProduct = Factory.CreateCabinet();
                    break;
                case 2:
                    furnitureProduct = Factory.CreateChair();
                    break;
                case 3:
                    furnitureProduct = Factory.CreateDiningTable();
                    break;
            }

            Console.WriteLine("Furniture Created: ");
            furnitureProduct.ShowStyle();
            furnitureProduct.FurnitureFunction();

            //FurnitureFactory Factory1 = new ClassicFactory();
            //FurnitureFactory Factory2 = new ContemporaryFactory();
            //FurnitureFactory Factory3 = new ScandinavianFactory();


            //// Classic
            //var cabinet1 = Factory1.CreateCabinet();
            //var chair1 = Factory1.CreateChair();
            //var diningTable1 = Factory1.CreateDiningTable();

            //Console.WriteLine("Classic Furniture:");
            //cabinet1.ShowStyle();
            //cabinet1.FurnitureFunction();
            //chair1.ShowStyle();
            //chair1.FurnitureFunction();
            //diningTable1.ShowStyle();
            //diningTable1.FurnitureFunction();
            //Console.WriteLine();



            ////Contemporary
            //var cabinet2 = Factory2.CreateCabinet();
            //var chair2 = Factory2.CreateChair();
            //var diningTable2 = Factory2.CreateDiningTable();

            //Console.WriteLine("Contemporary Furniture:");
            //cabinet2.ShowStyle();
            //cabinet2.FurnitureFunction();
            //chair2.ShowStyle();
            //chair2.FurnitureFunction();
            //diningTable2.ShowStyle();
            //diningTable2.FurnitureFunction();
            //Console.WriteLine();


            ////Scandinavian
            //var cabinet3 = Factory3.CreateCabinet();
            //var chair3 = Factory3.CreateChair();
            //var diningTable3 = Factory3.CreateDiningTable();

            //Console.WriteLine("Scandinavian Furniture:");
            //cabinet3.ShowStyle();
            //cabinet3.FurnitureFunction();
            //chair3.ShowStyle();
            //chair3.FurnitureFunction();
            //diningTable3.ShowStyle();
            //diningTable3.FurnitureFunction();
            //Console.WriteLine();

            Console.ReadLine();
        }
    }
}
