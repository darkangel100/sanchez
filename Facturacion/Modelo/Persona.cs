using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Facturacion.Modelo
{
    class Persona
    {
        private int id_per;

        public int idper
        {
            get { return id_per; }
            set { id_per = value; }
        }
        
        private string ced_per;

        public string cedper
        {
            get { return ced_per; }
            set { ced_per = value; }
        }

        private string ape_per;

        public string apeper
        {
            get { return ape_per; }
            set { ape_per = value; }
        }

        private string nom_per;

        public string nomper
        {
            get { return nom_per; }
            set { nom_per = value; }
        }

        private string dir_per;

        public string dirper
        {
            get { return dir_per; }
            set { dir_per = value; }
        }

        private string tel_per;

        public string telper
        {
            get { return tel_per; }
            set { tel_per = value; }
        }

        private string est_per;

        public string estper
        {
            get { return est_per; }
            set { est_per = value; }
        }

        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private int id_rol;

        public int idrol
        {
            get { return id_rol; }
            set { id_rol = value; }
        }

        private Cuenta cuenta;

        public Cuenta Cuenta
        {
            get { return cuenta; }
            set { cuenta = value; }
        }

        private Rol rol;

        public Rol Rol
        {
            get { return rol; }
            set { rol = value; }
        }

        private Proveedor proveedor;

        public Proveedor Proveedor
        {
            get { return proveedor; }
            set { proveedor = value; }
        }

        private List<Persona> listaPersonas = new List<Persona>();

        public List<Persona> ListaPersonas
        {
            get { return listaPersonas; }
            set { listaPersonas = value; }
        }
    }
}
