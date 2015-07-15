using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Facturacion.Modelo;
using Facturacion.Controlador;

namespace Facturacion.Vista
{
    public partial class SF_Proveedor : Form
    {
        public SF_Proveedor()
        {
            InitializeComponent();
        }
        string estado = "";
        int fila = -1;
        public int id_persona;
        string num;
        
        //boton nuevo
        #region
        private void btnnuevo_Click(object sender, EventArgs e)
        {
            estado = "N";
            Util.limpiar(groupBox3.Controls);
            groupBox3.Enabled = true;
            txtnom.Enabled = true;
            txtnom.Focus();
            //codigo();
        }
        #endregion
        //boton guardar
        #region
        private void btnguardar_Click(object sender, EventArgs e)
        {
            PersonaDB objP = new PersonaDB();
            num = objP.traenumero();
            if (num.Equals(""))
            {
                id_persona = 1;
            }
            else
            {
                id_persona = Convert.ToInt32(num);
                id_persona++;
            }
            if (estado == "N")
            {
                Adiciona();
            }

            //if (estado == "E")
            //{
            //    Editar();
            //}
            //llenaPro("A");
            //txtcod.Enabled = false;
            //cbocat.Enabled = true;
        }
        private void Adiciona()
        {

            try
            {
                int resp = 0;
                int resp1 = 0;  
                PersonaDB objP = new PersonaDB();
                llenaPersona(objP);
                ProveedorDB objPro = new ProveedorDB();
                llenaProvee(objPro);
                resp = objP.InsertaPersona(objP.getPersona());
                resp1 = objPro.InsertaProveedor(objPro.getProveedor());
                if (resp == 0 || resp1 == 0)
                {
                    MessageBox.Show("No se ingreso datos de Proveedor", "Koreano-Chino", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (resp == 1 & resp1 == 1)
                {
                    MessageBox.Show("Proveedor Ingresado", "Koreano-Chino", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Ingresar Datos," + ex.Message, "Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private PersonaDB llenaPersona(PersonaDB lper)
        {
            lper.getPersona().cedper = txtced.Text.Trim();
            lper.getPersona().Nombre = txtnom.Text.Trim();
            lper.getPersona().apeper = txtape.Text.Trim();
            lper.getPersona().dirper = txtdir.Text.Trim();
            lper.getPersona().telper = msktelf.Text.Trim();
            lper.getPersona().idrol = int.Parse("3");
            return lper;
        }

        private ProveedorDB llenaProvee(ProveedorDB lpro)
        {

            lpro.getProveedor().RucProveedor = mskruc.Text.Trim();
            lpro.getProveedor().idperProvee = id_persona;
            lpro.getProveedor().idempreProvee = lpro.traeidEmpresa(cboemp.Text.ToString());
            lpro.getProveedor().estprovee = "A";
            return lpro;
        }
        #endregion

        private void SF_Proveedor_Load(object sender, EventArgs e)
        {
            //llenaempresa("A");
        }
        //private void llenaempresa(string est)
        //{

        //    try
        //    {
        //        EmpresaDB objE = new EmpresaDB();
        //        objE.getEmpresa().ListaEmpresas = objE.TraeEmpresas(est);
        //        if (objE.getEmpresa().ListaEmpresas.Count == 0)
        //        {
        //            MessageBox.Show("No existen registros de Categorias", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        //        }
        //        cboemp.DisplayMember = "nombreEmpresa";
        //        cboemp.ValueMember = "idempresa";
        //        cboemp.DataSource = objE.getEmpresa().ListaEmpresas;
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Error Al Presentar los Datos," + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}
    }
}
