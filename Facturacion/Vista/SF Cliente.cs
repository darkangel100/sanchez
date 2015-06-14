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
    public partial class SF_Cliente : Form
    {
        public SF_Cliente()
        {
            InitializeComponent();
        }
        string estado = "";
        int fila = -1;
        private void button23_Click(object sender, EventArgs e)
        {
            Adiciona();
            llenaClientes("A");
        }
        private void Adiciona()
        {
            try
            {
                ClienteDB objC = new ClienteDB();
                int resp;
                llenaCliente(objC);
                resp = objC.InsertaCliente(objC.getPersona());
                if (resp == 0)
                {
                    MessageBox.Show("No se ingreso datos del Cliente", "Tienda", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Cliente Ingresado", "Tienda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    estado = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Ingresar Datos," + ex.Message, "Tienda", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
         private ClienteDB llenaCliente(ClienteDB lec)
        {
            lec.getPersona().cedper = mskcedula.Text.Trim();
            lec.getPersona().apeper = txtape.Text.Trim();
            lec.getPersona().nomper = txtnom.Text.Trim();
            lec.getPersona().dirper = txtdir.Text.Trim();
            lec.getPersona().telper = msktelf.Text.Trim();
            if(rba.Checked==true)
                lec.getPersona().estper = "A";
            else
                lec.getPersona().estper = "P";
            return lec;
        }
         public void llenaClientes(string est)
         {
             try
             {
                 dgcliente.Rows.Clear();
                 ClienteDB objC = new ClienteDB();
                 objC.getPersona().ListaPersonas = objC.TraeClientes(est);
                 if (objC.getPersona().ListaPersonas.Count == 0)
                 {
                     MessageBox.Show("No existen Clientes registrados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                 }
                 else
                 {
                     fila = 0;
                     for (int i = 0; i < objC.getPersona().ListaPersonas.Count; i++)
                     {
                         dgcliente.Rows.Add(1);
                         dgcliente.Rows[i].Cells[0].Value = objC.getPersona().ListaPersonas[i].cedper;
                         dgcliente.Rows[i].Cells[1].Value = objC.getPersona().ListaPersonas[i].nomper;
                         dgcliente.Rows[i].Cells[2].Value = objC.getPersona().ListaPersonas[i].apeper;
                         dgcliente.Rows[i].Cells[3].Value = objC.getPersona().ListaPersonas[i].dirper;
                         dgcliente.Rows[i].Cells[4].Value = objC.getPersona().ListaPersonas[i].telper;
                     }
                 }
             }
             catch (Exception ex)
             {
                 MessageBox.Show("Error Al Presentar los Datos," + ex.Message, "Tienda", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }
         }

         private void SF_Cliente_Load(object sender, EventArgs e)
         {
             llenaClientes("A");
         }
    }
}
