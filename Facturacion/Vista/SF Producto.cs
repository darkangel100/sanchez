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
    public partial class SF_Producto : Form
    {
        public SF_Producto()
        {
            InitializeComponent();
        }
        string estado = "";
        int fila = -1;
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
                ProductoDB obj = new ProductoDB();
                nro = obj.TraeCodigo();
                txtcod.Text = (nro + 1).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar los Datos," + ex.Message, "Tienda", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            if (estado == "N")
            {
                Adiciona();
            }
            //if (estado == "E")
            //{
            //    Editar();
            //}
            llenaProd("A");
        }
        private void Adiciona()
        {
            try
            {
                ProductoDB objP = new ProductoDB();
                llenaProducto(objP);
                objP.getProductos().codpro = txtcod.Text.Trim();
                objP.getProductos().codcat = cbocat.SelectedValue.ToString();
                objP.getProductos().nompro = txtnom.Text.Trim();
                objP.getProductos().precom = Convert.ToDouble(txtcom.Text.Trim());
                objP.getProductos().canpro = Convert.ToInt32(txtcan.Text.Trim());
                objP.getProductos().porgan = Convert.ToDouble(txtgan.Text.Trim());
                objP.getProductos().pregan = Convert.ToDouble(txtreal.Text.Trim());
                if (chkiva.Checked == true)
                    objP.getProductos().ivasn = "I";
                else
                    objP.getProductos().ivasn = "N";
                objP.getProductos().preven = Convert.ToDouble(txtven.Text.Trim());
                objP.getProductos().fecela = Util.girafecha(dtpfece.Value.ToShortDateString());

                int resp = objP.Insertaproducto(objP.getProductos());
                if (resp == 0)
                {
                    MessageBox.Show("No se ingreso datos de Producto", "Tienda", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Producto Ingresado", "Tienda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    estado = "";
                    llenacategoria(cbocat,"A");
                    Util.limpiar(groupBox1.Controls);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Ingresar Datos," + ex.Message, "Tienda", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private ProductoDB llenaProducto(ProductoDB lpro)
        {
            lpro.getProductos().codpro = txtcod.Text.Trim();
            lpro.getProductos().codcat = cbocat.Text.Trim();
            lpro.getProductos().nompro = txtnom.Text.Trim();
            lpro.getProductos().precom = Convert.ToDouble(txtcom.Text.Trim());
            lpro.getProductos().canpro = int.Parse(txtstock.Text.Trim());
            lpro.getProductos().porgan = Convert.ToDouble(txtgan.Text.Trim());
            lpro.getProductos().pregan = Convert.ToDouble(txtreal.Text.Trim());
            lpro.getProductos().preven = Convert.ToDouble(txtven.Text.Trim());
            lpro.getProductos().estpro = "A";
            return lpro;
        }
        public void llenaPro(string est)
        {
            try
            {
                dgvpro.Rows.Clear();
                ProductoDB objC = new ProductoDB();
                objC.getProductos().ListaProductos = objC.Traeproductos(est);
                if (objC.getProductos().ListaProductos.Count == 0)
                {
                    MessageBox.Show("No existen Productos Ingresados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    fila = 0;
                    for (int i = 0; i < objC.getProductos().ListaProductos.Count; i++)
                    {
                        dgvpro.Rows.Add(1);
                        dgvpro.Rows[i].Cells[0].Value = objC.getProductos().ListaProductos[i].codpro;
                        dgvpro.Rows[i].Cells[1].Value = objC.getProductos().ListaProductos[i].codcat;
                        dgvpro.Rows[i].Cells[2].Value = objC.getProductos().ListaProductos[i].nompro;
                        dgvpro.Rows[i].Cells[3].Value = objC.getProductos().ListaProductos[i].precom;
                        dgvpro.Rows[i].Cells[4].Value = objC.getProductos().ListaProductos[i].canpro;
                        dgvpro.Rows[i].Cells[5].Value = objC.getProductos().ListaProductos[i].porgan;
                        dgvpro.Rows[i].Cells[6].Value = objC.getProductos().ListaProductos[i].pregan;
                        dgvpro.Rows[i].Cells[7].Value = objC.getProductos().ListaProductos[i].preven;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Al Presentar los Datos," + ex.Message, "Tienda", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void llenacategoria(ComboBox cbo,string est)
        {
              try
            {
                CategoriaDB objC = new CategoriaDB();
                objC.getCategorias().ListaCategorias = objC.TraeCategorias(est);
                if (objC.getCategorias().ListaCategorias.Count == 0)
                {
                    MessageBox.Show("No existen Categorias Ingresadas", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                cbocat.DisplayMember = "nomcat";
                cbocat.ValueMember = "idCat";
                cbocat.DataSource = objC.getCategorias().ListaCategorias;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Al Presentar los Datos," + ex.Message, "Tienda", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
        public void llenaProd(string est)
        {
            try
            {
                dgvpro.Rows.Clear();
                ProductoDB objC = new ProductoDB();
                objC.getProductos().ListaProductos = objC.Traeproductos(est);
                if (objC.getProductos().ListaProductos.Count == 0)
                {
                    MessageBox.Show("No existen Productos Ingresadas", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    fila = 0;
                    for (int i = 0; i < objC.getProductos().ListaProductos.Count; i++)
                    {
                        dgvpro.Rows.Add(1);
                        dgvpro.Rows[i].Cells[0].Value = objC.getProductos().ListaProductos[i].codpro;
                        dgvpro.Rows[i].Cells[1].Value = objC.getProductos().ListaProductos[i].codcat;
                        dgvpro.Rows[i].Cells[2].Value = objC.getProductos().ListaProductos[i].nompro;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Al Presentar los Datos," + ex.Message, "Tienda", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void SF_Producto_Load(object sender, EventArgs e)
        {
            llenacategoria(cbocat,"A");
            llenaProd("A");
        }
        
    }
}
