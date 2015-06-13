using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data;

namespace Facturacion.Modelo
{
    class Categoria
    {
        private string nom_cat;
        private string idCategoria;
        private string est_cat;
        private List<Categoria> listaCategorias = new List<Categoria>();
        private string nombre;

        public string idcategoria
        {
            get { return idCategoria; }
            set { idCategoria = value; }
        }
        public string nomcat
        {
            get { return nom_cat; }
            set { nom_cat = value; }
        }
        public string estcat
        {
            get { return est_cat; }
            set { est_cat = value; }
        }
        public List<Categoria> ListaCategorias
        {
            get { return listaCategorias; }
            set { listaCategorias = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
    }
}
