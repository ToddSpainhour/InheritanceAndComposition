using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceAndComposition.LegoPieces.Heads
{


    class Head
    {
        public EyeColor EyeColor { get; set; }
        public HairColor HairColor { get; set; }

        // if you want the class that inherites from this to change this method's behavior add 'virtual'

        public virtual void Greet()
        {
            Console.WriteLine("Hello there.");
        }


    }

   
}
