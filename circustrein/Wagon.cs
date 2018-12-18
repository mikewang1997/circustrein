using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace circustrein
{
    class Wagon
    {
        public int PositieInTrein { get; set; }
        public int Grootte { get; set; }
        public List<Dier> LijstDieren { get; set; }

        static public int GrootteInstelling = 0;

        public Wagon(int positieInTrein, int grootte)
        {
            PositieInTrein = positieInTrein;
            LijstDieren = new List<Dier>();
            Grootte = grootte;
        }

        public void VoegDierToeAanWagon(Dier dier)
        {
            LijstDieren.Add(dier);
        }

        public bool BevatGrootsteFormaatDierInWagon(Wagon wagon)
        {
            bool bevatGrootsteFormatDier = false;

            foreach (Dier dierWagon in wagon.LijstDieren)
            {
                if (dierWagon.Grootte == circustrein.Grootte.Groot.ToString())
                {
                    bevatGrootsteFormatDier = true;
                    break;
                }
            }
            return bevatGrootsteFormatDier;
        }
    }
}
