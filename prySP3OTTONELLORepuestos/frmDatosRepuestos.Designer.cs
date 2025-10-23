namespace prySP3OTTONELLORepuestos
{
    partial class frmDatosRepuestos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gpbDatos = new GroupBox();
            txtDescripcion = new TextBox();
            txtCodigo = new TextBox();
            btnLimpiar = new Button();
            btnGuardar = new Button();
            mtbPrecio = new MaskedTextBox();
            lblPrecio = new Label();
            lblDescripcion = new Label();
            lblCódigoRepuesto = new Label();
            cmbOrigenRepuesto = new ComboBox();
            lblOrigenRepuesto = new Label();
            cmbMarcaRepuesto = new ComboBox();
            lblMarcadelRepuesto = new Label();
            tbcDatos = new TabControl();
            tpgDatos = new TabPage();
            Datos = new TabPage();
            cmbMarcaFiltro = new ComboBox();
            cmbOrigenFiltro = new ComboBox();
            dgvDatos = new DataGridView();
            colMarca = new DataGridViewTextBoxColumn();
            ColOrigen = new DataGridViewTextBoxColumn();
            colNumero = new DataGridViewTextBoxColumn();
            colPrecio = new DataGridViewTextBoxColumn();
            coldescripcion = new DataGridViewTextBoxColumn();
            lblMostrarOrigen = new Label();
            lblMostrarMarca = new Label();
            gpbDatos.SuspendLayout();
            tbcDatos.SuspendLayout();
            tpgDatos.SuspendLayout();
            Datos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            SuspendLayout();
            // 
            // gpbDatos
            // 
            gpbDatos.Controls.Add(txtDescripcion);
            gpbDatos.Controls.Add(txtCodigo);
            gpbDatos.Controls.Add(btnLimpiar);
            gpbDatos.Controls.Add(btnGuardar);
            gpbDatos.Controls.Add(mtbPrecio);
            gpbDatos.Controls.Add(lblPrecio);
            gpbDatos.Controls.Add(lblDescripcion);
            gpbDatos.Controls.Add(lblCódigoRepuesto);
            gpbDatos.Controls.Add(cmbOrigenRepuesto);
            gpbDatos.Controls.Add(lblOrigenRepuesto);
            gpbDatos.Controls.Add(cmbMarcaRepuesto);
            gpbDatos.Controls.Add(lblMarcadelRepuesto);
            gpbDatos.FlatStyle = FlatStyle.Popup;
            gpbDatos.Location = new Point(27, 38);
            gpbDatos.Margin = new Padding(4, 5, 4, 5);
            gpbDatos.Name = "gpbDatos";
            gpbDatos.Padding = new Padding(4, 5, 4, 5);
            gpbDatos.Size = new Size(725, 323);
            gpbDatos.TabIndex = 0;
            gpbDatos.TabStop = false;
            gpbDatos.Text = "Datos del Repuesto";
            gpbDatos.Enter += groupBox1_Enter;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(23, 207);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(277, 31);
            txtDescripcion.TabIndex = 4;
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(409, 79);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(108, 31);
            txtCodigo.TabIndex = 2;
            txtCodigo.TextChanged += txtCodigo_TextChanged;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(442, 234);
            btnLimpiar.Margin = new Padding(4, 5, 4, 5);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(124, 44);
            btnLimpiar.TabIndex = 6;
            btnLimpiar.Text = "Limpiar ";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(574, 234);
            btnGuardar.Margin = new Padding(4, 5, 4, 5);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(124, 44);
            btnGuardar.TabIndex = 5;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // mtbPrecio
            // 
            mtbPrecio.Location = new Point(590, 77);
            mtbPrecio.Margin = new Padding(4, 5, 4, 5);
            mtbPrecio.Mask = "999.999";
            mtbPrecio.Name = "mtbPrecio";
            mtbPrecio.Size = new Size(108, 31);
            mtbPrecio.TabIndex = 3;
            mtbPrecio.MaskInputRejected += mtbPrecio_MaskInputRejected;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(590, 47);
            lblPrecio.Margin = new Padding(4, 0, 4, 0);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(60, 25);
            lblPrecio.TabIndex = 7;
            lblPrecio.Text = "Precio";
            lblPrecio.Click += label2_Click;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(23, 155);
            lblDescripcion.Margin = new Padding(4, 0, 4, 0);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(104, 25);
            lblDescripcion.TabIndex = 5;
            lblDescripcion.Text = "Descripción";
            // 
            // lblCódigoRepuesto
            // 
            lblCódigoRepuesto.AutoSize = true;
            lblCódigoRepuesto.Location = new Point(409, 47);
            lblCódigoRepuesto.Margin = new Padding(4, 0, 4, 0);
            lblCódigoRepuesto.Name = "lblCódigoRepuesto";
            lblCódigoRepuesto.Size = new Size(71, 25);
            lblCódigoRepuesto.TabIndex = 4;
            lblCódigoRepuesto.Text = "Código";
            // 
            // cmbOrigenRepuesto
            // 
            cmbOrigenRepuesto.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbOrigenRepuesto.FormattingEnabled = true;
            cmbOrigenRepuesto.Location = new Point(221, 77);
            cmbOrigenRepuesto.Margin = new Padding(4, 5, 4, 5);
            cmbOrigenRepuesto.Name = "cmbOrigenRepuesto";
            cmbOrigenRepuesto.Size = new Size(120, 33);
            cmbOrigenRepuesto.TabIndex = 1;
            cmbOrigenRepuesto.SelectedIndexChanged += cmbOrigenRepuesto_SelectedIndexChanged;
            // 
            // lblOrigenRepuesto
            // 
            lblOrigenRepuesto.AutoSize = true;
            lblOrigenRepuesto.Location = new Point(221, 47);
            lblOrigenRepuesto.Margin = new Padding(4, 0, 4, 0);
            lblOrigenRepuesto.Name = "lblOrigenRepuesto";
            lblOrigenRepuesto.Size = new Size(71, 25);
            lblOrigenRepuesto.TabIndex = 3;
            lblOrigenRepuesto.Text = "Origen ";
            lblOrigenRepuesto.Click += label1_Click;
            // 
            // cmbMarcaRepuesto
            // 
            cmbMarcaRepuesto.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMarcaRepuesto.FormattingEnabled = true;
            cmbMarcaRepuesto.Location = new Point(23, 77);
            cmbMarcaRepuesto.Margin = new Padding(4, 5, 4, 5);
            cmbMarcaRepuesto.Name = "cmbMarcaRepuesto";
            cmbMarcaRepuesto.Size = new Size(120, 33);
            cmbMarcaRepuesto.TabIndex = 0;
            cmbMarcaRepuesto.SelectedIndexChanged += cmbMarcaRepuesto_SelectedIndexChanged;
            // 
            // lblMarcadelRepuesto
            // 
            lblMarcadelRepuesto.AutoSize = true;
            lblMarcadelRepuesto.Location = new Point(23, 47);
            lblMarcadelRepuesto.Margin = new Padding(4, 0, 4, 0);
            lblMarcadelRepuesto.Name = "lblMarcadelRepuesto";
            lblMarcadelRepuesto.Size = new Size(65, 25);
            lblMarcadelRepuesto.TabIndex = 0;
            lblMarcadelRepuesto.Text = "Marca ";
            // 
            // tbcDatos
            // 
            tbcDatos.Controls.Add(tpgDatos);
            tbcDatos.Controls.Add(Datos);
            tbcDatos.Location = new Point(59, 67);
            tbcDatos.Margin = new Padding(4, 5, 4, 5);
            tbcDatos.Name = "tbcDatos";
            tbcDatos.SelectedIndex = 0;
            tbcDatos.Size = new Size(881, 612);
            tbcDatos.TabIndex = 1;
            // 
            // tpgDatos
            // 
            tpgDatos.Controls.Add(gpbDatos);
            tpgDatos.Location = new Point(4, 34);
            tpgDatos.Margin = new Padding(4, 5, 4, 5);
            tpgDatos.Name = "tpgDatos";
            tpgDatos.Padding = new Padding(4, 5, 4, 5);
            tpgDatos.Size = new Size(873, 574);
            tpgDatos.TabIndex = 0;
            tpgDatos.Text = "Información";
            tpgDatos.UseVisualStyleBackColor = true;
            tpgDatos.Click += tpgDatos_Click;
            // 
            // Datos
            // 
            Datos.Controls.Add(lblMostrarMarca);
            Datos.Controls.Add(lblMostrarOrigen);
            Datos.Controls.Add(cmbMarcaFiltro);
            Datos.Controls.Add(cmbOrigenFiltro);
            Datos.Controls.Add(dgvDatos);
            Datos.Location = new Point(4, 34);
            Datos.Margin = new Padding(4, 5, 4, 5);
            Datos.Name = "Datos";
            Datos.Padding = new Padding(4, 5, 4, 5);
            Datos.Size = new Size(873, 574);
            Datos.TabIndex = 1;
            Datos.Text = "Mostrar";
            Datos.UseVisualStyleBackColor = true;
            // 
            // cmbMarcaFiltro
            // 
            cmbMarcaFiltro.FormattingEnabled = true;
            cmbMarcaFiltro.Location = new Point(21, 78);
            cmbMarcaFiltro.Name = "cmbMarcaFiltro";
            cmbMarcaFiltro.Size = new Size(182, 33);
            cmbMarcaFiltro.TabIndex = 2;
            // 
            // cmbOrigenFiltro
            // 
            cmbOrigenFiltro.FormattingEnabled = true;
            cmbOrigenFiltro.Location = new Point(233, 78);
            cmbOrigenFiltro.Name = "cmbOrigenFiltro";
            cmbOrigenFiltro.Size = new Size(182, 33);
            cmbOrigenFiltro.TabIndex = 1;
            // 
            // dgvDatos
            // 
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatos.Columns.AddRange(new DataGridViewColumn[] { colMarca, ColOrigen, colNumero, colPrecio, coldescripcion });
            dgvDatos.Location = new Point(21, 142);
            dgvDatos.Margin = new Padding(4, 5, 4, 5);
            dgvDatos.Name = "dgvDatos";
            dgvDatos.RowHeadersWidth = 62;
            dgvDatos.Size = new Size(804, 365);
            dgvDatos.TabIndex = 0;
            // 
            // colMarca
            // 
            colMarca.HeaderText = "Marca";
            colMarca.MinimumWidth = 8;
            colMarca.Name = "colMarca";
            colMarca.Width = 150;
            // 
            // ColOrigen
            // 
            ColOrigen.HeaderText = "Origen";
            ColOrigen.MinimumWidth = 8;
            ColOrigen.Name = "ColOrigen";
            ColOrigen.Width = 150;
            // 
            // colNumero
            // 
            colNumero.HeaderText = "Numero";
            colNumero.MinimumWidth = 8;
            colNumero.Name = "colNumero";
            colNumero.Width = 150;
            // 
            // colPrecio
            // 
            colPrecio.HeaderText = "Precio";
            colPrecio.MinimumWidth = 8;
            colPrecio.Name = "colPrecio";
            colPrecio.Width = 150;
            // 
            // coldescripcion
            // 
            coldescripcion.HeaderText = "Descripcion";
            coldescripcion.MinimumWidth = 8;
            coldescripcion.Name = "coldescripcion";
            coldescripcion.Width = 150;
            // 
            // lblMostrarOrigen
            // 
            lblMostrarOrigen.AutoSize = true;
            lblMostrarOrigen.Location = new Point(233, 40);
            lblMostrarOrigen.Name = "lblMostrarOrigen";
            lblMostrarOrigen.Size = new Size(66, 25);
            lblMostrarOrigen.TabIndex = 3;
            lblMostrarOrigen.Text = "Origen";
            // 
            // lblMostrarMarca
            // 
            lblMostrarMarca.AutoSize = true;
            lblMostrarMarca.Location = new Point(21, 40);
            lblMostrarMarca.Name = "lblMostrarMarca";
            lblMostrarMarca.Size = new Size(60, 25);
            lblMostrarMarca.TabIndex = 4;
            lblMostrarMarca.Text = "Marca";
            // 
            // frmDatosRepuestos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1379, 1050);
            Controls.Add(tbcDatos);
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmDatosRepuestos";
            Text = "frmDatosRepuestos";
            Load += frmDatosRepuestos_Load;
            gpbDatos.ResumeLayout(false);
            gpbDatos.PerformLayout();
            tbcDatos.ResumeLayout(false);
            tpgDatos.ResumeLayout(false);
            Datos.ResumeLayout(false);
            Datos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gpbDatos;
        private Label lblMarcadelRepuesto;
        private ComboBox cmbMarcaRepuesto;
        private ComboBox cmbOrigenRepuesto;
        private Label lblOrigenRepuesto;
        private Label lblCódigoRepuesto;
        private Label lblPrecio;
        private Label lblDescripcion;
        private Button btnGuardar;
        private MaskedTextBox mtbPrecio;
        private TabControl tbcDatos;
        private TabPage tpgDatos;
        private TabPage Datos;
        private DataGridView dgvDatos;
        private DataGridViewTextBoxColumn colMarca;
        private DataGridViewTextBoxColumn ColOrigen;
        private DataGridViewTextBoxColumn colNumero;
        private DataGridViewTextBoxColumn colPrecio;
        private DataGridViewTextBoxColumn coldescripcion;
        private Button btnLimpiar;
        private TextBox txtCodigo;
        private TextBox txtDescripcion;
        private ComboBox cmbOrigenFiltro;
        private ComboBox cmbMarcaFiltro;
        private Label lblMostrarOrigen;
        private Label lblMostrarMarca;
    }
}