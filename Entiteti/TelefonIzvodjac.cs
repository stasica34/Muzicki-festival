using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Muzicki_festival.Entiteti
{
    public class TelefonIzvodjac
    {
        public virtual int IZVODJAC_ID { get; protected set; }

        public virtual string TELEFON { get; set; }
        public TelefonIzvodjac() { }
    }
}
