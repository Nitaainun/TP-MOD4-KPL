﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul4_1302200019
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HaloGeneric<string> halo = new HaloGeneric<string>();
            String x = "Halo user x";
            halo.SapaUser(x);
        }
    }
    public class HaloGeneric<T>
    {
        public void SapaUser(T  x)
        {
            Console.WriteLine("halo" + x);
        }
    }
}