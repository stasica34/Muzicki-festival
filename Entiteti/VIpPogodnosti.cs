using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Muzicki_festival.Entiteti
{
    public class VIpPogodnosti
    {
        public virtual VipPogodnostiID ID { get; set; }
        public virtual int ID_ULAZNICE
        {
            get => ID.ID_ULAZNICE;
            set => ID.ID_ULAZNICE = value;
        }
        public virtual string POGODNOST
        {
            get => ID.POGODNOST;
            set => ID.POGODNOST = value;
        }
        // FK ka VIP
        public virtual Vip Vip { get; set; }

        public VIpPogodnosti()
        {
            ID = new VipPogodnostiID();
        }
    }
}
