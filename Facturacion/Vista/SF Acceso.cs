using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Facturacion.Controlador;
using Facturacion.Vista;

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
            //SF_Principal prin = new SF_Principal();
            //prin.ShowDialog();
            //this.Close();
            verificar();
        }
        private void verificar()
        {
            if (txtusu.Text.Trim().Length > 0 && txtclave.Text.Trim().Length > 0)
            {
                try
                {
                    CuentaDB objB = new CuentaDB();
                    objB.setCuenta(objB.TraeContra(txtusu.Text));

                    if (objB.getCuenta().nomcuen.Equals(txtusu.Text) && objB.getCuenta().Clave.Equals(txtclave.Text))
                    {
                        SF_Principal prin = new SF_Principal();
                        prin.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Cedula o Clave Incorrectas", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Contraseña o Usuario Incorrecta " + ex.Message, "Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txtusu.Focus();
                }
            }
            else
            {
                MessageBox.Show("Deve ingresar Llenar los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtusu.Focus();
            }
        }

        private void SF_Acceso_Load(object sender, EventArgs e)
        {
            ////lblFecha.Text = DateTime.Now.ToLongDateString();
            ////lblHora.Text = DateTime.Now.ToLongTimeString();
            CuentaDB objC = new CuentaDB();
            int numeroC = objC.cuentaE();
            if (numeroC == 0)
            {
                SF_Administrador usu = new SF_Administrador();
                usu.Show();
            }
        }
      
    }
}
