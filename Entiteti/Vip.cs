using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Muzicki_festival.Entiteti
{
    public class Vip
    {
        public virtual int ID_ULAZNICE { get; set; }
        //fk ka Ulaznica
        public virtual Ulaznica Ulaznica { get; set; }

        //povezivanje visevrednostnog atributa
        public virtual IList<VIpPogodnosti> Pogodnosti { get; set; }
        public Vip() 
        {
            Pogodnosti = new List<VIpPogodnosti>();
        }   
    }
}
