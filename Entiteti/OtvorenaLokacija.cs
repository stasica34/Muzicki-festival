using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Muzicki_festival.Entiteti
{
    public class OtvorenaLokacija
    {
        public virtual string GPS_KOORDINATE { get; set; }
        public virtual string NAZIV { get; set; }
        public OtvorenaLokacija() { }
    }
}
