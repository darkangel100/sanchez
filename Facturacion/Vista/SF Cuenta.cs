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
    public partial class SF_Cuenta : Form
    {
        public SF_Cuenta()
        {
            InitializeComponent();
        }
        string estado = "";
        string num;
        int aux_idpercuen;
        int fila = -1;
        private void SF_Cuenta_Load(object sender, EventArgs e)
        {
            llenaRol(cborol);
        }
        #region
        private void llenaRol(ComboBox cbo)//Llena combobox de roles
        {
            try
            {
                RolDB objC = new RolDB();
                objC.getRol().ListaRol = objC.TraeRol();
                if (objC.getRol().ListaRol.Count == 0)
                {
                    MessageBox.Show("No existen de Usuarios", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                cborol.DisplayMember = "nom_rol";
                cborol.ValueMember = "idRol";
                cbo.DataSource = objC.getRol().ListaRol;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Al Presentar los Datos," + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
        //boton nuevo
        #region
        private void btnnuevo_Click(object sender, EventArgs e)
        {
            estado = "N";
            Util.limpiar(groupBox2.Controls);
            groupBox2.Enabled = true;
            mskced.Enabled = true;
            mskced.Focus();
        }
        #endregion
        //boton guardar
        #region
        private void btnguardar_Click(object sender, EventArgs e)
        {
            PersonaDB objp = new PersonaDB();
            if (estado == "N")
            {
                num = objp.traenumero();
                if (num.Equals(""))
                {
                    aux_idpercuen = 1;
                }
                else
                {
                    aux_idpercuen = Convert.ToInt32(num);
                    aux_idpercuen++;
                }
            }
            if (estado == "N")
            {


                Adiciona();


            }
            llenaUsuario("A");
            //if (estado == "E")
            //{
            //    editar();
            //}
            //Utiles.limpiar(panel1.Controls);
            //indice = 0;
            //tc1.SelectTab(indice);
        }
        private void Adiciona()
        {
            try
            {
                int resp;
                int resp2;
                PersonaDB objU = new PersonaDB();
                RolDB rol = new RolDB();
                CuentaDB objC = new CuentaDB();
                llenaPersona(objU);
                llenaCuenta(objC);
                resp = objU.InsertaPersona(objU.getPersona());
                resp2 = objC.ingresacuenta(objC.getCuenta());
                if (resp == 0 || resp2 == 0)
                {
                    MessageBox.Show("No se ingreso datos de Usuario", "Ventas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (resp == 1 && resp2 == 1)
                {
                    MessageBox.Show("Usuario Ingresado", "Ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    estado = "";
                    llenaUsuario("A");
                    Util.limpiar(groupBox2.Controls);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Ingresar Datos," + ex.Message, "Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private PersonaDB llenaPersona(PersonaDB lper)
        {
            lper.getPersona().cedper = mskced.Text.Trim();
            lper.getPersona().nomper = txtnom.Text.Trim();
            lper.getPersona().apeper = txtape.Text.Trim();
            lper.getPersona().dirper = txtdir.Text.Trim();
            lper.getPersona().telper = msktelf.Text.Trim();
            if (cborol.SelectedIndex == 0)
            {
                lper.getPersona().idrol = lper.traeIdRol("vendedor");

            }
            else
            {
                lper.getPersona().idrol = lper.traeIdRol("administrador");

            }
            lper.getPersona().estper = "A";
            return lper;
        }

        private CuentaDB llenaCuenta(CuentaDB lcue)
        {

            lcue.getCuenta().nomcuen = txtusu.Text.Trim();
            lcue.getCuenta().Clave = mskcla.Text.Trim();
            lcue.getCuenta().idperCuen = aux_idpercuen;
            lcue.getCuenta().estcuen = "A";
            return lcue;
        }
        public void llenaUsuario(string est)
        {
            try
            {
                dgvcuenta.Rows.Clear();
                UsuarioDB objC = new UsuarioDB();
                objC.getUsuario().ListaPersonas = objC.Traeusuarios(est);
                if (objC.getUsuario().ListaPersonas.Count == 0)
                {
                    MessageBox.Show("No existen Clientes Ingresados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    fila = 0;
                    for (int i = 0; i < objC.getUsuario().ListaPersonas.Count; i++)
                    {
                        dgvcuenta.Rows.Add(1);
                        dgvcuenta.Rows[i].Cells[0].Value = objC.getUsuario().ListaPersonas[i].cedper;
                        dgvcuenta.Rows[i].Cells[1].Value = objC.getUsuario().ListaPersonas[i].Nombre;
                        dgvcuenta.Rows[i].Cells[2].Value = objC.getUsuario().ListaPersonas[i].dirper;
                        dgvcuenta.Rows[i].Cells[3].Value = objC.getUsuario().ListaPersonas[i].telper;
                        dgvcuenta.Rows[i].Cells[4].Value = objC.getUsuario().ListaPersonas[i].estper;

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Al Presentar los Datos," + ex.Message, "Tienda", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
        private void mskced_KeyPress(object sender, KeyPressEventArgs e)
        {

           
        }

        private void txtnom_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void txtape_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

      
        
       
    }
}
