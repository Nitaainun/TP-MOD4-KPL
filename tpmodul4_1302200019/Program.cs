<<<<<<< HEAD
﻿Console.Write("Hello World");
=======
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
<<<<<<< HEAD
            HaloGeneric<string> halo = new HaloGeneric<string>();
            String x = "Nita";
            halo.SapaUser(x);

=======
            DataGeneric<String> data = new DataGeneric<string>("1302202095");
            data.PrintData();
        }
    }

    public class DataGeneric<T>
    {
        private T data;
        public DataGeneric(T data)
        {
            this.data = data;
        }
        public void PrintData()
        {
            Console.WriteLine("Data yang tersimpan adalah: " + this.data);
>>>>>>> generic-class
        }
    }
    public class HaloGeneric<T>
    {
        public void SapaUser(T x)
        {
            Console.WriteLine("Halo " + x);
        }
    }
}
>>>>>>> generic-method
