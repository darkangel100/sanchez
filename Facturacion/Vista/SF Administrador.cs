using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Facturacion.Modelo;
using Facturacion.Controlador;

namespace Facturacion.Vista
{
    public partial class SF_Administrador : Form
    {
        public SF_Administrador()
        {
            InitializeComponent();
        }

        private void btnGuarda_Click(object sender, EventArgs e)
        {
            Adiciona();
            Close();
        }

        private void SF_Administrador_Load(object sender, EventArgs e)
        {
            RolDB objR = new RolDB();
            objR.crearNuevosRoles();
        }
        private void Adiciona()
        {
            try
            {
                int resp;
                int resp2;
                PersonaDB objU = new PersonaDB();
                CuentaDB objC = new CuentaDB();
                llenapersona(objU);
                llenaCuenta(objC);
                resp = objU.InsertaPersona(objU.getPersona());
                resp2 = objC.llenacuenta(objC.getCuenta());
                if (resp == 0 || resp2 == 0)
                {
                    MessageBox.Show("No se ingreso datos de Usuario", "Ventas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (resp == 1 && resp2 == 1)
                {
                    MessageBox.Show("Usuario Ingresado", "Ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Ingresar Datos," + ex.Message, "Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private PersonaDB llenapersona(PersonaDB lad)
        {
            lad.getPersona().cedper = txtced.Text.Trim();
            lad.getPersona().nomper = txtnom.Text.Trim();
            lad.getPersona().apeper = txtape.Text.Trim();
            lad.getPersona().dirper = txtdir.Text.Trim();
            lad.getPersona().telper = txttel.Text.Trim();
            lad.getPersona().idrol = 2;
            lad.getPersona().estper = "A";
            return lad;
        }
        private CuentaDB llenaCuenta(CuentaDB lcu)
        {
            lcu.getCuenta().nomcuen = txtusuario.Text.Trim();
            lcu.getCuenta().Clave = txtcla.Text.Trim();
            lcu.getCuenta().idperCuen = 1;
            lcu.getCuenta().estcuen = "A";
            return lcu;
        }
    }
}
