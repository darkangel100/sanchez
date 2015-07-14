namespace Facturacion.Vista
{
    partial class SF_Acceso
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
            this.btnsalir = new System.Windows.Forms.Button();
            this.btnacpertar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtusu = new System.Windows.Forms.TextBox();
            this.txtclave = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(151, 113);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(93, 25);
            this.btnsalir.TabIndex = 16;
            this.btnsalir.Text = "&Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            // 
            // btnacpertar
            // 
            this.btnacpertar.Location = new System.Drawing.Point(34, 113);
            this.btnacpertar.Name = "btnacpertar";
            this.btnacpertar.Size = new System.Drawing.Size(93, 25);
            this.btnacpertar.TabIndex = 1;
            this.btnacpertar.Text = "&Aceptar";
            this.btnacpertar.UseVisualStyleBackColor = true;
            this.btnacpertar.Click += new System.EventHandler(this.btnacpertar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Clave";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Usuario";
            // 
            // txtusu
            // 
            this.txtusu.Location = new System.Drawing.Point(81, 12);
            this.txtusu.MaxLength = 10;
            this.txtusu.Name = "txtusu";
            this.txtusu.Size = new System.Drawing.Size(149, 20);
            this.txtusu.TabIndex = 12;
            this.txtusu.Text = "jorg";
            // 
            // txtclave
            // 
            this.txtclave.Location = new System.Drawing.Point(81, 62);
            this.txtclave.MaxLength = 6;
            this.txtclave.Name = "txtclave";
            this.txtclave.PasswordChar = '*';
            this.txtclave.Size = new System.Drawing.Size(148, 20);
            this.txtclave.TabIndex = 14;
            this.txtclave.Text = "123";
            // 
            // SF_Acceso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 154);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btnacpertar);
            this.Controls.Add(this.txtclave);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtusu);
            this.Controls.Add(this.label3);
            this.Name = "SF_Acceso";
            this.Text = "SF_Acceso";
            this.Load += new System.EventHandler(this.SF_Acceso_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Button btnacpertar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtusu;
        private System.Windows.Forms.TextBox txtclave;
    }
}