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
                MessageBox.Show("Error " + ex.Message, "Tienda", MessageBoxButtons.OK);
            }
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
            llenaPro("A");
            txtcod.Enabled = false;
            cbocat.Enabled = true;
        }
        private void Adiciona()
        {
            try
            {
                ProductoDB objP = new ProductoDB();
                llenaProducto(objP);
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
            lpro.getProductos().idpro = txtcod.Text.Trim();
            lpro.getProductos().idcat = cbocat.SelectedValue.ToString();
            lpro.getProductos().nompro = txtnom.Text.Trim();
            lpro.getProductos().precom = Convert.ToDouble(txtcom.Text.Trim());
            lpro.getProductos().canpro = Convert.ToInt32(txtcan.Text.Trim());
            lpro.getProductos().porgan = Convert.ToDouble(txtgan.Text.Trim());
            lpro.getProductos().pregan = Convert.ToDouble(txtreal.Text.Trim());
            if (chkiva.Checked == true)
                lpro.getProductos().ivasn = "I";
            else
                lpro.getProductos().ivasn = "N";
            lpro.getProductos().preven = Convert.ToDouble(txtven.Text.Trim());
            lpro.getProductos().fecing = Util.girafecha(dtpfece.Value.ToShortDateString());
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
                        dgvpro.Rows[i].Cells[0].Value = objC.getProductos().ListaProductos[i].idpro;
                        dgvpro.Rows[i].Cells[1].Value = objC.getProductos().ListaProductos[i].idcat;
                        dgvpro.Rows[i].Cells[2].Value = objC.getProductos().ListaProductos[i].nompro;
                        dgvpro.Rows[i].Cells[3].Value = objC.getProductos().ListaProductos[i].precom;
                        dgvpro.Rows[i].Cells[4].Value = objC.getProductos().ListaProductos[i].canpro;
                        dgvpro.Rows[i].Cells[5].Value = objC.getProductos().ListaProductos[i].porgan;
                        dgvpro.Rows[i].Cells[6].Value = objC.getProductos().ListaProductos[i].pregan;
                        dgvpro.Rows[i].Cells[7].Value = objC.getProductos().ListaProductos[i].preven;
                        dgvpro.Rows[i].Cells[8].Value = objC.getProductos().ListaProductos[i].ivasn;
                        dgvpro.Rows[i].Cells[9].Value = objC.getProductos().ListaProductos[i].fecing;
                        dgvpro.Rows[i].Cells[10].Value = objC.getProductos().ListaProductos[i].estpro;
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

        private void Editar()
        {
            try
            {
                ProductoDB objP = new ProductoDB();
                int resp;
                llenaProducto(objP);
                resp = objP.Actualizaproducto(objP.getProductos());
                if (resp == 0)
                {
                    MessageBox.Show("No se ingreso datos de Producto", "Tienda", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Producto Modificado", "Tienda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    estado = "";
                    llenacategoria(cbocat, "A");
                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar los Datos," + ex.Message, "Tienda", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void SF_Producto_Load(object sender, EventArgs e)
        {
            llenacategoria(cbocat,"A");
            llenaPro("A");
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            txtcod.Enabled = false;
            cbocat.Enabled = false;
            modificar();
        }
        private void modificar()
        {
            try
            {
                ProductoDB pro = new ProductoDB();
                CategoriaDB cat = new CategoriaDB();
                pro.setProductos(pro.Traeproducto(dgvpro.Rows[fila].Cells[0].Value.ToString()));
                if (pro.getProductos().idpro.Equals(""))
                {
                    MessageBox.Show("No existe registro de Productos", "Tienda", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    txtcod.Text = pro.getProductos().idpro;
                    string codc = pro.getProductos().idcat;
                    cat.setCategorias(cat.TraeCategoria(codc));
                    cbocat.Text = cat.getCategorias().nomcat;
                    txtnom.Text = pro.getProductos().nompro;
                    txtcom.Text = pro.getProductos().precom.ToString();
                    txtcan.Text = pro.getProductos().canpro.ToString();
                    txtgan.Text = pro.getProductos().porgan.ToString();
                    txtreal.Text = pro.getProductos().pregan.ToString();
                    if (pro.getProductos().ivasn == "I")
                        chkiva.Checked = true;
                    else
                        chkiva.Checked = false;
                    txtven.Text = pro.getProductos().preven.ToString();
                    dtpfece.Value = Convert.ToDateTime(pro.getProductos().fecing);
                    estado = "E";
                    txtnom.Focus();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al presentar los datos," + ex.Message, "Tienda", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvpro_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            fila = dgvpro.CurrentRow.Index;
        }

        private void btndesactivar_Click(object sender, EventArgs e)
        {
            desactivar();
        }
        private void desactivar()
        {
            try
            {
                ProductoDB objB = new ProductoDB();
                int resp;
                string pro = dgvpro.Rows[fila].Cells[0].Value.ToString();
                if (MessageBox.Show("Desea desactivar a: " + dgvpro.Rows[fila].Cells[2].Value.ToString(), "Tienda", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
                {
                    resp = objB.DesactivarProducto(pro);
                    if (resp > 0)
                    {
                        MessageBox.Show("Producto Desactivado", "Tienda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        llenaPro("A");
                    }
                    else
                    {
                        MessageBox.Show("No se Desactivo el Producto", "Tienda", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
        private void Activar()
        {
            try
            {
                ProductoDB objB = new ProductoDB();
                int resp;
                string pro = dgvpro.Rows[fila].Cells[0].Value.ToString();
                if (MessageBox.Show("Desea desactivar a: " + dgvpro.Rows[fila].Cells[2].Value.ToString(), "Tienda", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
                {
                    resp = objB.DesactivarProducto(pro);
                    if (resp > 0)
                    {
                        MessageBox.Show("Producto Desactivado", "Tienda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        llenaPro("P");
                    }
                    else
                    {
                        MessageBox.Show("No se Desactivo el Producto", "Tienda", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            Activar();
        }

        private void chkeliminados_CheckedChanged(object sender, EventArgs e)
        {
            if (chkeliminados.Checked == false)
            {
                llenaPro("A");
                btndesactivar.Visible = true;
                btnactivar.Visible = false;
            }
            else
            {
                llenaPro("P");
                btndesactivar.Visible = false;
                btnactivar.Visible = true;
            }
        }

        private void cbocat_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
