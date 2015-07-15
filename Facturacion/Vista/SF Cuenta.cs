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
        string num;
        int aux_idpercuen;
        int fila = -1;
        #region
        #endregion
        //load de la ventana
        #region
        private void SF_Cuenta_Load(object sender, EventArgs e)
        {
            llenaRol(cborol);
            llenausuario("A");
        }
        #endregion    
        //llena el rol en el combobox
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
                cborol.DisplayMember = "nomrol";
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
           
            if (estado == "E")
            {
                editar();
            }
            llenausuario("A");
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
                RolDB rol = new RolDB();
                PersonaDB objU = new PersonaDB();
                llenaUsu(objU);
                CuentaDB objC = new CuentaDB();
                llenaCuenta(objC);
                resp = objU.InsertaPersona(objU.getPersona());
                resp2 = objC.llenacuenta(objC.getCuenta());
                if (resp == 0 || resp2 == 0)
                {
                    MessageBox.Show("No se ingreso datos en la Cuenta", "Ventas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (resp == 1 && resp2 == 1)
                {
                    MessageBox.Show("Cuenta Ingresado", "Ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    estado = "";
                   
                    Util.limpiar(groupBox2.Controls);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Ingresar Datos," + ex.Message, "Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private PersonaDB llenaUsu(PersonaDB lper)
        {
            lper.getPersona().cedper = mskced.Text.Trim();
            lper.getPersona().apeper = txtape.Text.Trim();
            lper.getPersona().nomper = txtnom.Text.Trim();
            lper.getPersona().dirper = txtdir.Text.Trim();
            lper.getPersona().telper = txttel.Text.Trim();
            if (cborol.SelectedIndex == 0)
            {
                lper.getPersona().idrol = lper.traeIdRol("vendedor");

            }
            else
            {
                lper.getPersona().idrol = lper.traeIdRol("gerente");

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
      
        #endregion
        //metodo `para cargar los datos los datos guardados en la base de datos en el la tabla
        #region
        public void llenausuario(string est)
        {
            try
            {
                dgvcuenta.Rows.Clear();
                UsuarioDB objU = new UsuarioDB();
                objU.getUsuario().ListaPersonas = objU.TraeUsuarios(est);
                if (objU.getUsuario().ListaPersonas.Count == 0)
                {
                    MessageBox.Show("No existen registros de usuarios", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    fila = 0;
                    for (int i = 0; i < objU.getUsuario().ListaPersonas.Count; i++)
                    {
                        dgvcuenta.Rows.Add(1);
                        dgvcuenta.Rows[i].Cells[0].Value = objU.getUsuario().ListaPersonas[i].cedper;
                        dgvcuenta.Rows[i].Cells[1].Value = objU.getUsuario().ListaPersonas[i].Nombre;
                        dgvcuenta.Rows[i].Cells[2].Value = objU.getUsuario().ListaPersonas[i].dirper;
                        dgvcuenta.Rows[i].Cells[3].Value = objU.getUsuario().ListaPersonas[i].telper;
                        dgvcuenta.Rows[i].Cells[4].Value = objU.getUsuario().ListaPersonas[i].estper;

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

       //boton modificar
        #region
        private void btnmodificar_Click(object sender, EventArgs e)
        {
            modificar();
            groupBox2.Enabled = true;
        }
        //metodo para llenar los los textbox y maskedbox con los datos de persona y cuenta para ser modificados
        #region
        private void modificar()
        {
            try
            {
                PersonaDB objP = new PersonaDB();
                UsuarioDB objU = new UsuarioDB();
                CuentaDB objC = new CuentaDB();
                objP.setPersona(objU.TraeUsuario(dgvcuenta.Rows[fila].Cells[0].Value.ToString()));
                objC.setCuenta(objC.Traecuenta());
                if (objU.getUsuario().cedper == "")
                {
                    MessageBox.Show("No existe registro del Usuario", "Tienda", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    mskced.Text = objP.getPersona().cedper;
                    txtape.Text = objP.getPersona().apeper;
                    txtnom.Text = objP.getPersona().nomper;
                    txtdir.Text = objP.getPersona().dirper;
                    txttel.Text = objP.getPersona().telper;
                    mskcla.Text = objC.getCuenta().Clave;
                    txtusu.Text = objC.getCuenta().nomcuen;
                    estado = "E";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al presentar los datos," + ex.Message, "Tienda", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //metodo para editar los datos 
        #endregion
        private void editar()
        {
            try
            {
                PersonaDB objB = new PersonaDB();
                CuentaDB objC = new CuentaDB();
                int resp;
                int resp1 = 0;
                objB.getPersona().cedper = mskced.Text;
                objC.getCuenta().idperCuen = aux_idpercuen;
                llenaUsu(objB);
                llenaCuenta(objC);
                resp = objB.ActualizaPersona(objB.getPersona());
                resp1 = objC.ActualizaCuenta(objC.getCuenta());

                if ((resp == 0) || (resp1 == 0))
                {
                    MessageBox.Show("No se modifico datos del Usuario", "Tienda", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (resp == 1 && resp1 == 1)
                {
                    MessageBox.Show("Usuario Modificado", "Tienda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    estado = "";
                    llenausuario("A");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Ingresar Datos," + ex.Message, "Tienda", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        private void dgvcuenta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            fila = dgvcuenta.CurrentRow.Index;
        }

        private void dgvcuenta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            
        }



    }
}
