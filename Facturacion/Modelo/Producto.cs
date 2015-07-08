using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Facturacion.Modelo
{
    class Producto
    {
        private string id_pro;
        private string id_cat;
        private string nom_pro;
        private double pre_com;
        private int can_pro;
        private double por_gan;
        private double pre_gan;
        private string iva_sn;
        private double pre_ven;
        private string fec_ing;
        private List<Producto> listaProductos = new List<Producto>();

        public string idpro
        {
            get { return id_pro; }
            set { id_pro = value; }
        }
        public string idcat
        {
            get { return id_cat; }
            set { id_cat = value; }
        }
        public string nompro
        {
            get { return nom_pro; }
            set { nom_pro = value; }
        }
        public double precom
        {
            get { return pre_com; }
            set { pre_com = value; }
        }
        public int canpro
        {
            get { return can_pro; }
            set { can_pro = value; }
        }
        public double porgan
        {
            get { return por_gan; }
            set { por_gan = value; }
        }
        public double pregan
        {
            get { return pre_gan; }
            set { pre_gan = value; }
        }
        public string ivasn
        {
            get { return iva_sn; }
            set { iva_sn = value; }
        }
        public double preven
        {
            get { return pre_ven; }
            set { pre_ven = value; }
        }
        public string fecing
        {
            get { return fec_ing; }
            set { fec_ing = value; }
        }
        public List<Producto> ListaProductos
        {
            get { return listaProductos; }
            set { listaProductos = value; }
        }
        private string est_pro;

        public string estpro
        {
            get { return est_pro; }
            set { est_pro = value; }
        }
        
    }
}
