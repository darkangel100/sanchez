using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Facturacion.Modelo
{
    class Persona
    {
        private string ced_per;
        private string ape_per;
        private string nom_per;
        private string dir_per;
        private string tel_per;
        private string est_per;
        private List<Persona> listaPersonas = new List<Persona>();
        private string nombre;

        private Cuenta cuenta;

        public string cedper
        {
            get { return ced_per; }
            set { ced_per = value; }
        }
        public string apeper
        {
            get { return ape_per; }
            set { ape_per = value; }
        }
        public string nomper
        {
            get { return nom_per; }
            set { nom_per = value; }
        }
        public string dirper
        {
            get { return dir_per; }
            set { dir_per = value; }
        }
        public string telper
        {
            get { return tel_per; }
            set { tel_per = value; }
        }
        public string estper
        {
            get { return est_per; }
            set { est_per = value; }
        }
        public List<Persona> ListaPersonas
        {
            get { return listaPersonas; }
            set { listaPersonas = value; }
        }
        public Cuenta Cuenta
        {
            get { return cuenta; }
            set { cuenta = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
    }
}
