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
            ListWagons = new List<Wagon>();
            MaakWagons(BerekenAantalWagons(listVanDieren));

            VerdeelVleesEters(listVanDieren);
            VerdeelPlantEters(listVanDieren);
        }

        public int BerekenAantalWagons(List<Dier> listVanDieren)
        {
            int aantalVleesEters = 0;
            int aantalPlantEters = 0;

            int aantalWagons = 0;
            foreach (Dier dier in listVanDieren)
            {
                if (dier.SoortEter == SoortEter.Vlees.ToString())
                {
                    aantalVleesEters++;
                }
                if (dier.SoortEter == SoortEter.Plant.ToString())
                {
                    aantalPlantEters++;
                }
            }

            if (aantalPlantEters > 0)
            {
                if (aantalVleesEters > 0)
                {
                    aantalWagons = aantalVleesEters;
                    int aantalExtraWagons = 0;

                    //double berekenAantalExtraWagon = (double)aantalPlantEters / (aantalWagons * Wagon.GrootteInstelling - aantalVleesEters);
                    //if (berekenAantalExtraWagon > 1)
                   // {
                        aantalExtraWagons = Convert.ToInt32(Math.Ceiling((double)aantalPlantEters / (aantalWagons * Wagon.GrootteInstelling - aantalVleesEters)));
                    //}

                    return aantalWagons+aantalExtraWagons;
                }
                else
                {
                    aantalWagons = Convert.ToInt32(Math.Ceiling((double)aantalPlantEters / Wagon.GrootteInstelling));
                    return aantalWagons;  
                }
            }
            else
            {
                return 0;
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
            foreach (Dier dier in listVanDieren)
            {
                foreach (Wagon wagon in ListWagons)
                {
                    if (!dier.ZitInWagon)
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

                            //Check 2: dier is plant eter
                            if (dier.SoortEter == SoortEter.Plant.ToString())
                            {
                                skipToNextWagon = true;
                                break;
                            }

                            //Verdeel in wagon 
                            if (!skipToNextWagon)
                            {
                                //Verdeel dieren die eet: vlees
                                if (dier.SoortEter == SoortEter.Vlees.ToString())
                                {
                                    wagon.LijstDieren.Add(dier);

                                    skipToNextWagon = true;
                                    dier.ZitInWagon = true;
                                    break;
                                }

                            }
                        }
                    }
                }
            }
        }

        public void VerdeelPlantEters(List<Dier> listVanDieren)
        {
            foreach (Dier dier in listVanDieren)
            {
                foreach (Wagon wagon in ListWagons)
                {
                    if (!dier.ZitInWagon)
                    {
                        bool skipToNextWagon = false;

                        while (!skipToNextWagon)
                        {
                            foreach (Dier dierInWagon in wagon.LijstDieren)
                            {

                                //Check 1
                                int soortGrootteToInt = (int)Enum.Parse(typeof(Grootte), dierInWagon.Grootte);

                                if (dierInWagon.SoortEter == SoortEter.Vlees.ToString() & soortGrootteToInt >= (int)Grootte.Groot)
                                {
                                    skipToNextWagon = true;
                                    break;
                                }

                                //Check 2
                                int dierGrootteToInt = (int)Enum.Parse(typeof(Grootte), dier.Grootte);
                                int dierInWagonGrootteToInt = (int)Enum.Parse(typeof(Grootte), dierInWagon.Grootte);

                                if (dierInWagon.SoortEter == SoortEter.Vlees.ToString() & dierInWagonGrootteToInt >= dierGrootteToInt)
                                {
                                    skipToNextWagon = true;
                                    break;
                                }

                            }

                            //Verdeel in wagon 
                            if (!skipToNextWagon)
                            {
                                //Verdeel dieren die eet: plant
                                if (dier.SoortEter == SoortEter.Plant.ToString())
                                {
                                    wagon.LijstDieren.Add(dier);

                                    dier.ZitInWagon = true;
                                    skipToNextWagon = true;
                                    break;
                                }
                                
                            }

                        }
                    }
                }
            }
        }

    }
}
