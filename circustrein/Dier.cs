using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace circustrein
{
    class Dier
    {
        public string SoortEter { get; set; }
        public string Grootte { get; set; }
        public bool ZitInWagon { get; set; }
        public Dier(string soortEter, string grootte)
        {
            SoortEter = soortEter;
            Grootte = grootte;
            ZitInWagon = false;
        }

        public override string ToString()
        {
            return string.Format("SoortEter: {0} | Grootte: {1}", SoortEter, Grootte);
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
        Plant = 1,
        Vlees = 2
    }
}
