using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace circustrein
{
    class Dier
    {
        public int SoortEter { get; set; }
        public int Grootte { get; set; }

        public Dier(int soortEter, int grootte)
        {
            SoortEter = soortEter;
            Grootte = grootte;
        }

        public override string ToString()
        {
            string soortEterName = Enum.GetName(typeof(SoortEter), SoortEter);
            string grootteName = Enum.GetName(typeof(Grootte), Grootte);
            return string.Format("SoortEter: {0} | Grootte: {1}", soortEterName, grootteName);
        }
    }

    public enum Grootte
    {
        Klein = 1,
        Middel = 3,
        Groot = 5
    }
    public enum SoortEter
    {
        Normaal = 1,
        VleesEter = 2
    }
}
