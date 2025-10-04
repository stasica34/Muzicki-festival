using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Muzicki_festival.Entiteti
{
    public class VipPogodnostiID
    {
        public virtual int ID_ULAZNICE { get;set; }
        public virtual string POGODNOST { get; set; }
        public override bool Equals(object obj)
        {
            var other = obj as VipPogodnostiID;
            if(other == null) return false;
            return ID_ULAZNICE == other.ID_ULAZNICE &&
                   POGODNOST == other.POGODNOST;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
