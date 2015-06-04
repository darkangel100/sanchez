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
    public partial class SF_Acceso : Form
    {
        public SF_Acceso()
        {
            InitializeComponent();
        }

        private void btnacpertar_Click(object sender, EventArgs e)
        {
            SF_Principal sfpri = new SF_Principal();
            sfpri.Show();
           
            
        }
    }
}
