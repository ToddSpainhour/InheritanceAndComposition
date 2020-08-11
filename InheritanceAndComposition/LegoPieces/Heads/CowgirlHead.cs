using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceAndComposition.LegoPieces.Heads
{
    class CowgirlHead : Head
    {

        // properties

        
        public bool HasHat { get; set; }
        public LipstickColor LipstickColor { get; set; }



        // methods

        public void HairFlip()
        {
            Console.WriteLine($"The corgirl flips her {HairColor} hair.");
        }

        public override void Greet()
        {
            Console.WriteLine("Howdy, partner.");
        }

        public void Eat()
        {
            Console.WriteLine("The cowgirl eats the meal she made over the campfire.");
        }
       
    }



   


}
