using AbstractFactoryByFurnitureStyles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryByFurnitureStyles.Cabinet
{
    public class ClassicCabinet:  IStyles
    {
        public void DesignPhilosophy()
        {
            Console.WriteLine("This style inspiration from English and French styles of the " +
                "18th and 19th centuries");
        }

        public void BuildMaterials()
        {
            Console.WriteLine("This style build by oak, cherry, walnut and birch. " +
           "As for the upholstery, it is brocade, satin, velvet, silk and leather");
        }
    }
}
