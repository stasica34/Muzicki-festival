using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Muzicki_festival.Entiteti
{
    public class VisednevnaDani
    {
        public virtual VisednevnaDaniID ID { get; set; }

        public virtual int ID_ULAZNICE
        {
            get => ID.ID_ULAZNICE;
            set => ID.ID_ULAZNICE = value;
        }

        public virtual DateTime DAN_VAZENJA
        {
            get => ID.DAN_VAZENJA;
            set => ID.DAN_VAZENJA = value;
        }

        // FK ka Visednevna
        public virtual Visednevna Visednevna { get; set; }

        public VisednevnaDani()
        {
            ID = new VisednevnaDaniID();
        }
    }
}
