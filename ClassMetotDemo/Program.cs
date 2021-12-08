using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Costemer person1 = new Costemer();
            person1.CostemerId = 1;
            person1.CostemerFirstName = "Abdullah";
            person1.CostemerLastaName = "Dinler";
            person1.CostemerMember = "Eski Musteri";

            Costemer person2 = new Costemer();
            person2.CostemerId = 2;
            person2.CostemerFirstName = "Ibrahim";
            person2.CostemerLastaName = "Sanli";
            person2.CostemerMember = "Yeni musteri";

            Costemer[] costemers = new Costemer[] {person1, person2 };
            foreach (var costemer1 in costemers)
            {
                Console.WriteLine(costemer1.CostemerId + " " + costemer1.CostemerFirstName + " " + costemer1.CostemerLastaName + " " + costemer1.CostemerMember);
            }

            Console.WriteLine(" ---- ----- -- -- - - - - - - -- - - - - - -");
            // Musteri ekleme ve cikarma
            CostemerManager costemer = new CostemerManager();
            costemer.Add(person1);
            costemer.Remove(person2);


        }
    }
}
