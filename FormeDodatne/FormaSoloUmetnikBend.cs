using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Muzicki_festival.FormeDodatne
{
    public partial class FormaSoloUmetnikBend : Form
    {
        private Form parentForm;
        public FormaSoloUmetnikBend(Form parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
        }
    }
}
