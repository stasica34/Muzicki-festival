using Muzicki_festival.Entiteti;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NHibernate;

namespace Muzicki_festival.FormeDodatne
{
    public partial class FormaUlazniceIzmeni : Form
    {
        private Ulaznica ulaznicaIzmeni;
        private Form parentform;
        public FormaUlazniceIzmeni(Form caller, Ulaznica ulaznica)
        {
            InitializeComponent();
            parentform = caller;
            this.ulaznicaIzmeni = ulaznica;
        }
        private void btnOtkazi_Click(object sender, EventArgs e)
        {
            parentform.Show();
            this.Close();
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
           
        }

        private void FormaUlazniceIzmeni_Load(object sender, EventArgs e)
        {

        }
    }
}
