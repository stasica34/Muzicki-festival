using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Muzicki_festival.Entiteti
{
    public class Posetilac
    {
        public virtual int ID { get; protected set; }
        public virtual string IME { get; set; }
        public virtual string PREZIME { get; set; }
        public virtual string EMAIL { get; set; }

        //povezivanje 1:n veze sa ulaznicama
        //interface list - pri pokazivanju liste ulaznica
        //jer nhibarnate ne koristi obicne liste, nego iliste, pri pokretanju, kreira ilist
        //jer on prevodi u interfejs, na osnovu interfejsa kreira svoju listu
        //korise se interfejsi koji se mapiraju u listu
        public virtual IList<Ulaznica> Ulaznice { get; set; }
        //veza n:m
        public virtual IList<JeClan> JeClan { get; set; } 
        public Posetilac()
        {
            //inicijalizacija liste ulaznica
            Ulaznice = new List<Ulaznica>();
            JeClan  = new List<JeClan>();
        }
        public override string ToString()
        {
            return IME + " " + PREZIME;
        }
    }
}
