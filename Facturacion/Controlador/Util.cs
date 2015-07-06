﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Facturacion.Controlador
{
    class Util
    {
        public static void limpiar(Control.ControlCollection cont)
        {
            foreach (Control c in cont)
            {
                if (c is TextBox)
                    c.Text = "";
                if (c is MaskedTextBox)
                    c.Text = "";
            }
        }
        public static string codi(string cod, int nro)
        {
            string num = cod;
            nro++;
            if (nro < 10)
                num += "000" + Convert.ToString(nro);
            else if (nro < 100)
                num += "00" + Convert.ToString(nro);
            else if (nro < 1000)
                num += "0" + Convert.ToString(nro);
            else
                num += Convert.ToString(nro);
            return num;
        }
        public static string girafecha(String f)
        {
            String fec = "";
            fec = f.Substring(6, 4) + "-" + f.Substring(3, 2) + "-" + f.Substring(0, 2);
            return fec;
        }
    }
}
