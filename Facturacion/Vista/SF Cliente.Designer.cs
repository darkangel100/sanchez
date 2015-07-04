namespace Facturacion.Vista
{
    partial class SF_Cliente
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.msktelf = new System.Windows.Forms.MaskedTextBox();
            this.mskcedula = new System.Windows.Forms.MaskedTextBox();
            this.txtdir = new System.Windows.Forms.TextBox();
            this.txtape = new System.Windows.Forms.TextBox();
            this.button21 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.txtnom = new System.Windows.Forms.TextBox();
            this.label35 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.button22 = new System.Windows.Forms.Button();
            this.dgvcli = new System.Windows.Forms.DataGridView();
            this.btndesactiva = new System.Windows.Forms.Button();
            this.chkeliminados = new System.Windows.Forms.CheckBox();
            this.btnactivar = new System.Windows.Forms.Button();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.Column0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcli)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.msktelf);
            this.groupBox2.Controls.Add(this.mskcedula);
            this.groupBox2.Controls.Add(this.txtdir);
            this.groupBox2.Controls.Add(this.txtape);
            this.groupBox2.Controls.Add(this.button21);
            this.groupBox2.Controls.Add(this.button23);
            this.groupBox2.Controls.Add(this.label32);
            this.groupBox2.Controls.Add(this.label33);
            this.groupBox2.Controls.Add(this.label34);
            this.groupBox2.Controls.Add(this.txtnom);
            this.groupBox2.Controls.Add(this.label35);
            this.groupBox2.Controls.Add(this.label36);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(12, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(545, 161);
            this.groupBox2.TabIndex = 51;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos Cliente";
            // 
            // msktelf
            // 
            this.msktelf.Location = new System.Drawing.Point(339, 59);
            this.msktelf.Name = "msktelf";
            this.msktelf.Size = new System.Drawing.Size(100, 20);
            this.msktelf.TabIndex = 4;
            // 
            // mskcedula
            // 
            this.mskcedula.Location = new System.Drawing.Point(91, 22);
            this.mskcedula.Name = "mskcedula";
            this.mskcedula.Size = new System.Drawing.Size(100, 20);
            this.mskcedula.TabIndex = 0;
            // 
            // txtdir
            // 
            this.txtdir.Location = new System.Drawing.Point(339, 18);
            this.txtdir.Name = "txtdir";
            this.txtdir.Size = new System.Drawing.Size(173, 20);
            this.txtdir.TabIndex = 3;
            // 
            // txtape
            // 
            this.txtape.Location = new System.Drawing.Point(91, 104);
            this.txtape.Name = "txtape";
            this.txtape.Size = new System.Drawing.Size(145, 20);
            this.txtape.TabIndex = 2;
            // 
            // button21
            // 
            this.button21.Location = new System.Drawing.Point(448, 131);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(75, 23);
            this.button21.TabIndex = 27;
            this.button21.Text = "Cancelar";
            this.button21.UseVisualStyleBackColor = true;
            this.button21.Click += new System.EventHandler(this.button21_Click);
            // 
            // button23
            // 
            this.button23.Location = new System.Drawing.Point(358, 131);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(75, 23);
            this.button23.TabIndex = 5;
            this.button23.Text = "Guardar";
            this.button23.UseVisualStyleBackColor = true;
            this.button23.Click += new System.EventHandler(this.button23_Click);
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(34, 25);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(40, 13);
            this.label32.TabIndex = 16;
            this.label32.Text = "Cedula";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(34, 66);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(44, 13);
            this.label33.TabIndex = 17;
            this.label33.Text = "Nombre";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(34, 107);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(44, 13);
            this.label34.TabIndex = 18;
            this.label34.Text = "Apellido";
            // 
            // txtnom
            // 
            this.txtnom.Location = new System.Drawing.Point(91, 63);
            this.txtnom.Name = "txtnom";
            this.txtnom.Size = new System.Drawing.Size(145, 20);
            this.txtnom.TabIndex = 1;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(281, 62);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(49, 13);
            this.label35.TabIndex = 20;
            this.label35.Text = "Telefono";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(281, 21);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(52, 13);
            this.label36.TabIndex = 19;
            this.label36.Text = "Direccion";
            // 
            // button22
            // 
            this.button22.Location = new System.Drawing.Point(412, 491);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(75, 23);
            this.button22.TabIndex = 46;
            this.button22.Text = "Modificar";
            this.button22.UseVisualStyleBackColor = true;
            this.button22.Click += new System.EventHandler(this.button22_Click);
            // 
            // dgvcli
            // 
            this.dgvcli.AllowUserToAddRows = false;
            this.dgvcli.AllowUserToDeleteRows = false;
            this.dgvcli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcli.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column0,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvcli.Location = new System.Drawing.Point(12, 231);
            this.dgvcli.Name = "dgvcli";
            this.dgvcli.ReadOnly = true;
            this.dgvcli.Size = new System.Drawing.Size(545, 254);
            this.dgvcli.TabIndex = 47;
            this.dgvcli.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvcli_CellClick);
            // 
            // btndesactiva
            // 
            this.btndesactiva.Location = new System.Drawing.Point(331, 491);
            this.btndesactiva.Name = "btndesactiva";
            this.btndesactiva.Size = new System.Drawing.Size(75, 23);
            this.btndesactiva.TabIndex = 52;
            this.btndesactiva.Text = "Desactivar";
            this.btndesactiva.UseVisualStyleBackColor = true;
            this.btndesactiva.Click += new System.EventHandler(this.btndesactiva_Click);
            // 
            // chkeliminados
            // 
            this.chkeliminados.AutoSize = true;
            this.chkeliminados.Location = new System.Drawing.Point(12, 208);
            this.chkeliminados.Name = "chkeliminados";
            this.chkeliminados.Size = new System.Drawing.Size(152, 17);
            this.chkeliminados.TabIndex = 53;
            this.chkeliminados.Text = "Mostrar clientes eliminados";
            this.chkeliminados.UseVisualStyleBackColor = true;
            this.chkeliminados.CheckedChanged += new System.EventHandler(this.chkeliminados_CheckedChanged);
            // 
            // btnactivar
            // 
            this.btnactivar.Location = new System.Drawing.Point(331, 491);
            this.btnactivar.Name = "btnactivar";
            this.btnactivar.Size = new System.Drawing.Size(75, 23);
            this.btnactivar.TabIndex = 54;
            this.btnactivar.Text = "Activar";
            this.btnactivar.UseVisualStyleBackColor = true;
            this.btnactivar.Visible = false;
            this.btnactivar.Click += new System.EventHandler(this.btnactivar_Click);
            // 
            // btnnuevo
            // 
            this.btnnuevo.Location = new System.Drawing.Point(250, 491);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(75, 23);
            this.btnnuevo.TabIndex = 55;
            this.btnnuevo.Text = "Nuevo";
            this.btnnuevo.UseVisualStyleBackColor = true;
            this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click);
            // 
            // Column0
            // 
            this.Column0.HeaderText = "Cedula";
            this.Column0.Name = "Column0";
            this.Column0.ReadOnly = true;
            this.Column0.Width = 90;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nombres y pellidos";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Direccion";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Telefono";
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
            // SF_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 533);
            this.Controls.Add(this.btnnuevo);
            this.Controls.Add(this.btnactivar);
            this.Controls.Add(this.chkeliminados);
            this.Controls.Add(this.btndesactiva);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button22);
            this.Controls.Add(this.dgvcli);
            this.Name = "SF_Cliente";
            this.Text = "SF_Cliente";
            this.Load += new System.EventHandler(this.SF_Cliente_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcli)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtdir;
        private System.Windows.Forms.TextBox txtape;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.TextBox txtnom;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.DataGridView dgvcli;
        private System.Windows.Forms.MaskedTextBox msktelf;
        private System.Windows.Forms.MaskedTextBox mskcedula;
        private System.Windows.Forms.Button btndesactiva;
        private System.Windows.Forms.CheckBox chkeliminados;
        private System.Windows.Forms.Button btnactivar;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column0;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;

    }
}