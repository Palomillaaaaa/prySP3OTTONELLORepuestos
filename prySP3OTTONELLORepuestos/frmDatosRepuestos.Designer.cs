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
            tbcCargar = new TabControl();
            tabPage1 = new TabPage();
            gpbDatos = new GroupBox();
            rtbDescripcion = new RichTextBox();
            btnGuardar = new Button();
            mtbPrecio = new MaskedTextBox();
            lblPrecio = new Label();
            label1 = new Label();
            mtbNumero = new MaskedTextBox();
            lblNumeroRepuesto = new Label();
            cmbOrigenRepuesto = new ComboBox();
            lblOrigenRepuesto = new Label();
            cmbMarcaRepuesto = new ComboBox();
            lblMarcadelRepuesto = new Label();
            tabPage2 = new TabPage();
            tbcCargar.SuspendLayout();
            tabPage1.SuspendLayout();
            gpbDatos.SuspendLayout();
            SuspendLayout();
            // 
            // tbcCargar
            // 
            tbcCargar.Controls.Add(tabPage1);
            tbcCargar.Controls.Add(tabPage2);
            tbcCargar.Location = new Point(28, 73);
            tbcCargar.Name = "tbcCargar";
            tbcCargar.SelectedIndex = 0;
            tbcCargar.Size = new Size(650, 330);
            tbcCargar.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(gpbDatos);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(642, 302);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Cargar";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click;
            // 
            // gpbDatos
            // 
            gpbDatos.Controls.Add(rtbDescripcion);
            gpbDatos.Controls.Add(btnGuardar);
            gpbDatos.Controls.Add(mtbPrecio);
            gpbDatos.Controls.Add(lblPrecio);
            gpbDatos.Controls.Add(label1);
            gpbDatos.Controls.Add(mtbNumero);
            gpbDatos.Controls.Add(lblNumeroRepuesto);
            gpbDatos.Controls.Add(cmbOrigenRepuesto);
            gpbDatos.Controls.Add(lblOrigenRepuesto);
            gpbDatos.Controls.Add(cmbMarcaRepuesto);
            gpbDatos.Controls.Add(lblMarcadelRepuesto);
            gpbDatos.FlatStyle = FlatStyle.Popup;
            gpbDatos.Location = new Point(51, 28);
            gpbDatos.Name = "gpbDatos";
            gpbDatos.Size = new Size(540, 246);
            gpbDatos.TabIndex = 1;
            gpbDatos.TabStop = false;
            gpbDatos.Text = "Datos del Repuesto";
            gpbDatos.Enter += gpbDatos_Enter;
            // 
            // rtbDescripcion
            // 
            rtbDescripcion.Location = new Point(16, 111);
            rtbDescripcion.MaxLength = 50;
            rtbDescripcion.Name = "rtbDescripcion";
            rtbDescripcion.Size = new Size(355, 97);
            rtbDescripcion.TabIndex = 1;
            rtbDescripcion.Text = "";
            rtbDescripcion.TextChanged += rtbDescripcion_TextChanged;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(396, 172);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(117, 36);
            btnGuardar.TabIndex = 1;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // mtbPrecio
            // 
            mtbPrecio.Location = new Point(413, 46);
            mtbPrecio.Mask = "999.999";
            mtbPrecio.Name = "mtbPrecio";
            mtbPrecio.Size = new Size(85, 23);
            mtbPrecio.TabIndex = 8;
            mtbPrecio.MaskInputRejected += maskedTextBox2_MaskInputRejected;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(413, 28);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(40, 15);
            lblPrecio.TabIndex = 7;
            lblPrecio.Text = "Precio";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 93);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 5;
            label1.Text = "Descripción";
            // 
            // mtbNumero
            // 
            mtbNumero.Location = new Point(286, 46);
            mtbNumero.Mask = "999999";
            mtbNumero.Name = "mtbNumero";
            mtbNumero.Size = new Size(85, 23);
            mtbNumero.TabIndex = 1;
            mtbNumero.MaskInputRejected += mtbNumero_MaskInputRejected;
            // 
            // lblNumeroRepuesto
            // 
            lblNumeroRepuesto.AutoSize = true;
            lblNumeroRepuesto.Location = new Point(286, 28);
            lblNumeroRepuesto.Name = "lblNumeroRepuesto";
            lblNumeroRepuesto.Size = new Size(51, 15);
            lblNumeroRepuesto.TabIndex = 4;
            lblNumeroRepuesto.Text = "Número";
            // 
            // cmbOrigenRepuesto
            // 
            cmbOrigenRepuesto.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbOrigenRepuesto.Enabled = false;
            cmbOrigenRepuesto.FormattingEnabled = true;
            cmbOrigenRepuesto.Items.AddRange(new object[] { "N", "I" });
            cmbOrigenRepuesto.Location = new Point(155, 46);
            cmbOrigenRepuesto.Name = "cmbOrigenRepuesto";
            cmbOrigenRepuesto.Size = new Size(85, 23);
            cmbOrigenRepuesto.TabIndex = 2;
            cmbOrigenRepuesto.SelectedIndexChanged += cmbOrigenRepuesto_SelectedIndexChanged_1;
            // 
            // lblOrigenRepuesto
            // 
            lblOrigenRepuesto.AutoSize = true;
            lblOrigenRepuesto.Location = new Point(155, 28);
            lblOrigenRepuesto.Name = "lblOrigenRepuesto";
            lblOrigenRepuesto.Size = new Size(46, 15);
            lblOrigenRepuesto.TabIndex = 3;
            lblOrigenRepuesto.Text = "Origen ";
            // 
            // cmbMarcaRepuesto
            // 
            cmbMarcaRepuesto.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMarcaRepuesto.Enabled = false;
            cmbMarcaRepuesto.FormattingEnabled = true;
            cmbMarcaRepuesto.Items.AddRange(new object[] { "P", "F", "R" });
            cmbMarcaRepuesto.Location = new Point(16, 46);
            cmbMarcaRepuesto.Name = "cmbMarcaRepuesto";
            cmbMarcaRepuesto.Size = new Size(85, 23);
            cmbMarcaRepuesto.TabIndex = 1;
            cmbMarcaRepuesto.SelectedIndexChanged += cmbMarcaRepuesto_SelectedIndexChanged_1;
            // 
            // lblMarcadelRepuesto
            // 
            lblMarcadelRepuesto.AutoSize = true;
            lblMarcadelRepuesto.Location = new Point(16, 28);
            lblMarcadelRepuesto.Name = "lblMarcadelRepuesto";
            lblMarcadelRepuesto.Size = new Size(43, 15);
            lblMarcadelRepuesto.TabIndex = 1;
            lblMarcadelRepuesto.Text = "Marca ";
            lblMarcadelRepuesto.Click += lblMarcadelRepuesto_Click;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(642, 302);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Mostrar";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // frmDatosRepuestos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(837, 605);
            Controls.Add(tbcCargar);
            Name = "frmDatosRepuestos";
            Text = "frmDatosRepuestos";
            Load += frmDatosRepuestos_Load;
            tbcCargar.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            gpbDatos.ResumeLayout(false);
            gpbDatos.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tbcCargar;
        private TabPage tabPage1;
        private GroupBox gpbDatos;
        private RichTextBox rtbDescripcion;
        private Button btnGuardar;
        private MaskedTextBox mtbPrecio;
        private Label lblPrecio;
        private Label label1;
        private MaskedTextBox mtbNumero;
        private Label lblNumeroRepuesto;
        private ComboBox cmbOrigenRepuesto;
        private Label lblOrigenRepuesto;
        private ComboBox cmbMarcaRepuesto;
        private Label lblMarcadelRepuesto;
        private TabPage tabPage2;
    }
}