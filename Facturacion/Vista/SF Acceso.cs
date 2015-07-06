using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Facturacion.Controlador;

namespace Facturacion.Vista
{
    public partial class SF_Acceso : Form
    {
        public SF_Acceso()
        {
            InitializeComponent();
        }

        private void btnacpertar_Click(object sender, EventArgs e)
        {
            SF_Principal sfprin = new SF_Principal();
            sfprin.ShowDialog();
            //verificar();
            
        }
        //private void verificar()
        //{
        //    try
        //    {
        //        CuentaDB objB = new CuentaDB();
        //        if (objB.getPersona().cedper.Equals(txtced.Text) && objB.getPersona().Cuenta.clacuent.Equals(txtclave.Text))
        //        {
        //           SF_Principal sfprin = new SF_Principal();
        //           sfprin.ShowDialog();
        //            this.Close();
        //        }
        //        else
        //        {
        //            MessageBox.Show("Cedula o Clave Incorrectas", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Error: " + ex.Message, "Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        //    }
        //}

        private void SF_Acceso_Load(object sender, EventArgs e)
        {
          
        }
      
    }
}
