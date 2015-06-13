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
        
        
        //private void btnguardacatg_Click(object sender, EventArgs e)
        //{
        //    if (estado == "N")
        //    {
        //        Adiciona();
        //    }
        //    if (estado == "E")
        //    {
        //        Editar();
        //    }
          
        //    rbn_actcateg.Checked = false;
        //    rbn_pasvcateg.Checked = false;
        //    llenaCategorias("A");
        
        //}
        private void Adiciona()
        {
            try
            {
                categoriaBD objC = new categoriaBD();
                int resp;
                llenacategoria(objC);
                resp = objC.InsertaCategoria(objC.getCategoria());
                if (resp == 0)
                {
                    MessageBox.Show("No se ingresó datos de La Categoria", "facturacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Cliente Ingresado", "facturacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Ingresar Datos," + ex.Message, "facturacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private categoriaBD llenacategoria(categoriaBD categ)
        {
            categ.getCategoria().nomcat = txtnomcat.Text.Trim();
           
            if (rbn_actcateg.Checked == true)
            {
                categ.getCategoria().estcat = "Activo";
            }
            else
            {
                categ.getCategoria().estcat = "Pacivo";
            }
            return categ;
        }
       
        public void llenaCategorias()
        {
            try
            {
                dataGridView1.Rows.Clear();
                categoriaBD objB = new categoriaBD();
                objB.getCategoria().ListaCategorias = objB.TraeCategorias();
                if (objB.getCategoria().ListaCategorias.Count == 0)
                {
                    MessageBox.Show("No existen Categoria Registrados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    fila = 0;
                    for (int i = 0; i < objB.getCategoria().ListaCategorias.Count; i++)
                    {
                        dataGridView1.Rows.Add(1);
                        dataGridView1.Rows[i].Cells[0].Value = objB.getCategoria().ListaCategorias[i].nomcat;
                        dataGridView1.Rows[i].Cells[1].Value = objB.getCategoria().ListaCategorias[i].estcat;
                        
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Presentar los Datos, " + ex.Message, "facturacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void SF_Categoria_Load(object sender, EventArgs e)
        {
            llenaCategorias();
        }
        private void Editar()
        {
            try
            {
                categoriaBD objC = new categoriaBD();
                int resp;
                objC.getCategoria().nomcat = txtnomcat.Text;
                llenacategoria(objC);
                resp = objC.ActualizaCategoria(objC.getCategoria());
                if (resp == 0)
                {
                    MessageBox.Show("No se modificó datos de la  Categoria", "facturacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Categoria Modificado", "facturacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    estado = "";
                    llenaCategorias();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Ingresar Datos," + ex.Message, "facturacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Adiciona();
            llenaCategorias();
        }

        private void SF_Categoria_Load_1(object sender, EventArgs e)
        {
            llenaCategorias();
        }

        
    }
}
