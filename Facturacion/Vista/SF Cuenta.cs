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

        private void SF_Cuenta_Load(object sender, EventArgs e)
        {
            llenaCuenta("A");
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
            llenaCuenta("A");
            groupBox2.Enabled = false;
            Util.limpiar(groupBox2.Controls);
        }
        private void Adiciona()
        {
            try
            {
                CuentaDB objC = new CuentaDB();
                int resp;
                llenaPersona(objC);
                resp = objC.InsertaCuenta(objC.getPersona());
                if (resp == 0)
                {
                    MessageBox.Show("No se ingreso datos de la Cuenta", "Tienda", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Cuenta Ingresado", "Tienda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Ingresar Datos," + ex.Message, "Tienda", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private CuentaDB llenaPersona(CuentaDB cuent)
        {
            cuent.getPersona().cedper = mskced.Text.Trim();
            cuent.getPersona().apeper = txtape.Text.Trim();
            cuent.getPersona().nomper = txtnom.Text.Trim();
            cuent.getPersona().dirper = txtdir.Text.Trim();
            cuent.getPersona().telper = msktelf.Text.Trim();
            cuent.getPersona().Cuenta.clacuent = mskcla.Text.Trim();
            cuent.getPersona().estper = "A";
            return cuent;
        }
        public void llenaCuenta(string est)
        {
            try
            {
                dgvcuenta.Rows.Clear();
                CuentaDB objC = new CuentaDB();
                objC.getPersona().ListaPersonas = objC.Traepersonas(est);
                if (objC.getPersona().ListaPersonas.Count == 0)
                {
                    MessageBox.Show("No existen Cuentas Registradas", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    fila = 0;
                    for (int i = 0; i < objC.getPersona().ListaPersonas.Count; i++)
                    {
                        dgvcuenta.Rows.Add(1);
                        dgvcuenta.Rows[i].Cells[0].Value = objC.getPersona().ListaPersonas[i].cedper;
                        dgvcuenta.Rows[i].Cells[1].Value = objC.getPersona().ListaPersonas[i].Nombre;
                        dgvcuenta.Rows[i].Cells[2].Value = objC.getPersona().ListaPersonas[i].dirper;
                        dgvcuenta.Rows[i].Cells[3].Value = objC.getPersona().ListaPersonas[i].telper;
                        dgvcuenta.Rows[i].Cells[4].Value = objC.getPersona().ListaPersonas[i].estper;
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
                CuentaDB objC = new CuentaDB();
                int resp;
                llenaPersona(objC);
                resp = objC.ActualizaCuenta(objC.getPersona());
                if (resp == 0)
                {
                    MessageBox.Show("No se modifico datos de la Cuenta", "Tienda", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Cuenta Modificada", "Tienda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    estado = "";
                    llenaCuenta("A");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Ingresar Datos," + ex.Message, "Tienda", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnnuevo_Click(object sender, EventArgs e)
        {
            estado = "N";
            Util.limpiar(groupBox2.Controls);
            groupBox2.Enabled = true;
            mskced.Enabled = true;
            mskced.Focus();
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
                CuentaDB objC = new CuentaDB();
                objC.setPersona(objC.Traepersona(dgvcuenta.Rows[fila].Cells[0].Value.ToString()));
                if (objC.getPersona().cedper == "")
                {
                    MessageBox.Show("No existe registro de Cuenta", "Tienda", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    mskced.Text = objC.getPersona().cedper;
                    txtape.Text = objC.getPersona().apeper;
                    txtnom.Text = objC.getPersona().nomper;
                    txtdir.Text = objC.getPersona().dirper;
                    msktelf.Text = objC.getPersona().telper;
                    mskcla.Text = objC.getPersona().Cuenta.clacuent;
                    mskced.Enabled = false;
                    estado = "E";
                    txtnom.Focus();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al presentar los datos," + ex.Message, "Tienda", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                CuentaDB objB = new CuentaDB();
                int resp;
                string ced = dgvcuenta.Rows[fila].Cells[0].Value.ToString();
                if (MessageBox.Show("Desea desactivar a: " + dgvcuenta.Rows[fila].Cells[1].Value.ToString(), "Tienda", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
                {
                    resp = objB.DesactivaCuenta(ced);
                    if (resp > 0)
                    {
                        MessageBox.Show("Cuenta Desactivada", "Tienda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        estado = "";
                        llenaCuenta("A");
                    }
                    else
                    {
                        MessageBox.Show("No se Desactivo la Cuenta", "Tienda", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void btnactivar_Click(object sender, EventArgs e)
        {
            activar();
        }
        private void activar()
        {
            try
            {
                CuentaDB objB = new CuentaDB();
                int resp;
                string ced = dgvcuenta.Rows[fila].Cells[0].Value.ToString();
                if (MessageBox.Show("Desea activar a: " + dgvcuenta.Rows[fila].Cells[1].Value.ToString(), "Tienda", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
                {
                    resp = objB.ActivarCuenta(ced);
                    if (resp > 0)
                    {
                        MessageBox.Show("Cuenta Activada", "Tienda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        estado = "";
                        llenaCuenta("P");
                    }
                    else
                    {
                        MessageBox.Show("No se Activo la Cuenta", "Tienda", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                llenaCuenta("A");
                btndesactivar.Visible = true;
                btnactivar.Visible = false;
            }
            else
            {
                llenaCuenta("P");
                btndesactivar.Visible = false;
                btnactivar.Visible = true;
            }
        }

        private void dgvcuenta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            fila = dgvcuenta.CurrentRow.Index;
        }

       
    }
}
