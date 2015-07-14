using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Facturacion.Modelo
{
    class Proveedor:Persona
    {
       
        private string id_Proveedor;

        public string idProveedor
        {
            get { return idProveedor; }
            set { idProveedor = value; }
        }

        private string id_empreProve;

        public string idempreProvee
        {
            get { return id_empreProve; }
            set { id_empreProve = value; }
        }
        private string est_provee;

        public string estprovee
        {
            get { return est_provee; }
            set { est_provee = value; }
        }
        private int id_perProvee;

        public int idperProvee
        {
            get { return id_perProvee; }
            set { id_perProvee = value; }
        }

        private List<Proveedor> lista_Proveedor=new List<Proveedor>();

        public List<Proveedor> listaProveedor
        {
            get { return lista_Proveedor; }
            set { lista_Proveedor = value; }
        }
        
        
        

    }
}
