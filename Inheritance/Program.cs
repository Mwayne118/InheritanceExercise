using System;

namespace Inheritance
{
    class Program
    {
        public static bool IsColdBlooded { get; private set; }
        public static bool HasScales { get; private set; }
        public static string Habitat { get; private set; }
        public static bool CanGrowTail { get; private set; }

        static void Main(string[] args)
        {
            Birds myBird = new Birds();
            myBird.WingColor = "blue";
            myBird.CanFly = true;
            myBird.WillMigrate = true;
            myBird.Beak = 6.4;

            Reptile myReptile = new Reptile();
            {
                IsColdBlooded = true;
                HasScales = true;
                Habitat = "swamp";
                CanGrowTail = true;




            };



  
             
        }
    }
}
