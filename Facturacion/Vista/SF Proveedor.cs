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
            //if (estado == "N")
            //{
            //    Adiciona();
            //}
            //if (estado == "E")
            //{
            //    Editar();
            //}
            //llenaPro("A");
            //txtcod.Enabled = false;
            //cbocat.Enabled = true;
        }
        //private void Adiciona()
        //{
        //    try
        //    {
        //        int resp;
        //        int resp2;
        //        PersonaDB objU = new PersonaDB();
        //        RolDB rol = new RolDB();
        //        ProveedorDB objC = new ProveedorDB();
        //        llenaPersona(objU);
        //        llenaProvee(objC);
        //        resp = objU.InsertaPersona(objU.getPersona());
        //        resp2 = objC.ingr(objC.getCuenta());
        //        if (resp == 0 || resp2 == 0)
        //        {
        //            MessageBox.Show("No se ingreso datos de Usuario", "Ventas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        }
        //        if (resp == 1 && resp2 == 1)
        //        {
        //            MessageBox.Show("Usuario Ingresado", "Ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);

        //            estado = "";
        //            Util.limpiar(groupBox2.Controls);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Error al Ingresar Datos," + ex.Message, "Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}
        //private PersonaDB llenaPersona(PersonaDB lper)
        //{
        //    lper.getPersona().cedper = mskruc.Text.Trim();
        //    lper.getPersona().nomper = txtnom.Text.Trim();
        //    lper.getPersona().apeper = txtape.Text.Trim();
        //    lper.getPersona().dirper = txtdir.Text.Trim();
        //    lper.getPersona().telper = msktelf.Text.Trim();
        //    lper.getPersona().idrol = lper.traeIdRol("proveedor");
        //    lper.getPersona().estper = "A";
        //    return lper;
        //}

        private ProveedorDB llenaProvee(ProveedorDB lcue)
        {

            lcue.getProveedor().idempreProvee= cboemp.SelectedValue.ToString(); 
            lcue.getProveedor().estprovee = "A";
            return lcue;
        }
        #endregion
    }
}
