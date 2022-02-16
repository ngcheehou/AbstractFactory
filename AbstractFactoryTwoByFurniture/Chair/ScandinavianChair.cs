﻿using AbstractFactoryByFurnitureStyles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryTwoByFurniture.Chair
{
    public class ScandinavianChair : IStyles
    {
        public void DesignPhilosophy()
        {
            Console.WriteLine("This style focus on clean, simple lines, minimalism, " +
                     "and functionality without sacrificing beauty");
        }

        public void BuildMaterials()
        {

            Console.WriteLine("This style usually made of wood and other natural " +
                "elements like wicker and wool.");
        }
    
}
}