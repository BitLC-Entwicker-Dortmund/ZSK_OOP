using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZSK_OOP {
    class Program {
        static void Main ( string [ ] args ) {
            Waehrungsrechner zsk = new Waehrungsrechner ( );
            zsk.BerechneEuroInZSK ( 5000 );

        }
    }
}
