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

        struct DatosRepuestos
        {
            public string Marca;
            public string Origen;
            public string Precio;
            public string Codigo;
            public string IDRepuesto;
            public string Descripcion;
        }

        DatosRepuestos[] VecRepuestos = new DatosRepuestos[100];
        int indiceGrabar = 0;
        bool cargar = false;
        //Porque el bool? no lo entiendo

        string[,] matRespuesto = new string[4, 5];


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
            else if (txtCodigo.Text == " ")
            {
                MessageBox.Show("Complete el campo");
            }
            else if (mtbPrecio.Text == "")
            {
                MessageBox.Show("Complete el campo");
            }

            cargar = true;
            recorrer = 0;

            while (recorrer <= indice && cargar == true)
            {
                if (vecRepuesto[recorrer].IDRepuesto == mtbCodigo.MaskFull)
                {
                    MessageBox.Show("Ya se encuentra el Id dentro de los datos");

                    cargar = false;
                }
                else
                {
                    recorrer++;
                }

                if (cargar)
                {
                    VecRepuestos[indice].Marca = cmbMarcaRepuesto.Text;
                    VecRepuestos[indice].Origen = cmbOrigenRepuesto.Text;
                    VecRepuestos[indice].IDRepuesto = txtCodigo.Text;
                    VecRepuestos[indice].Precio = mtbPrecio.Text;
                    VecRepuestos[indice].Descripcion = rtbDescripcion;
                    
                    indice ++
                    cmbOrigenRepuesto.SelectedIndex = -1;
                    cmbMarcaRepuesto.SelectedIndex = -1;
                    txtCodigo.Text = string.Empty;
                    mtbPrecio.Text = string.Empty;
                    rtbDescripcion.Text = string.Empty;
                    cmbMarcaRepuesto.Focus();



                }
            }


        private void tpgDatos_Click(object sender, EventArgs e)
        {

        }

        private void frmDatosRepuestos_Load(object sender, EventArgs e)
        {
            cmbMarcaRepuesto.Items.Add("P (Peugeot)");
            cmbMarcaRepuesto.Items.Add("F (Fiat)");
            cmbMarcaRepuesto.Items.Add("R (Renault)");
            cmbOrigenRepuesto.Items.Add("N (Nacional)");
            cmbOrigenRepuesto.Items.Add("I (Internacional)");

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
            cmbOrigenRepuesto.SelectedIndex = -1;
            cmbMarcaRepuesto.SelectedIndex = -1;
            txtCodigo.Text = string.Empty;
            mtbPrecio.Text = string.Empty;
            rtbDescripcion.Text = string.Empty;
            cmbMarcaRepuesto.Focus();

        }

        private void mtbNumero_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void rtbDescripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void mtbPrecio_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
