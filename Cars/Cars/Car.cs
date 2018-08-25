using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    class Car: Entity
    {
        public ushort Year { get; set;}
        public string Detailedinfo { get; set; }
        public Model Model { get; set; }
        public Marka Marka { get; set; }
        public int ModelID { get; set; }
    }
}
