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
            this.txtclave_Acc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtced_Acc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbnom_Acc = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(153, 198);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(93, 25);
            this.btnsalir.TabIndex = 16;
            this.btnsalir.Text = "&Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            // 
            // btnacpertar
            // 
            this.btnacpertar.Location = new System.Drawing.Point(36, 198);
            this.btnacpertar.Name = "btnacpertar";
            this.btnacpertar.Size = new System.Drawing.Size(93, 25);
            this.btnacpertar.TabIndex = 15;
            this.btnacpertar.Text = "&Aceptar";
            this.btnacpertar.UseVisualStyleBackColor = true;
            this.btnacpertar.Click += new System.EventHandler(this.btnacpertar_Click);
            // 
            // txtclave_Acc
            // 
            this.txtclave_Acc.Location = new System.Drawing.Point(81, 143);
            this.txtclave_Acc.MaxLength = 6;
            this.txtclave_Acc.Name = "txtclave_Acc";
            this.txtclave_Acc.PasswordChar = '*';
            this.txtclave_Acc.Size = new System.Drawing.Size(148, 20);
            this.txtclave_Acc.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Clave";
            // 
            // txtced_Acc
            // 
            this.txtced_Acc.Location = new System.Drawing.Point(81, 93);
            this.txtced_Acc.MaxLength = 10;
            this.txtced_Acc.Name = "txtced_Acc";
            this.txtced_Acc.Size = new System.Drawing.Size(149, 20);
            this.txtced_Acc.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Cédula";
            // 
            // cbnom_Acc
            // 
            this.cbnom_Acc.FormattingEnabled = true;
            this.cbnom_Acc.Location = new System.Drawing.Point(81, 40);
            this.cbnom_Acc.Name = "cbnom_Acc";
            this.cbnom_Acc.Size = new System.Drawing.Size(182, 21);
            this.cbnom_Acc.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nombre";
            // 
            // SF_Acceso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 237);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btnacpertar);
            this.Controls.Add(this.txtclave_Acc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtced_Acc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbnom_Acc);
            this.Controls.Add(this.label1);
            this.Name = "SF_Acceso";
            this.Text = "SF_Acceso";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Button btnacpertar;
        private System.Windows.Forms.TextBox txtclave_Acc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtced_Acc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbnom_Acc;
        private System.Windows.Forms.Label label1;
    }
}