using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace circustrein
{
    class Trein
    {
        public List<Wagon> ListWagons { get; set; }

        public Trein(List<Dier> listVanDieren)
        {
            VerdeelDierenInWagons(listVanDieren);
        }

        public void VerdeelDierenInWagons(List<Dier> listVanDieren)
        {
            MaakWagons(BerekenAantalWagons(listVanDieren));

            VerdeelVleesEters(listVanDieren);
            VerdeelPlantEters(listVanDieren);
            //List<Wagon> tempListWagon = new List<Wagon>();

            //int AantalWagons = BerekenAantalWagons(listVanDieren);

            //tempListWagon = MaakWagons(AantalWagons);

            //tempListWagon = VerdeelDierenVleesEters(tempListWagon, listVanDieren);
        }

        public int BerekenAantalWagons(List<Dier> listVanDieren)
        {
            int aantalVleesEters = 0;
            int aantalDierenWagon = 0;

            if (Wagon.GrootteInstelling > 0)
            {
                aantalDierenWagon = listVanDieren.Count / Wagon.GrootteInstelling;
            }

            foreach (Dier dier in listVanDieren)
            {
                if (dier.SoortEter == SoortEter.Vlees.ToString())
                {
                    aantalVleesEters++;
                }
            }

            if(aantalVleesEters >= aantalDierenWagon)
            {
                return aantalVleesEters;
            }
            else
            {
                return aantalDierenWagon;
            }

        }

        public void MaakWagons(int aantal)
        {
            for (int i = 0; i < aantal; i++)
            {
                Wagon wagon = new Wagon(ListWagons.Count+1, Wagon.GrootteInstelling);
                ListWagons.Add(wagon);
            }
        }

        public void VerdeelVleesEters(List<Dier> listVanDieren)
        { 
            foreach (Wagon wagon in ListWagons)
            {
                bool skipToNextWagon = false;
                while (!skipToNextWagon)
                {
                    //Check 1: In wagon bevat vlees eter
                    foreach (Dier dierInWagon in wagon.LijstDieren)
                    {
                        if (dierInWagon.SoortEter == SoortEter.Vlees.ToString())
                        {
                            skipToNextWagon = true;
                            break;
                        }
                    }

                    //Verdeel in wagon 
                    if (!skipToNextWagon)
                    {
                        foreach (Dier dier in listVanDieren)
                        {
                            //Verdeel dieren die eter: vlees
                            if (dier.SoortEter == SoortEter.Vlees.ToString())
                            {
                                wagon.LijstDieren.Add(dier);
                            }
                        }
                    }
                }
            }
        }

        public void VerdeelPlantEters(List<Dier> listVanDieren)
        {
            foreach (Wagon wagon in ListWagons)
            {
                bool skipToNextWagon = false;
                while (!skipToNextWagon)
                {
                    //Check 1: 
                    foreach (Dier dierInWagon in wagon.LijstDieren)
                    {
                        //Is vlees eter
                        if (dierInWagon.SoortEter == SoortEter.Vlees.ToString())
                        {
                            if (true)
                            {
                                
                            }
                            skipToNextWagon = true;
                            break;
                        }
                    }

                    //Verdeel in wagon 
                    if (!skipToNextWagon)
                    {
                        foreach (Dier dier in listVanDieren)
                        {
                            //Verdeel dieren die eter: vlees
                            if (dier.SoortEter == SoortEter.Vlees.ToString())
                            {
                                wagon.LijstDieren.Add(dier);
                            }
                        }
                    }
                }
            }
        }

    }
}
