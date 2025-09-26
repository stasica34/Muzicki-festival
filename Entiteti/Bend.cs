using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Muzicki_festival.Entiteti
{
    public class Bend
    {
        public virtual int ID { get; protected set; }
        public virtual int BROJ_CLANOVA { get; set; }
        public virtual IList<Clan> Clanovovi { get; set; }
        public Bend() {
            Clanovovi = new List<Clan>();
        }

    }
}
