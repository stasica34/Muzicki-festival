using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Muzicki_festival.DTOs
{
    public class AgencijaOrganizatorView
    {
        public int Id;
        public string Naziv;
        public string Adresa;

        public AgencijaOrganizatorView(int id, string naziv, string adresa)
        {
            Id = id;
            Naziv = naziv;
            Adresa = adresa;
        }

        public override string ToString()
        {
            return Naziv;
        }
    }

    public class AgencijaOrganizatorBasic
    {
        public int Id;
        public string Naziv;
        public string Adresa;
        public List<PosetilacBasic> Posetioci;

        public AgencijaOrganizatorBasic(int id, string naziv, string adresa, List<PosetilacBasic> posetioci)
        {
            Id = id;
            Naziv = naziv;
            Adresa = adresa;
            Posetioci = posetioci;
        }
    }
}
