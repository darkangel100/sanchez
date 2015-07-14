                using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Facturacion.Modelo
{
    class Usuario:Persona
    {
        private string cla_cuent;

        public string clacuent
        {
            get { return cla_cuent; }
            set { cla_cuent = value; }
        }
        private Rol rol;

        
    }
}
