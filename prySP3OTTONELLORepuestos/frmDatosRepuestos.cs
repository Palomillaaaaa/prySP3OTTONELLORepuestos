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
        //Declaracion de variables globales

        int NumeroRepuesto;
        string[] VecMarcaRepuesto = new string[100];
        string[] VecOrigenRepuesto;
        string[] DescripcionRepuesto;
        string[] PrecioRepuesto;



        private void InicializarFormulario()
        {
            //Seleccion del combo box de la marca del repuesto
            cmbMarcaRepuesto.Items.Add("(P)Peugeot");
            cmbMarcaRepuesto.Items.Add("(F)Fiat");
            cmbMarcaRepuesto.Items.Add("(R)Renault");

            //Seleccion del combo box del origen del repuesto
            cmbOrigenRepuesto.Items.Add("(N) Nacional");
            cmbOrigenRepuesto.Items.Add("(I) Importado");

            rtbDescripcion.Text = "";
            mtbNumero.Text = "";
            mtbPrecio.Text = "";

            btnGuardar.Enabled = false;


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



        }

        private void cmbMarcaRepuesto_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
        // private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)

        // Permite que solo los números se escriban en el TextBox
        //if (!char.IsNumber(e.KeyChar) && e.KeyChar != (char) Keys.Back)
        //{

        //    e.Handled = true; // Cancela la pulsación de la tecla si no es un número o la tecla Backspace
        //}
        private void rtbDescripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void mtbNumero_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (mtbNumero.Text == "")
            {
                MessageBox.Show("Debe ingresar un número de repuesto válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mtbNumero.Focus();
            }
        }

        private void frmDatosRepuestos_Load(object sender, EventArgs e)
        {


        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (mtbPrecio.Text == "")
            {
                MessageBox.Show("Debe ingresar un precio válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mtbPrecio.Focus();
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void cmbOrigenRepuesto_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void gpbDatos_Enter(object sender, EventArgs e)
        {

        }

        private void lblMarcadelRepuesto_Click(object sender, EventArgs e)
        {

        }
    }
}

