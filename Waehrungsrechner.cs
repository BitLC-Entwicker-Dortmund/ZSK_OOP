using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZSK_OOP {
    class Waehrungsrechner {
        // fields

        int preisKuh = 2800;
        int preisSchaf = 650;
        int preisZiege = 500;
        int preisKleineZiege = 50;

        int preisDorsch = 8;

        // methodes
        public int[] BerechneEuroInZSK(int betrag ) {
            int [ ] erg = new int [ 5 ];
            int rest = betrag;
            // Berechnungen ....
            erg [ 0 ] = rest / preisKuh;
            rest = rest % preisKuh;

            erg [ 1 ] = rest / preisSchaf;
            rest = rest % preisSchaf;

            erg [ 2 ] = rest / preisZiege;
            rest = rest % preisZiege;

            erg [ 3 ] = rest / preisKleineZiege;
            rest = rest % preisKleineZiege;

            erg [ 4 ] = rest;
 
            return erg;
        }

        public int [ ] BerechneEuroInDAHRS ( int betrag ) {
            int [ ] erg = new int [ 5 ];
            // Berechnungen ....

            return erg;
        }

        public int BerechneZSKInEuro(int[] anzahlTiere) {
            return 0;
        }

        public int BerechneDAHRSInEuro ( int [ ] anzahlFische ) {
            return 0;
        }



    }
}
