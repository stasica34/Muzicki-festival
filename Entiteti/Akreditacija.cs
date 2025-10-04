using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Muzicki_festival.Entiteti
{
    public class Akreditacija:Ulaznica
    {
        public virtual string SPONZOR { get; set; }
        public virtual string PRESS { get; set; }
        public virtual string PARTNER { get; set; }
        //fk ka Ulaznica
        public Akreditacija() { }
    }
}

