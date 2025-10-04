using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Muzicki_festival.Entiteti
{
    public class VisednevnaDaniID
    {
        public virtual int ID_ULAZNICE { get; set; }
        public virtual DateTime DAN_VAZENJA { get; set; }

        public override bool Equals(object obj)
        {
            var other = obj as VisednevnaDaniID;
            if (other == null) return false;

            return ID_ULAZNICE == other.ID_ULAZNICE &&
                   DAN_VAZENJA == other.DAN_VAZENJA;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
