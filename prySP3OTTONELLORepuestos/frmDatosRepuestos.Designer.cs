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
            rtbDescripcion = new RichTextBox();
            btnGuardar = new Button();
            maskedTextBox2 = new MaskedTextBox();
            lblPrecio = new Label();
            label1 = new Label();
            mtbNumero = new MaskedTextBox();
            lblNumeroRepuesto = new Label();
            cmbOrigenRepuesto = new ComboBox();
            lblOrigenRepuesto = new Label();
            cmbMarcaRepuesto = new ComboBox();
            lblMarcadelRepuesto = new Label();
            gpbDatos.SuspendLayout();
            SuspendLayout();
            // 
            // gpbDatos
            // 
            gpbDatos.Controls.Add(rtbDescripcion);
            gpbDatos.Controls.Add(btnGuardar);
            gpbDatos.Controls.Add(maskedTextBox2);
            gpbDatos.Controls.Add(lblPrecio);
            gpbDatos.Controls.Add(label1);
            gpbDatos.Controls.Add(mtbNumero);
            gpbDatos.Controls.Add(lblNumeroRepuesto);
            gpbDatos.Controls.Add(cmbOrigenRepuesto);
            gpbDatos.Controls.Add(lblOrigenRepuesto);
            gpbDatos.Controls.Add(cmbMarcaRepuesto);
            gpbDatos.Controls.Add(lblMarcadelRepuesto);
            gpbDatos.FlatStyle = FlatStyle.Popup;
            gpbDatos.Location = new Point(12, 12);
            gpbDatos.Name = "gpbDatos";
            gpbDatos.Size = new Size(540, 246);
            gpbDatos.TabIndex = 0;
            gpbDatos.TabStop = false;
            gpbDatos.Text = "Datos del Repuesto";
            gpbDatos.Enter += groupBox1_Enter;
            // 
            // rtbDescripcion
            // 
            rtbDescripcion.Location = new Point(16, 111);
            rtbDescripcion.MaxLength = 50;
            rtbDescripcion.Name = "rtbDescripcion";
            rtbDescripcion.Size = new Size(355, 97);
            rtbDescripcion.TabIndex = 1;
            rtbDescripcion.Text = "";
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
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(413, 46);
            maskedTextBox2.Mask = "999.999";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(85, 23);
            maskedTextBox2.TabIndex = 8;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(413, 28);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(40, 15);
            lblPrecio.TabIndex = 7;
            lblPrecio.Text = "Precio";
            lblPrecio.Click += label2_Click;
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
            cmbOrigenRepuesto.Enabled = false;
            cmbOrigenRepuesto.FormattingEnabled = true;
            cmbOrigenRepuesto.Items.AddRange(new object[] { "N", "I" });
            cmbOrigenRepuesto.Location = new Point(155, 46);
            cmbOrigenRepuesto.Name = "cmbOrigenRepuesto";
            cmbOrigenRepuesto.Size = new Size(85, 23);
            cmbOrigenRepuesto.TabIndex = 2;
            cmbOrigenRepuesto.SelectedIndexChanged += cmbOrigenRepuesto_SelectedIndexChanged;
            // 
            // lblOrigenRepuesto
            // 
            lblOrigenRepuesto.AutoSize = true;
            lblOrigenRepuesto.Location = new Point(155, 28);
            lblOrigenRepuesto.Name = "lblOrigenRepuesto";
            lblOrigenRepuesto.Size = new Size(46, 15);
            lblOrigenRepuesto.TabIndex = 3;
            lblOrigenRepuesto.Text = "Origen ";
            lblOrigenRepuesto.Click += label1_Click;
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
            cmbMarcaRepuesto.SelectedIndexChanged += cmbMarcaRepuesto_SelectedIndexChanged;
            // 
            // lblMarcadelRepuesto
            // 
            lblMarcadelRepuesto.AutoSize = true;
            lblMarcadelRepuesto.Location = new Point(16, 28);
            lblMarcadelRepuesto.Name = "lblMarcadelRepuesto";
            lblMarcadelRepuesto.Size = new Size(43, 15);
            lblMarcadelRepuesto.TabIndex = 1;
            lblMarcadelRepuesto.Text = "Marca ";
            // 
            // frmDatosRepuestos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(837, 467);
            Controls.Add(gpbDatos);
            Name = "frmDatosRepuestos";
            Text = "frmDatosRepuestos";
            gpbDatos.ResumeLayout(false);
            gpbDatos.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gpbDatos;
        private Label lblMarcadelRepuesto;
        private ComboBox cmbMarcaRepuesto;
        private ComboBox cmbOrigenRepuesto;
        private Label lblOrigenRepuesto;
        private Label lblNumeroRepuesto;
        private MaskedTextBox mtbNumero;
        private Label lblPrecio;
        private Label label1;
        private Button btnGuardar;
        private MaskedTextBox maskedTextBox2;
        private RichTextBox rtbDescripcion;
    }
}