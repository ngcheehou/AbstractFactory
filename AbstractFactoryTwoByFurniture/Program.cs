using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryByFurnitureStyles
{
    internal class Program
    {
        static void Main(string[] args)
        {

            IStyleFactory cabinetFactory = new CabinetFactory();
            IStyleFactory chairFactory = new ChairFactory();
            IStyleFactory diningTableFactory = new DiningTableFactory();


            //Cabinet
            var classic1 = cabinetFactory.CreateClassic();
            var contemporary1 = cabinetFactory.CreateContemporary();
            var Scandinavian1 = cabinetFactory.CreateScandinavian();
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Furniture: Cabinet");

            Console.Write("Classic: ");
            classic1.DesignPhilosophy();
            classic1.BuildMaterials();
            Console.WriteLine();
            Console.Write("Contemporary: ");
            contemporary1.DesignPhilosophy();
            contemporary1.BuildMaterials();
            Console.WriteLine();
            Console.Write("Scandinavian: ");
            Scandinavian1.DesignPhilosophy();
            Scandinavian1.BuildMaterials();
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");


            //Chair
            var classic2 = chairFactory.CreateClassic();
            var contemporary2 = chairFactory.CreateContemporary();
            var Scandinavian2 = chairFactory.CreateScandinavian();
            Console.WriteLine("Furniture: Chair");
            Console.Write("Classic: ");
            classic2.DesignPhilosophy();
            classic2.BuildMaterials();
            Console.WriteLine();
            Console.Write("Contemporary: ");
            contemporary2.DesignPhilosophy();
            contemporary2.BuildMaterials();
            Console.WriteLine();
            Console.Write("Scandinavian: ");
            Scandinavian2.DesignPhilosophy();
            Scandinavian2.BuildMaterials();
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");



            //DiningTable
            var classic3 = diningTableFactory.CreateClassic();
            var contemporary3 = diningTableFactory.CreateContemporary();
            var Scandinavian3 = diningTableFactory.CreateScandinavian();
            Console.WriteLine("Furniture: Dining Table");
            Console.Write("Classic: ");
            classic3.DesignPhilosophy();
            classic3.BuildMaterials();
            Console.WriteLine();
            Console.Write("Contemporary: ");
            contemporary3.DesignPhilosophy();
            contemporary3.BuildMaterials();
            Console.WriteLine();
            Console.Write("Scandinavian: ");
            Scandinavian3.DesignPhilosophy();
            Scandinavian3.BuildMaterials();
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");



            Console.ReadLine();
        }
    }
}
