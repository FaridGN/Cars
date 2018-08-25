using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    class Model:Entity
    {
        public int MarkaId { get; set; }
        public Marka Marka { get; set; }
    }
}
