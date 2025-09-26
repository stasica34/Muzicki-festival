using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Muzicki_festival.Entiteti
{
    public class VisednevnaDani
    {
        public virtual DateTime DAN_VAZENJA { get; set; }
        //fk sa Visednevna
        public virtual Visednevna Visednevna { get; set; }
        public override bool Equals(object obj)
        {
            var other = obj as VisednevnaDani;
            if (other == null) return false;

            return this.Visednevna.ID_ULAZNICE == other.Visednevna.ID_ULAZNICE &&
                   this.DAN_VAZENJA == other.DAN_VAZENJA;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + Visednevna.ID_ULAZNICE.GetHashCode();
                hash = hash * 23 + DAN_VAZENJA.GetHashCode();
                return hash;
            }
        }
    }
}
