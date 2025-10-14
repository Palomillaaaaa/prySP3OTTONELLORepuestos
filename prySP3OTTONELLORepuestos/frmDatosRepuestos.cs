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
            if (cmbMarcaRepuesto.Text == "")
            {
                cmbOrigenRepuesto.Enabled = false;
            }
            else
            {
                cmbOrigenRepuesto.Enabled = true;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (cmbMarcaRepuesto.Text == "")
            {
                MessageBox.Show("Seleccione un item válido");
            }
            else if (cmbOrigenRepuesto.Text == "")
            {
                MessageBox.Show("Seleccione un item válido");
            }
            else if (!mtbNumero.MaskFull)
            {
                MessageBox.Show("Complete el campo");
            }
            else if (mtbPrecio.Text == "")
            {
                MessageBox.Show("Complete el campo");
            }
        }

        private void tpgDatos_Click(object sender, EventArgs e)
        {

        }

        private void frmDatosRepuestos_Load(object sender, EventArgs e)
        {
            CargadorDatos();
            MessageBox.Show("Presione aceptar para ver datos cargados");

            List<string> origenes = new List<string>();
            List<string> listaMarcas = new List<string>();

            for (int filas = 0; filas < matRespuesto.GetLength(0); filas++)
            {
                dgvDatos.Rows.Add(matRespuesto[filas, 0],
                    matRespuesto[filas, 1],
                    matRespuesto[filas, 2],
                    matRespuesto[filas, 3],
                    matRespuesto[filas, 4]);
                if (!listaMarcas.Contains(matRespuesto[filas, 0]))
                {
                    listaMarcas.Add(matRespuesto[filas, 0]);
                }
                if (!origenes.Contains(matRespuesto[filas, 1]))
                {
                    listaMarcas.Add(matRespuesto[filas, 0]);
                }

            }
            //cboMarcaFiltro.DataSource = listaMarcas;
            //cmbOrigenFiltro.DataSource = origenes;

        }

        //Tengo que crear una funcion afuera del formulario para que funcione-
        public void CargadorDatos()
        {

        }

        private void cmbOrigenRepuesto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            cmbOrigenRepuesto.Text = ("");
            cmbMarcaRepuesto.Text = ("");
            mtbNumero.Text = string.Empty;  
            mtbPrecio.Text = string.Empty;

        }

        private void mtbNumero_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
