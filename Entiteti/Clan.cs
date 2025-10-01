using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Muzicki_festival.Entiteti
{
    public class Clan
    {
        public virtual ClanID Id { get; set; }

        public virtual string IME
        {
            get => Id.IME;
            set => Id.IME = value;
        }

        public virtual string INSTRUMENT
        {
            get => Id.INSTRUMENT;
            set => Id.INSTRUMENT = value;
        }

        public virtual Bend BEND_ID
        {
            get => Id.BEND_ID;
            set => Id.BEND_ID = value;
        }

        public Clan()
        {
            Id = new ClanID();
        }
    }
}
