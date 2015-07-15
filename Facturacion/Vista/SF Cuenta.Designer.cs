namespace Facturacion.Vista
{
    partial class SF_Cuenta
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
            this.btnmodificar = new System.Windows.Forms.Button();
            this.btndesactivar = new System.Windows.Forms.Button();
            this.btnactivar = new System.Windows.Forms.Button();
            this.dgvcuenta = new System.Windows.Forms.DataGridView();
            this.Column0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chkeliminados = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txttel = new System.Windows.Forms.TextBox();
            this.cborol = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtusu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mskcla = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtdir = new System.Windows.Forms.TextBox();
            this.txtape = new System.Windows.Forms.TextBox();
            this.mskced = new System.Windows.Forms.MaskedTextBox();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.txtnom = new System.Windows.Forms.TextBox();
            this.label35 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.btnnuevo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcuenta)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnmodificar
            // 
            this.btnmodificar.Location = new System.Drawing.Point(371, 539);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(75, 23);
            this.btnmodificar.TabIndex = 57;
            this.btnmodificar.Text = "Modificar";
            this.btnmodificar.UseVisualStyleBackColor = true;
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // btndesactivar
            // 
            this.btndesactivar.Location = new System.Drawing.Point(287, 539);
            this.btndesactivar.Name = "btndesactivar";
            this.btndesactivar.Size = new System.Drawing.Size(75, 23);
            this.btndesactivar.TabIndex = 56;
            this.btndesactivar.Text = "Desactivar";
            this.btndesactivar.UseVisualStyleBackColor = true;
            // 
            // btnactivar
            // 
            this.btnactivar.Location = new System.Drawing.Point(287, 539);
            this.btnactivar.Name = "btnactivar";
            this.btnactivar.Size = new System.Drawing.Size(75, 23);
            this.btnactivar.TabIndex = 55;
            this.btnactivar.Text = "Activar";
            this.btnactivar.UseVisualStyleBackColor = true;
            this.btnactivar.Visible = false;
            // 
            // dgvcuenta
            // 
            this.dgvcuenta.AllowUserToAddRows = false;
            this.dgvcuenta.AllowUserToDeleteRows = false;
            this.dgvcuenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcuenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column0,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvcuenta.Location = new System.Drawing.Point(12, 269);
            this.dgvcuenta.Name = "dgvcuenta";
            this.dgvcuenta.ReadOnly = true;
            this.dgvcuenta.Size = new System.Drawing.Size(555, 254);
            this.dgvcuenta.TabIndex = 54;
            this.dgvcuenta.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvcuenta_CellClick);
            // 
            // Column0
            // 
            this.Column0.HeaderText = "Cédula";
            this.Column0.Name = "Column0";
            this.Column0.ReadOnly = true;
            this.Column0.Width = 90;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Apellido y Nombre";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Dierección";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Teléfono";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 70;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Estado";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 50;
            // 
            // chkeliminados
            // 
            this.chkeliminados.AutoSize = true;
            this.chkeliminados.Location = new System.Drawing.Point(12, 246);
            this.chkeliminados.Name = "chkeliminados";
            this.chkeliminados.Size = new System.Drawing.Size(154, 17);
            this.chkeliminados.TabIndex = 58;
            this.chkeliminados.Text = "Mostrar cuentas eliminados";
            this.chkeliminados.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txttel);
            this.groupBox2.Controls.Add(this.cborol);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtusu);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.mskcla);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtdir);
            this.groupBox2.Controls.Add(this.txtape);
            this.groupBox2.Controls.Add(this.mskced);
            this.groupBox2.Controls.Add(this.btncancelar);
            this.groupBox2.Controls.Add(this.btnguardar);
            this.groupBox2.Controls.Add(this.label32);
            this.groupBox2.Controls.Add(this.label33);
            this.groupBox2.Controls.Add(this.label34);
            this.groupBox2.Controls.Add(this.txtnom);
            this.groupBox2.Controls.Add(this.label35);
            this.groupBox2.Controls.Add(this.label36);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(564, 216);
            this.groupBox2.TabIndex = 53;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Usuario";
            // 
            // txttel
            // 
            this.txttel.Location = new System.Drawing.Point(359, 71);
            this.txttel.Name = "txttel";
            this.txttel.Size = new System.Drawing.Size(100, 20);
            this.txttel.TabIndex = 5;
            // 
            // cborol
            // 
            this.cborol.FormattingEnabled = true;
            this.cborol.Location = new System.Drawing.Point(359, 150);
            this.cborol.Name = "cborol";
            this.cborol.Size = new System.Drawing.Size(121, 21);
            this.cborol.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(301, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "Rol";
            // 
            // txtusu
            // 
            this.txtusu.Location = new System.Drawing.Point(72, 155);
            this.txtusu.Name = "txtusu";
            this.txtusu.Size = new System.Drawing.Size(100, 20);
            this.txtusu.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Usuario";
            // 
            // mskcla
            // 
            this.mskcla.Location = new System.Drawing.Point(359, 112);
            this.mskcla.Name = "mskcla";
            this.mskcla.PasswordChar = '*';
            this.mskcla.Size = new System.Drawing.Size(100, 20);
            this.mskcla.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(301, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Clave";
            // 
            // txtdir
            // 
            this.txtdir.Location = new System.Drawing.Point(359, 30);
            this.txtdir.Name = "txtdir";
            this.txtdir.Size = new System.Drawing.Size(181, 20);
            this.txtdir.TabIndex = 4;
            // 
            // txtape
            // 
            this.txtape.Location = new System.Drawing.Point(72, 112);
            this.txtape.Name = "txtape";
            this.txtape.Size = new System.Drawing.Size(181, 20);
            this.txtape.TabIndex = 2;
            this.txtape.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtape_KeyPress);
            // 
            // mskced
            // 
            this.mskced.Location = new System.Drawing.Point(72, 30);
            this.mskced.Mask = "000000000-0";
            this.mskced.Name = "mskced";
            this.mskced.Size = new System.Drawing.Size(100, 20);
            this.mskced.TabIndex = 0;
            this.mskced.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mskced_KeyPress);
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(465, 187);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(75, 23);
            this.btncancelar.TabIndex = 27;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(384, 187);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(75, 23);
            this.btnguardar.TabIndex = 8;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(15, 33);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(40, 13);
            this.label32.TabIndex = 16;
            this.label32.Text = "Cedula";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(15, 74);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(44, 13);
            this.label33.TabIndex = 17;
            this.label33.Text = "Nombre";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(15, 115);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(44, 13);
            this.label34.TabIndex = 18;
            this.label34.Text = "Apellido";
            // 
            // txtnom
            // 
            this.txtnom.Location = new System.Drawing.Point(72, 71);
            this.txtnom.Name = "txtnom";
            this.txtnom.Size = new System.Drawing.Size(181, 20);
            this.txtnom.TabIndex = 1;
            this.txtnom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnom_KeyPress);
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(301, 74);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(49, 13);
            this.label35.TabIndex = 20;
            this.label35.Text = "Telefono";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(301, 33);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(52, 13);
            this.label36.TabIndex = 19;
            this.label36.Text = "Direccion";
            // 
            // btnnuevo
            // 
            this.btnnuevo.Location = new System.Drawing.Point(463, 539);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(75, 23);
            this.btnnuevo.TabIndex = 59;
            this.btnnuevo.Text = "Nuevo";
            this.btnnuevo.UseVisualStyleBackColor = true;
            this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click);
            // 
            // SF_Cuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 582);
            this.Controls.Add(this.btnnuevo);
            this.Controls.Add(this.chkeliminados);
            this.Controls.Add(this.btnmodificar);
            this.Controls.Add(this.btndesactivar);
            this.Controls.Add(this.btnactivar);
            this.Controls.Add(this.dgvcuenta);
            this.Controls.Add(this.groupBox2);
            this.Name = "SF_Cuenta";
            this.Text = "SF_Cuenta";
            this.Load += new System.EventHandler(this.SF_Cuenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvcuenta)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.Button btndesactivar;
        private System.Windows.Forms.Button btnactivar;
        private System.Windows.Forms.DataGridView dgvcuenta;
        private System.Windows.Forms.CheckBox chkeliminados;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MaskedTextBox mskcla;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtdir;
        private System.Windows.Forms.TextBox txtape;
        private System.Windows.Forms.MaskedTextBox mskced;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.TextBox txtnom;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.TextBox txtusu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cborol;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column0;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.TextBox txttel;
    }
}