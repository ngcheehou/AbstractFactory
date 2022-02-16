using AbstractFactoryByFurnitureStyles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryByFurnitureStyles.Cabinet
{
    public class ContemporaryCabinet : IStyles
    {
        public void DesignPhilosophy()
        {
            Console.WriteLine("This style embraces minimalistic elements highlighting grays, " +
               "beiges and shades of white");
        }

        public void BuildMaterials()
        {
            Console.WriteLine("This style build by light colored wood like birch or maple, metal like nickel and " +
               "stainless steel, or glass.");
        }
    }
    }
