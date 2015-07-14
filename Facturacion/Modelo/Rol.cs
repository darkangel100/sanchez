using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Facturacion.Modelo
{
    class Rol
    {
        private int id_rol;

        public int idrol
        {
            get { return id_rol; }
            set { id_rol = value; }
        }

        private string nom_rol;

        public string nomrol
        {
            get { return nom_rol; }
            set { nom_rol = value; }
        }

        private List<Rol> lista_Rol = new List<Rol>();

        public List<Rol> ListaRol
        {
            get { return lista_Rol; }
            set { lista_Rol = value; }
        }
    }  
}
