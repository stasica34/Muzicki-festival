using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Muzicki_festival.Entiteti
{
    public class Clan
    {
        public virtual string IME { get; set; }
        public virtual string INSTRUMENT { get; set; }
        public virtual Bend Bend { get; set; }
        public Clan() { }
    }
}
