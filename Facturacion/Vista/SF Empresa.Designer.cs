namespace Facturacion.Vista
{
    partial class SF_Empresa
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
            this.txtdir = new System.Windows.Forms.TextBox();
            this.button21 = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            this.label33 = new System.Windows.Forms.Label();
            this.txtnom = new System.Windows.Forms.TextBox();
            this.label35 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.btnactivar = new System.Windows.Forms.Button();
            this.btndesactiva = new System.Windows.Forms.Button();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.chkeliminados = new System.Windows.Forms.CheckBox();
            this.dgvempresa = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvempresa)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.msktelf);
            this.groupBox2.Controls.Add(this.txtdir);
            this.groupBox2.Controls.Add(this.button21);
            this.groupBox2.Controls.Add(this.btnguardar);
            this.groupBox2.Controls.Add(this.label33);
            this.groupBox2.Controls.Add(this.txtnom);
            this.groupBox2.Controls.Add(this.label35);
            this.groupBox2.Controls.Add(this.label36);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(443, 170);
            this.groupBox2.TabIndex = 52;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos Cliente";
            // 
            // msktelf
            // 
            this.msktelf.Location = new System.Drawing.Point(83, 112);
            this.msktelf.Name = "msktelf";
            this.msktelf.Size = new System.Drawing.Size(100, 20);
            this.msktelf.TabIndex = 4;
            // 
            // txtdir
            // 
            this.txtdir.Location = new System.Drawing.Point(83, 70);
            this.txtdir.Name = "txtdir";
            this.txtdir.Size = new System.Drawing.Size(173, 20);
            this.txtdir.TabIndex = 3;
            // 
            // button21
            // 
            this.button21.Location = new System.Drawing.Point(362, 115);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(75, 23);
            this.button21.TabIndex = 27;
            this.button21.Text = "Cancelar";
            this.button21.UseVisualStyleBackColor = true;
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(268, 115);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(75, 23);
            this.btnguardar.TabIndex = 5;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(26, 31);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(44, 13);
            this.label33.TabIndex = 17;
            this.label33.Text = "Nombre";
            // 
            // txtnom
            // 
            this.txtnom.Location = new System.Drawing.Point(83, 28);
            this.txtnom.Name = "txtnom";
            this.txtnom.Size = new System.Drawing.Size(145, 20);
            this.txtnom.TabIndex = 1;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(25, 115);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(49, 13);
            this.label35.TabIndex = 20;
            this.label35.Text = "Telefono";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(25, 73);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(52, 13);
            this.label36.TabIndex = 19;
            this.label36.Text = "Direccion";
            // 
            // btnnuevo
            // 
            this.btnnuevo.Location = new System.Drawing.Point(280, 484);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(75, 23);
            this.btnnuevo.TabIndex = 59;
            this.btnnuevo.Text = "Nuevo";
            this.btnnuevo.UseVisualStyleBackColor = true;
            this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click);
            // 
            // btnactivar
            // 
            this.btnactivar.Location = new System.Drawing.Point(361, 484);
            this.btnactivar.Name = "btnactivar";
            this.btnactivar.Size = new System.Drawing.Size(75, 23);
            this.btnactivar.TabIndex = 58;
            this.btnactivar.Text = "Activar";
            this.btnactivar.UseVisualStyleBackColor = true;
            this.btnactivar.Visible = false;
            this.btnactivar.Click += new System.EventHandler(this.btnactivar_Click);
            // 
            // btndesactiva
            // 
            this.btndesactiva.Location = new System.Drawing.Point(361, 484);
            this.btndesactiva.Name = "btndesactiva";
            this.btndesactiva.Size = new System.Drawing.Size(75, 23);
            this.btndesactiva.TabIndex = 57;
            this.btndesactiva.Text = "Desactivar";
            this.btndesactiva.UseVisualStyleBackColor = true;
            this.btndesactiva.Click += new System.EventHandler(this.btndesactiva_Click);
            // 
            // btnmodificar
            // 
            this.btnmodificar.Location = new System.Drawing.Point(442, 484);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(75, 23);
            this.btnmodificar.TabIndex = 56;
            this.btnmodificar.Text = "Modificar";
            this.btnmodificar.UseVisualStyleBackColor = true;
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // chkeliminados
            // 
            this.chkeliminados.AutoSize = true;
            this.chkeliminados.Location = new System.Drawing.Point(12, 188);
            this.chkeliminados.Name = "chkeliminados";
            this.chkeliminados.Size = new System.Drawing.Size(152, 17);
            this.chkeliminados.TabIndex = 60;
            this.chkeliminados.Text = "Mostrar clientes eliminados";
            this.chkeliminados.UseVisualStyleBackColor = true;
            this.chkeliminados.CheckedChanged += new System.EventHandler(this.chkeliminados_CheckedChanged);
            // 
            // dgvempresa
            // 
            this.dgvempresa.AllowUserToAddRows = false;
            this.dgvempresa.AllowUserToDeleteRows = false;
            this.dgvempresa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvempresa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvempresa.Location = new System.Drawing.Point(12, 230);
            this.dgvempresa.Name = "dgvempresa";
            this.dgvempresa.ReadOnly = true;
            this.dgvempresa.Size = new System.Drawing.Size(443, 150);
            this.dgvempresa.TabIndex = 61;
            this.dgvempresa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvempresa_CellClick_1);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nombre";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Diresccion";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Telf";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Estado";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "idEmpresa";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // SF_Empresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 519);
            this.Controls.Add(this.dgvempresa);
            this.Controls.Add(this.chkeliminados);
            this.Controls.Add(this.btnnuevo);
            this.Controls.Add(this.btnactivar);
            this.Controls.Add(this.btndesactiva);
            this.Controls.Add(this.btnmodificar);
            this.Controls.Add(this.groupBox2);
            this.Name = "SF_Empresa";
            this.Text = "SF_Empresa";
            this.Load += new System.EventHandler(this.SF_Empresa_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvempresa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MaskedTextBox msktelf;
        private System.Windows.Forms.TextBox txtdir;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.TextBox txtnom;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.Button btnactivar;
        private System.Windows.Forms.Button btndesactiva;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.CheckBox chkeliminados;
        private System.Windows.Forms.DataGridView dgvempresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}