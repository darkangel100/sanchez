using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Facturacion.Modelo
{
    class Empresa
    {
        private string id_Empesa;

        public string idEmpresa
        {
            get { return id_Empesa; }
            set { id_Empesa = value; }
        }
        private string nom_emp;

        public string nomemp
        {
            get { return nom_emp; }
            set { nom_emp = value; }
        }
        private string dir_emp;

        public string diremp
        {
            get { return dir_emp; }
            set { dir_emp = value; }
        }
        private string tel_emp;

        public string telemp
        {
            get { return tel_emp; }
            set { tel_emp = value; }
        }
        private string est_emp;

        public string estemp
        {
            get { return est_emp; }
            set { est_emp = value; }
        }

        private List<Empresa> listaEmpresas = new List<Empresa>();

        public List<Empresa> ListaEmpresas
        {
            get { return listaEmpresas; }
            set { listaEmpresas = value; }
        }
    }
}
