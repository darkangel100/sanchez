using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Facturacion.Modelo
{
    class Proveedor:Persona
    {
        private string contacto_emp;

        public string ContactoEmp
        {
            get { return contacto_emp; }
            set { contacto_emp = value; }
        }

    }
}
