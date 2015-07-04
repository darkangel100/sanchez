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
            Util.limpiar(groupBox2.Controls);
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
            lec.getPersona().estper = "A";
            return lec;
        }
        public void llenaClientes(string est)
        {
            try
            {
                dgvcli.Rows.Clear();
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
                        dgvcli.Rows.Add(1);
                        dgvcli.Rows[i].Cells[0].Value = objC.getPersona().ListaPersonas[i].cedper;
                        dgvcli.Rows[i].Cells[1].Value = objC.getPersona().ListaPersonas[i].Nombre;
                        dgvcli.Rows[i].Cells[2].Value = objC.getPersona().ListaPersonas[i].dirper;
                        dgvcli.Rows[i].Cells[3].Value = objC.getPersona().ListaPersonas[i].telper;
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

         private void btndesactiva_Click(object sender, EventArgs e)
         {
             desactivar();
         }

         private void desactivar()
         {
             try
             {
                 ClienteDB objB = new ClienteDB();
                 int resp;
                 string ced = dgvcli.Rows[fila].Cells[0].Value.ToString();
                 if (MessageBox.Show("Desea desactivar a: " + dgvcli.Rows[fila].Cells[1].Value.ToString(), "Tienda", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
                 {
                     resp = objB.DesactivarCliente(ced);
                     if (resp > 0)
                     {
                         MessageBox.Show("Cliente Eliminado", "Tienda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                         llenaClientes("A");
                     }
                     else
                     {
                         MessageBox.Show("No se Elimino el Cliente", "Tienda", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                     }
                 }
             }
             catch (DBConcurrencyException ex)
             {
                 MessageBox.Show(ex.Message, "Tienda", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }
             catch (Exception ex)
             {
                 MessageBox.Show("Error al eliminar Datos," + ex.Message, "Tienda", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }
         }

         private void dgvcli_CellClick(object sender, DataGridViewCellEventArgs e)
         {
             fila = dgvcli.CurrentRow.Index;
         }

         private void chkeliminados_CheckedChanged(object sender, EventArgs e)
         {
             if (chkeliminados.Checked == false)
             {
                 llenaClientes("A");
                 btndesactiva.Visible = true;
                 btnactivar.Visible = false;
             }
             else
             {
                 llenaClientes("P");
                 btndesactiva.Visible = false;
                 btnactivar.Visible = true;
             }
         }

         private void btnactivar_Click(object sender, EventArgs e)
         {
             activar();
         }

         private void activar()
         {
             try
             {
                 ClienteDB objB = new ClienteDB();
                 int resp;
                 string ced = dgvcli.Rows[fila].Cells[0].Value.ToString();
                 if (MessageBox.Show("Desea activar a: " + dgvcli.Rows[fila].Cells[1].Value.ToString(), "Tienda", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
                 {
                     resp = objB.ActivarCliente(ced);
                     if (resp > 0)
                     {
                         MessageBox.Show("Cliente Activado", "Tienda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                         llenaClientes("P");
                     }
                     else
                     {
                         MessageBox.Show("No se Activo al Cliente", "Tienda", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                     }
                 }
             }
             catch (DBConcurrencyException ex)
             {
                 MessageBox.Show(ex.Message, "Tienda", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }
             catch (Exception ex)
             {
                 MessageBox.Show("Error al presentar los Datos," + ex.Message, "Tienda", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }
         }

         private void button22_Click(object sender, EventArgs e)
         {
             modificar();
         }
         private void modificar()
         {
             try
             {
                 ClienteDB objC = new ClienteDB();
                 objC.setPersona(objC.TraeCliente(dgvcli.Rows[fila].Cells[0].Value.ToString()));
                 if (objC.getPersona().cedper == "")
                 {
                     MessageBox.Show("No existe registro del Cliente", "Tienda", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                 }
                 else
                 {
                     mskcedula.Text = objC.getPersona().cedper;
                     txtape.Text = objC.getPersona().apeper;
                     txtnom.Text = objC.getPersona().nomper;
                     txtdir.Text = objC.getPersona().dirper;
                     msktelf.Text = objC.getPersona().telper;
                     mskcedula.Enabled = false;
                     estado = "E";
                     mskcedula.Focus();
                 }
             }
             catch (Exception ex)
             {
                 MessageBox.Show("Error al presentar los datos," + ex.Message, "Tienda", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }
         }

         private void button21_Click(object sender, EventArgs e)
         {
             Util.limpiar(groupBox2.Controls);
         }
    }
}
