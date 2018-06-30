using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBPRAKTIKA
{
    class PlantClass
    {
        public string name { get; set; }
        public int id { get; set; }
        public string note { get; set; }
        public bool rel { get; set; }
        public int xtraid { get; set; }


        public string relstat()
        {
            if (rel)
            { return " Draugauja "; }
            else { return " Nedraugauja "; }
        }
    }
}
