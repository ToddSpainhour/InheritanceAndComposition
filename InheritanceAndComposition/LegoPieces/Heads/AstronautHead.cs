using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceAndComposition.LegoPieces.Heads
{
    class AstronautHead : Head
    // AstronautHead inherite from Head
    {
        // properties

        public bool HasHelment { get; set; } = true;
        public bool HasFreckles { get; set; }




        // methods

        // to change a inherited 'virtual' method 'override' keyword says you are changing the behavior
        public override void Greet()
        {
            Console.WriteLine("Major Tom to Ground Control.");
            // the base class for AstronautHead is Head. It gives you access to stuff inside the class you are inheriting from
            base.Greet();
        }


        public void Observe()
        {
            Console.WriteLine("The Astronaut observed the surface.");
        }

    }
}
