using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prySP3OTTONELLORepuestos
{
    public partial class frmDatosRepuestos : Form
    {
        public frmDatosRepuestos()
        {
            InitializeComponent();
        }
        
        

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cmbMarcaRepuesto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbOrigenRepuesto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMarcaRepuesto.Text == "")
                    { }

        }
    }
}
