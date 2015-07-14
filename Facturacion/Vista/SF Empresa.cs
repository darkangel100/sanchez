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
            mskruc.Enabled = true;
            mskruc.Focus();
        }

        private void Adiciona()
        {
            try
            {
                EmpresaDB objE = new EmpresaDB();
                int resp;
                llenaEmpre(objE);
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
        private EmpresaDB llenaEmpre(EmpresaDB lemp)
        {
            lemp.getEmpresa().idEmpresa = mskruc.Text.Trim();
            lemp.getEmpresa().nomemp = txtnom.Text.Trim();
            lemp.getEmpresa().diremp = txtdir.Text.Trim();
            lemp.getEmpresa().telemp = txtdir.Text.Trim();
            lemp.getEmpresa().estemp = "A";
            return lemp;
        }
        public void llenaEmpresa(string est)
        {
            try
            {
                dgvempresa.Rows.Clear();
                EmpresaDB objC = new EmpresaDB();
                objC.getEmpresa().ListaEmpresas = objC.TraeEmpresas(est);
                if (objC.getEmpresa().ListaEmpresas.Count == 0)
                {
                    MessageBox.Show("No existen Empresas Ingresadas", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    fila = 0;
                    for (int i = 0; i < objC.getEmpresa().ListaEmpresas.Count; i++)
                    {
                        dgvempresa.Rows.Add(1);
                        dgvempresa.Rows[i].Cells[0].Value = objC.getEmpresa().ListaEmpresas[i].idEmpresa;
                        dgvempresa.Rows[i].Cells[1].Value = objC.getEmpresa().ListaEmpresas[i].nomemp;
                        dgvempresa.Rows[i].Cells[2].Value = objC.getEmpresa().ListaEmpresas[i].diremp;
                        dgvempresa.Rows[i].Cells[3].Value = objC.getEmpresa().ListaEmpresas[i].telemp;
                        dgvempresa.Rows[i].Cells[4].Value = objC.getEmpresa().ListaEmpresas[i].estemp;

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Al Presentar los Datos," + ex.Message, "Tienda", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SF_Empresa_Load(object sender, EventArgs e)
        {
            llenaEmpresa("A");
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
            llenaEmpresa("A");
            groupBox2.Enabled = false;
            Util.limpiar(groupBox2.Controls);
        }

        private void Editar()
        {
            try
            {
                EmpresaDB objC = new EmpresaDB();
                int resp;
                llenaEmpre(objC);
                resp = objC.ActualizaEmpreza(objC.getEmpresa());
                if (resp == 0)
                {
                    MessageBox.Show("No se modifico datos del Cliente", "Tienda", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Cliente Modificado", "Tienda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    estado = "";
                    llenaEmpresa("A");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Ingresar Datos," + ex.Message, "Tienda", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                EmpresaDB objB = new EmpresaDB();
                int resp;
                string ruc = dgvempresa.Rows[fila].Cells[0].Value.ToString();
                if (MessageBox.Show("Desea activar a: " + dgvempresa.Rows[fila].Cells[1].Value.ToString(), "Tienda", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
                {
                    resp = objB.ActivarEmpresa(ruc);
                    if (resp > 0)
                    {
                        MessageBox.Show("Cliente Activado", "Tienda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        llenaEmpresa("P");
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

        private void btndesactiva_Click(object sender, EventArgs e)
        {
            desactivar();
        }
        private void desactivar()
        {
            try
            {
                EmpresaDB objB = new EmpresaDB();
                int resp;
                string ruc = dgvempresa.Rows[fila].Cells[0].Value.ToString();
                if (MessageBox.Show("Desea activar a: " + dgvempresa.Rows[fila].Cells[1].Value.ToString(), "Tienda", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
                {
                    resp = objB.DesactivarEmpresa(ruc);
                    if (resp > 0)
                    {
                        MessageBox.Show("Empresa Desactivada", "Tienda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        llenaEmpresa("A");
                    }
                    else
                    {
                        MessageBox.Show("No se Desactivo la Empresa", "Tienda", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                llenaEmpresa("A");
                btndesactiva.Visible = true;
                btnactivar.Visible = false;
            }
            else
            {
                llenaEmpresa("P");
                btndesactiva.Visible = false;
                btnactivar.Visible = true;
            }
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            groupBox2.Enabled = true;
            modificar();
        }
        private void modificar()
        {
            try
            {
                EmpresaDB emp = new EmpresaDB();
                emp.setEmpresa(emp.TraeEmpresa(dgvempresa.Rows[fila].Cells[0].Value.ToString()));
                if (emp.getEmpresa().idEmpresa == "")
                {
                    MessageBox.Show("No existe registro del Cliente", "Tienda", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    mskruc.Text = emp.getEmpresa().idEmpresa;
                    txtnom.Text = emp.getEmpresa().nomemp;
                    txtdir.Text = emp.getEmpresa().diremp;
                    msktelf.Text = emp.getEmpresa().telemp;
                    mskruc.Enabled = false;
                    estado = "E";
                    txtnom.Focus();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al presentar los datos," + ex.Message, "Tienda", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvempresa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            fila = dgvempresa.CurrentRow.Index;
        }
       
    }
}
