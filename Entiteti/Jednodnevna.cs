using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Muzicki_festival.Entiteti
{
    public class Jednodnevna
    {
        public virtual int ID_ULAZNICE { get; set; }
        public virtual DateTime DAN_VAZENJA { get; set; }
        public Jednodnevna() { }
    }
}
