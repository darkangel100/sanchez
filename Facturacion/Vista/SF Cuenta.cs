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
    public partial class SF_Cuenta : Form
    {
        public SF_Cuenta()
        {
            InitializeComponent();
        }
        string estado = "";
        int fila = -1;
        private void button23_Click(object sender, EventArgs e)
        {
            Adiciona();
            llenaCuenta("A");
        }

        private void SF_Cuenta_Load(object sender, EventArgs e)
        {
            llenaCuenta("A");
        }
        private void Adiciona()
        {
            try
            {
                CuentaDB objB = new CuentaDB();
                int resp;
                llenapersona(objB);
                resp = objB.InsertaCuenta(objB.getPersona());
                if (resp == 0)
                {
                    MessageBox.Show("No se ingreso datos de la cuenta", "Tienda", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Cuenta Ingresado", "Tienda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    estado = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Ingresar Datos," + ex.Message, "Tienda", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private CuentaDB llenapersona(CuentaDB cue)
        {
            cue.getPersona().cedper = mskced.Text.Trim();
            cue.getPersona().apeper = txtape.Text.Trim();
            cue.getPersona().nomper = txtnom.Text.Trim();
            cue.getPersona().dirper = txtdir.Text.Trim();
            cue.getPersona().telper = msktelf.Text.Trim();
            cue.getPersona().Cuenta.clacuent = mskcla.Text.Trim();
            if (rba.Checked == true)
                cue.getPersona().estper = "A";
            else
                cue.getPersona().estper = "P";
            cue.getPersona().Cuenta.clacuent = mskcla.Text.Trim();
            if ( rdbadmin.Checked == true)
                cue.getPersona().Cuenta.tipcue = "A";
            else
                cue.getPersona().Cuenta.tipcue = "B";

            return cue;
        }
        public void llenaCuenta(string est)
        {
            try
            {
                CuentaDB objL = new CuentaDB();
                objL.getPersona().ListaPersonas = objL.Traepersonas(est);
                if (objL.getPersona().ListaPersonas.Count == 0)
                {
                    MessageBox.Show("No existen Cuentas  Registradas", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                fila = 0;
                for (int i = 0; i < objL.getPersona().ListaPersonas.Count; i++)
                {
                    dgcuenta.Rows.Add(1);
                    dgcuenta.Rows[i].Cells[0].Value = objL.getPersona().ListaPersonas[i].cedper;
                    dgcuenta.Rows[i].Cells[1].Value = objL.getPersona().ListaPersonas[i].nomper;
                    dgcuenta.Rows[i].Cells[2].Value = objL.getPersona().ListaPersonas[i].apeper;
                    dgcuenta.Rows[i].Cells[3].Value = objL.getPersona().ListaPersonas[i].dirper;
                    dgcuenta.Rows[i].Cells[4].Value = objL.getPersona().ListaPersonas[i].telper;
                    dgcuenta.Rows[i].Cells[5].Value = objL.getPersona().ListaPersonas[i].estper;
                    i++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Al Presentar los Datos," + ex.Message, "Tienda", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       

       
    }
}
