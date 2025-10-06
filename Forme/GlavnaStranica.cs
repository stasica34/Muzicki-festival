using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Muzicki_festival.Forme
{
    public partial class GlavnaStranica : Form
    {
        private Form parentForm;

        public GlavnaStranica(Form caller)
        {
            InitializeComponent();
            parentForm = caller;
        }
        private void GlavnaStranica_Load(object sender, EventArgs e)
        {
         
        }

        private void cmd_Izvodjac_Click(object sender, EventArgs e)
        {
            FormaIzvodjac formaIzvodjac = new FormaIzvodjac(this);
            formaIzvodjac.Show();
            this.Hide();
        }

        private void cmd_Dogadjaji_Click(object sender, EventArgs e)
        {
            FormaDogadjaji formaDogadjaji = new FormaDogadjaji(this);
            formaDogadjaji.Show();
            this.Hide();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
