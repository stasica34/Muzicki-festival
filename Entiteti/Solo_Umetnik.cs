using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;
using Muzicki_festival.Entiteti;

namespace Muzicki_festival.Entiteti
{
    public class Solo_Umetnik
    {
        public virtual int ID { get; protected set; }
        public virtual string SVIRA_INSTRUMENT { get; set; }
        public virtual string TIP_INSTRUMENTA { get; set; }
        public Solo_Umetnik()
        {
        }
    }
}
