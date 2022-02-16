using System;
using WithoutAbstractFactory.Classic;
using WithoutAbstractFactory.Contemporary;
using WithoutAbstractFactory.Scandinavian;

namespace WithoutAbstractFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int style;
            int furniture;
            Console.WriteLine("Without Abstract Factory");
            Console.WriteLine();

            do
            {
                Console.WriteLine("Please select your furniure style:");
                Console.WriteLine("[1]Classic, [2]Contemporary, [3]Scandinavian");
                int.TryParse(Console.ReadLine(), out style);
            }
            while (style == 0 || style > 3);


            switch (style)
            {
                case 1://Classic
                    do
                    {
                        Console.WriteLine("Please select your furniure :");
                        Console.WriteLine("[1]Cabinet, [2]Chair, [3]Dining Table");
                        int.TryParse(Console.ReadLine(), out furniture);
                    } while (furniture == 0 ||  furniture > 3);

                    switch (furniture)
                    {
                        case 1://Cabinet
                            ClassicCabinet cabinet = new ClassicCabinet();
                            cabinet.ShowStyle();
                            cabinet.FurnitureFunction();
                            break;
                        case 2://Chair
                            ClassicChair chair = new ClassicChair();
                            chair.ShowStyle();
                            chair.FurnitureFunction();
                            break;
                        case 3://Dinning table
                            ClassicDiningTable diningtable = new ClassicDiningTable();
                            diningtable.ShowStyle();
                            diningtable.FurnitureFunction();
                            break;
                         
                    }

                    break;
                case 2://Contemporary
                    do
                    {
                        Console.WriteLine("Please select your furniure :");
                        Console.WriteLine("[1]Cabinet, [2]Chair, [3]Dining Table");
                        int.TryParse(Console.ReadLine(), out furniture);
                    } while (furniture == 0 ||  furniture > 3);

                    switch (furniture)
                    {
                        case 1://Cabinet
                            ContemporaryCabinet cabinet = new ContemporaryCabinet();
                            cabinet.ShowStyle();
                            cabinet.FurnitureFunction();
                            break;
                        case 2://Chair
                            ContemporaryChair chair = new ContemporaryChair();
                            chair.ShowStyle();
                            chair.FurnitureFunction();
                            break;
                        case 3://Dinning table
                            ContemporaryDiningTable diningtable = new ContemporaryDiningTable();
                            diningtable.ShowStyle();
                            diningtable.FurnitureFunction();
                            break;
                    }
                    break;
                case 3://Scandinavian
                    do
                    {
                        Console.WriteLine("Please select your furniure :");
                        Console.WriteLine("[1]Cabinet, [2]Chair, [3]Dining Table");
                        int.TryParse(Console.ReadLine(), out furniture);
                    } while (furniture == 0 ||  furniture > 3);

                    switch (furniture)
                    {
                        case 1://Cabinet
                            ScandinavianCabinet cabinet = new ScandinavianCabinet();
                            cabinet.ShowStyle();
                            cabinet.FurnitureFunction();
                            break;
                        case 2://Chair
                            ScandinavianChair chair = new ScandinavianChair();
                            chair.ShowStyle();
                            chair.FurnitureFunction();
                            break;
                        case 3://Dinning table
                            ScandinavianDiningTable diningtable = new ScandinavianDiningTable();
                            diningtable.ShowStyle();
                            diningtable.FurnitureFunction();
                            break;
                    }
                    break;

                    // case 4:

            }





            Console.ReadLine();
        }
    }
}
