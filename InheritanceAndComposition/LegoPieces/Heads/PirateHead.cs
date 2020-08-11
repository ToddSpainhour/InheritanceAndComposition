using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceAndComposition.LegoPieces.Heads
{
    class PirateHead : Head
    {

        // properties

        public bool HasPatch { get; set; }
        public string FacialHair { get; set; }



        // methods

        public void Sing()
        {
            Console.WriteLine($"The {HairColor} pirate sang yet another song about rum.");
        }


        public void Laugh()
        {
            Console.WriteLine($"Raa har har har");
        }


        public override void Greet()
        {
            Console.WriteLine("Arrrrr, matey.");
        }
         
    }



  



}
