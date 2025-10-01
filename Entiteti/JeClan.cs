using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Muzicki_festival.Entiteti
{
    public class JeClan
    {
        public virtual int ID { get; protected set; }
        // FK: veza ka entitetu Posetilac
        public virtual Posetilac Posetilac { get; set; }

        // FK: veza ka entitetu Grupa
        public virtual Grupa Grupa { get; set; }
        public JeClan() { }
    }
}
