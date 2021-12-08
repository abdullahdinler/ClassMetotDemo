using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CostemerManager
    {
        public void Add(Costemer costemer)
        {
            Console.WriteLine(costemer.CostemerFirstName + " Musteri Eklendi.");
        }
        public void Remove(Costemer costemer)
        {
            Console.WriteLine(costemer.CostemerFirstName + " Musteri cikarildi.");
        }
    }
}
