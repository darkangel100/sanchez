using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Facturacion.Vista
{
    public partial class SF_Principal : Form
    {
        public SF_Principal()
        {
            InitializeComponent();
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SF_Cuenta sfcuent = new SF_Cuenta();
            sfcuent.MdiParent = this;
            sfcuent.Show();
        }

        private void personaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SF_Cliente sfcli = new SF_Cliente();
            sfcli.MdiParent = this;
            sfcli.Show();
        }

        private void proveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SF_Proveedor sfprove = new SF_Proveedor();
            sfprove.MdiParent = this;
            sfprove.Show();
        }

        private void productoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SF_Producto sfproduc = new SF_Producto();
            sfproduc.MdiParent = this;
            sfproduc.Show();
        }

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SF_Categoria sfcat = new SF_Categoria();
            sfcat.MdiParent = this;
            sfcat.Show();
        }

        private void facturacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SF_Facturacion sffac = new SF_Facturacion();
            sffac.MdiParent = this;
            sffac.Show();
        }

        private void anularFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SF_Anular_Factura sfanularFac = new SF_Anular_Factura();
            sfanularFac.MdiParent = this;
            sfanularFac.Show();
        }

        private void facturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SF_Compras sffaccompra = new SF_Compras();
            sffaccompra.MdiParent = this;
            sffaccompra.Show();
        }

        

    

       
    }
}
