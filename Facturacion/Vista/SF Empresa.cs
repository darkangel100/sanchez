using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Facturacion.Controlador;
using Facturacion.Modelo;

namespace Facturacion.Vista
{
    public partial class SF_Empresa : Form
    {
        public SF_Empresa()
        {
            InitializeComponent();
        }
        string estado = "";
        int fila = -1;

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            estado = "N";
            Util.limpiar(groupBox2.Controls);
            groupBox2.Enabled = true;
            txtnom.Enabled = true;
            txtnom.Focus();
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
            llenaEmpresas();
        }

        private void Adiciona()
        {
            try
            {
                EmpresaDB objE = new EmpresaDB();
                int resp;
                llenaEmpresa(objE);
                resp = objE.InsertaEmpresa(objE.getEmpresa());
                if (resp == 0)
                {
                    MessageBox.Show("No se ingreso datos de la Empresa", "Tienda", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Empresa Ingresada", "Tienda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    estado = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Ingresar Datos," + ex.Message, "Tienda", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void Editar()
        {
            try
            {
                EmpresaDB objE = new EmpresaDB();
                int resp;
                llenaEmpresa(objE);
                resp = objE.ActualizaEmpresa(objE.getEmpresa());
                if (resp == 0)
                {
                    MessageBox.Show("No se modifico datos del Cliente", "Tienda", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Empresa Modificada", "Tienda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    estado = "";
                    llenaEmpresas();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Ingresar Datos," + ex.Message, "Tienda", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void llenaEmpresas()
        {
            try
            {
                dgvempresa.Rows.Clear();
                EmpresaDB objE = new EmpresaDB();
                objE.getEmpresa().ListaEmpresas = objE.TraeEmpresas();
                if (objE.getEmpresa().ListaEmpresas.Count == 0)
                {
                    MessageBox.Show("No existen Empresas Registradas", "Chino_Koreano", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    fila = 0;
                    for (int i = 0; i < objE.getEmpresa().ListaEmpresas.Count; i++)
                    {
                        dgvempresa.Rows.Add(1);
                        dgvempresa.Rows[i].Cells[0].Value = objE.getEmpresa().ListaEmpresas[i].nomemp;
                        dgvempresa.Rows[i].Cells[1].Value = objE.getEmpresa().ListaEmpresas[i].diremp;
                        dgvempresa.Rows[i].Cells[2].Value = objE.getEmpresa().ListaEmpresas[i].telemp;
                        dgvempresa.Rows[i].Cells[3].Value = objE.getEmpresa().ListaEmpresas[i].estemp;

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Al Presentar los Datos," + ex.Message, "Tienda", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private EmpresaDB llenaEmpresa(EmpresaDB emp)
        {
            emp.getEmpresa().nomemp = txtnom.Text.Trim();
            emp.getEmpresa().diremp = txtdir.Text.Trim();
            emp.getEmpresa().telemp = msktelf.Text.Trim();
            emp.getEmpresa().estemp = "A";
            return emp;
           
        }
        private void SF_Empresa_Load(object sender, EventArgs e)
        {
            llenaEmpresas();        
        }

     

        private void btnactivar_Click(object sender, EventArgs e)
        {
            //activar();
        }
        //private void activar()
        //{
        //    try
        //    {
        //        EmpresaDB objB = new EmpresaDB();
        //        int resp;
        //        string ruc = dgvempresa.Rows[fila].Cells[0].Value.ToString();
        //        if (MessageBox.Show("Desea activar a: " + dgvempresa.Rows[fila].Cells[1].Value.ToString(), "Tienda", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
        //        {
        //            resp = objB.ActivarEmpresa(ruc);
        //            if (resp > 0)
        //            {
        //                MessageBox.Show("Empresa Activada", "Tienda", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //                llenaEmpresa("P");
        //            }
        //            else
        //            {
        //                MessageBox.Show("No se Activo la Empresa", "Tienda", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //            }
        //        }
        //    }
        //    catch (DBConcurrencyException ex)
        //    {
        //        MessageBox.Show(ex.Message, "Tienda", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Error al Presentar los Datos," + ex.Message, "Tienda", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        private void btndesactiva_Click(object sender, EventArgs e)
        {
            //desactivar();
        }
        //private void desactivar()
        //{
        //    try
        //    {
        //        EmpresaDB objB = new EmpresaDB();
        //        int resp;
        //        string ruc = dgvempresa.Rows[fila].Cells[0].Value.ToString();
        //        if (MessageBox.Show("Desea activar a: " + dgvempresa.Rows[fila].Cells[1].Value.ToString(), "Tienda", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
        //        {
        //            resp = objB.DesactivarEmpresa(ruc);
        //            if (resp > 0)
        //            {
        //                MessageBox.Show("Empresa Desactivada", "Tienda", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //                llenaEmpresa("A");
        //            }
        //            else
        //            {
        //                MessageBox.Show("No se Desactivo la Empresa", "Tienda", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //            }
        //        }
        //    }
        //    catch (DBConcurrencyException ex)
        //    {
        //        MessageBox.Show(ex.Message, "Tienda", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Error al Presentar los Datos," + ex.Message, "Tienda", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        private void chkeliminados_CheckedChanged(object sender, EventArgs e)
        {
            //if (chkeliminados.Checked == false)
            //{
            //    llenaEmpresa("A");
            //    btndesactiva.Visible = true;
            //    btnactivar.Visible = false;
            //}
            //else
            //{
            //    llenaEmpresa("P");
            //    btndesactiva.Visible = false;
            //    btnactivar.Visible = true;
            //}
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            modificar();
            estado = "E"; 
        }
     
        private void modificar()
        {
            try
            {
                EmpresaDB objE = new EmpresaDB();
                objE.setEmpresa(objE.TraeEmpresa((dgvempresa.Rows[fila].Cells[0].Value.ToString()))); 
                if (objE.getEmpresa().idEmpresa==0)
                {
                    MessageBox.Show("No existe registro de la Empresa", "Tienda", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    
                    txtnom.Text = objE.getEmpresa().nomemp;
                    txtdir.Text = objE.getEmpresa().diremp;
                    msktelf.Text = objE.getEmpresa().telemp;
                    estado = "E";
                
                    groupBox2.Enabled = true;
                    txtnom.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al presentar los datos," + ex.Message, "Tienda", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvempresa_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            fila = dgvempresa.CurrentRow.Index;
        }

        private void dgvempresa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
       
    }
}
