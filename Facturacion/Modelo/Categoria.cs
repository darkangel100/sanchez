using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data;

namespace Facturacion.Modelo
{
    class Categoria
    {
        private string id_cat;
        private string nom_cat;
        private List<Categoria> listaCategorias = new List<Categoria>();

        public string idcat
        {
            get { return id_cat; }
            set { id_cat = value; }
        }
        public string nomcat
        {
            get { return nom_cat; }
            set { nom_cat = value; }
        }
        public List<Categoria> ListaCategorias
        {
            get { return listaCategorias; }
            set { listaCategorias = value; }
        }
        private string est_cat;

        public string estcat
        {
            get { return est_cat; }
            set { est_cat = value; }
        }
        
    }
}
