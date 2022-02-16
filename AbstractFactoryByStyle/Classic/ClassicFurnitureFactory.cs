﻿using AbstractFactoryTwoByStyle.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryTwoByStyle.Classic
{
    public class ClassicFurnitureFactory : IFurnitureFactory
    {
        public IFurniture CreateCabinet()
        {
            return new ClassicCabinet();
        }

        public IFurniture CreateChair()
        {
            return new ClassicChair();
        }

        public IFurniture CreateDiningTable()
        {
            return new ClassicDiningTable();
        }
    }
}
