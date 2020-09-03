using System;

namespace Inheritance
{
    class Program
    {
       
        static void Main(string[] args)
        {
            Birds myBird = new Birds();
            myBird.WingColor = "blue";
            myBird.CanFly = true;
            myBird.WillMigrate = true;
            myBird.Beak = 6.4;

            Reptile myReptile = new Reptile()
            {
                IsColdBlooded = true,
                HasScales = true,
                Habitat = "swamp",
                CanGrowTail = true




            };


            myReptile.Print();
  
             
      
        }
    }
}
