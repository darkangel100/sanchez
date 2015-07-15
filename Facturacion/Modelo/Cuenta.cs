using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Facturacion.Modelo
{
    class Cuenta: Persona
    {
        private int id_cuenta;

        public int idcuenta
        {
            get { return id_cuenta; }
            set { id_cuenta = value; }
        }

        private string nom_cuen;

        public string nomcuen
        {
            get { return nom_cuen; }
            set { nom_cuen = value; }
        }
        private string clave;

        public string Clave
        {
            get { return clave; }
            set { clave = value; }
        }
        private Persona persona;

        public Persona Persona
        {
            get { return persona; }
            set { persona = value; }
        }

        private DateTime ultimo_acesos;

        public DateTime ultimoacceso
        {
            get { return ultimo_acesos; }
            set { ultimo_acesos = value; }
        }

        private string est_cuen;

        public string estcuen
        {
            get { return est_cuen; }
            set { est_cuen = value; }
        }

        private int id_perCuen;

        public int idperCuen
        {
            get { return id_perCuen; }
            set { id_perCuen = value; }
        }


        private List<Cuenta> lista_cuentas= new List<Cuenta>();

        public List<Cuenta> listaCuentas
        {
            get { return lista_cuentas; }
            set { lista_cuentas = value; }
        }
        


        

     
        



      
       
    }
}
