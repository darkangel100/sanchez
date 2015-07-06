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
    public partial class SF_Categoria : Form
    {
        string estado = "";
        int fila = -1;
        public SF_Categoria()
        {
            InitializeComponent();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            if (estado == "N")
            {
                Adiciona();
            }
            if (estado == "E")
            {
                Editar();
            }
            groupBox1.Enabled = true;
            llenaCat("A");
        }

        private void Adiciona()
        {
            try
            {
                CategoriaDB objC = new CategoriaDB();
                int resp;
                llenaCategoria(objC);
                resp = objC.InsertaCategoria(objC.getCategorias());
                if (resp == 0)
                {
                    MessageBox.Show("No se ingreso datos de la Categoria", "Tienda", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Categoria Ingresado", "Tienda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Ingresar Datos," + ex.Message, "Tienda", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private CategoriaDB llenaCategoria(CategoriaDB lcat)
        {
            lcat.getCategorias().idcat = txtcod.Text.Trim();
            lcat.getCategorias().nomcat = txtnom.Text.Trim();
            lcat.getCategorias().estcat = "A";          
            return lcat;
        }
      
        public void llenaCat(string est)
        {
            try
            {
                dgvcat.Rows.Clear();
                CategoriaDB objC = new CategoriaDB();
                objC.getCategorias().ListaCategorias = objC.TraeCategorias(est);
                if (objC.getCategorias().ListaCategorias.Count == 0)
                {
                    MessageBox.Show("No existen Categorias Ingresadas", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    fila = 0;
                    for (int i = 0; i < objC.getCategorias().ListaCategorias.Count; i++)
                    {
                        dgvcat.Rows.Add(1);
                        dgvcat.Rows[i].Cells[0].Value = objC.getCategorias().ListaCategorias[i].idcat;
                        dgvcat.Rows[i].Cells[1].Value = objC.getCategorias().ListaCategorias[i].nomcat;
                        dgvcat.Rows[i].Cells[2].Value = objC.getCategorias().ListaCategorias[i].estcat;
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
                CategoriaDB objC = new CategoriaDB();
                int resp;
                llenaCategoria(objC);
                resp = objC.ActualizaCategoria(objC.getCategorias());
                if (resp == 0)
                {
                    MessageBox.Show("No se ingreso datos de Categoria", "Tienda", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Categoria Modificada", "Tienda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    estado = "";
                    llenaCat("A");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Ingresar Datos," + ex.Message, "Tienda", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
        private void btndesactivar_Click(object sender, EventArgs e)
        {
            desactivar();
        }

        private void desactivar()
        {
            try
            {
                CategoriaDB objB = new CategoriaDB();
                int resp;
                string ced = dgvcat.Rows[fila].Cells[0].Value.ToString();
                if (MessageBox.Show("Desea desactivar a: " + dgvcat.Rows[fila].Cells[1].Value.ToString(), "Tienda", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
                {
                    resp = objB.DesactivarCategoria(ced);
                    if (resp > 0)
                    {
                        MessageBox.Show("Cliente Desactivado", "Tienda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        llenaCat("A");
                    }
                    else
                    {
                        MessageBox.Show("No se Desactivo la Categoria", "Tienda", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            txtcod.Enabled = false;
            modificar();
        }

        private void modificar()
        {
            try
            {
                CategoriaDB objC = new CategoriaDB();
                objC.setCategorias(objC.TraeCategoria(dgvcat.Rows[fila].Cells[0].Value.ToString()));
                if (objC.getCategorias().idcat.Equals(""))
                {
                    MessageBox.Show("No existe registro del Categoria", "Tienda", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    txtcod.Text = objC.getCategorias().idcat;
                    txtnom.Text = objC.getCategorias().nomcat;
                    txtcod.Enabled = false;
                    estado = "E";
                    txtnom.Focus();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al presentar los datos," + ex.Message, "Tienda", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       
        private void SF_Categoria_Load(object sender, EventArgs e)
        {
            llenaCat("A");
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            estado = "N";
            Util.limpiar(groupBox1.Controls);
            groupBox1.Enabled = true;
            txtnom.Enabled = true;
            txtnom.Focus();
            codigo();
        }
        private void codigo()
        {
            try
            {
                int nro;
                CategoriaDB obj = new CategoriaDB();
                nro = obj.TraeCodigo();
                txtcod.Text = (nro + 1).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message, "Tienda", MessageBoxButtons.OK);
            }
        }

     

        private void dgvcat_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            fila = dgvcat.CurrentRow.Index;
        }

        private void btnactivar_Click(object sender, EventArgs e)
        {
            activar();
        }



        private void activar()
        {
            try
            {
                CategoriaDB objB = new CategoriaDB();
                int resp;
                string cod = dgvcat.Rows[fila].Cells[0].Value.ToString();
                if (MessageBox.Show("Desea Activar a: " + dgvcat.Rows[fila].Cells[1].Value.ToString(), "Tienda", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
                {
                    resp = objB.ActivarCategoria(cod);
                    if (resp > 0)
                    {
                        MessageBox.Show("Categoria Activada", "Tienda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        llenaCat("P");
                    }
                    else
                    {
                        MessageBox.Show("No se Activo la Categoria", "Tienda", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void chkeliminados_CheckedChanged(object sender, EventArgs e)
        {
            if (chkeliminados.Checked == false)
            {
                llenaCat("A");
                btndesactivar.Visible = true;
                btnactivar.Visible = false;
            }
            else
            {
                llenaCat("P");
                btndesactivar.Visible = false;
                btnactivar.Visible = true;
            }
        }
      
       

        
 
    }
}
