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
            if (estado =="N")
            {
                Adiciona();
            }
            if (estado=="E")
            {
                Editar();
            }
            llenaPersona("A");
            groupBox2.Enabled = false;
            Util.limpiar(groupBox2.Controls);
        }
        
        private void Adiciona()
        {
            try
            {
                PersonaDB  objC = new PersonaDB();
                int resp;
                llenaCliente(objC);
                resp = objC.InsertaPersona(objC.getPersona());
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

        private PersonaDB llenaCliente(PersonaDB lec)
        {
            lec.getPersona().cedper = mskcedula.Text.Trim();
            lec.getPersona().apeper = txtape.Text.Trim();
            lec.getPersona().nomper = txtnom.Text.Trim();
            lec.getPersona().dirper = txtdir.Text.Trim();
            lec.getPersona().telper = msktelf.Text.Trim();
            lec.getPersona().estper = "A";
            lec.getPersona().idrol = 0;
            return lec;
        }
        public void llenaPersona(string est)
        {
            try
            {
                dgvcli.Rows.Clear();
                PersonaDB objC = new PersonaDB();
                objC.getPersona().ListaPersonas = objC.TraePersonas(est);
                if (objC.getPersona().ListaPersonas.Count == 0)
                {
                    MessageBox.Show("No existen Clientes Ingresados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                        dgvcli.Rows[i].Cells[4].Value = objC.getPersona().ListaPersonas[i].estper;

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Al Presentar los Datos," + ex.Message, "Tienda", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Editar()
        {
            try
            {
                PersonaDB objC = new PersonaDB();
                int resp;
                llenaCliente(objC);
                resp = objC.ActualizaPersona(objC.getPersona());
                if (resp == 0)
                {
                    MessageBox.Show("No se modifico datos del Cliente", "Tienda", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Cliente Modificado", "Tienda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    estado = "";
                    llenaPersona("A");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Ingresar Datos," + ex.Message, "Tienda", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
         private void SF_Cliente_Load(object sender, EventArgs e)
         {
             llenaPersona("A");
         }

         private void btndesactiva_Click(object sender, EventArgs e)
         {
             desactivar();
         }

         private void desactivar()
         {
             try
             {
                 PersonaDB objB = new PersonaDB();
                 int resp;
                 string ced = dgvcli.Rows[fila].Cells[0].Value.ToString();
                 if (MessageBox.Show("Desea desactivar a: " + dgvcli.Rows[fila].Cells[1].Value.ToString(), "Tienda", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
                 {
                     resp = objB.DesactivarPersona(ced);
                     if (resp > 0)
                     {
                         MessageBox.Show("Cliente Desactivado", "Tienda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                         llenaPersona("A");
                     }
                     else
                     {
                         MessageBox.Show("No se Desactivo el Cliente", "Tienda", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                     }
                 }
             }
             catch (DBConcurrencyException ex)
             {
                 MessageBox.Show(ex.Message, "Tienda", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }
             catch (Exception ex)
             {
                 MessageBox.Show("Error al Presentar los Datos," + ex.Message, "Tienda", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                 llenaPersona("A");
                 btndesactiva.Visible = true;
                 btnactivar.Visible = false;
             }
             else
             {
                 llenaPersona("P");
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
                 PersonaDB objB = new PersonaDB();
                 int resp;
                 string ced = dgvcli.Rows[fila].Cells[0].Value.ToString();
                 if (MessageBox.Show("Desea activar a: " + dgvcli.Rows[fila].Cells[1].Value.ToString(), "Tienda", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
                 {
                     resp = objB.ActivarPersona(ced);
                     if (resp > 0)
                     {
                         MessageBox.Show("Cliente Activado", "Tienda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                         llenaPersona("P");
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
                 MessageBox.Show("Error al Presentar los Datos," + ex.Message, "Tienda", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }
         }

         private void button22_Click(object sender, EventArgs e)
         {
             groupBox2.Enabled = true;
             modificar();
         }
         private void modificar()
         {
             try
             {
                 PersonaDB objC = new PersonaDB();
                 objC.setPersona(objC.TraePersona(dgvcli.Rows[fila].Cells[0].Value.ToString()));
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
                     txtnom.Focus();
                   
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

         private void btnnuevo_Click(object sender, EventArgs e)
         {
             estado = "N";
             Util.limpiar(groupBox2.Controls);
             groupBox2.Enabled = true;
             mskcedula.Enabled = true;
             mskcedula.Focus();
         }
    }
}
