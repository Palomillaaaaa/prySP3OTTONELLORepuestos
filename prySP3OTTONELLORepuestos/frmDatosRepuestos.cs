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

        string[,] matRespuesto = new string[4, 5];

        int indiceGrabar = 0;
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            matRespuesto[indiceGrabar, 0] = "marca";
            matRespuesto[indiceGrabar, 1] = "origen";
            matRespuesto[indiceGrabar, 2] = "numero";
            matRespuesto[indiceGrabar, 3] = "precio";
            matRespuesto[indiceGrabar, 4] = "descripcion";

            indiceGrabar++;

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

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }

        private void tpgDatos_Click(object sender, EventArgs e)
        {

        }

        private void frmDatosRepuestos_Load(object sender, EventArgs e)
        {
            CargadorDatos();
            MessageBox

        }

        //Tengo que crear una funcion afuera del formulario para que funcione-
        public void CargadorDatos()
        {

        }
    }
}
