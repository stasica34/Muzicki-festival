using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Muzicki_festival.Entiteti
{
    public class VIpPogodnosti
    {
        public virtual int ID_ULAZNICE { get;protected set; }
        public virtual string POGODNOST { get; set; }
    }
}
