using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Facturacion.Controlador
{
    class Util
    {
        //medoto para borrar los campos
        #region
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
        #endregion
        //metodo para generar el codigo
        #region
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
        #endregion
        //metodo para girar la fecha
        #region
        public static string girafecha(String f)
        {
            String fec = "";
            fec = f.Substring(6, 4) + "-" + f.Substring(3, 2) + "-" + f.Substring(0, 2);
            return fec;
        }
        #endregion
        //validacion de numeros y pasar el foco a un textbox
        #region
        public void validarnum(TextBox tx, KeyPressEventArgs e, TextBox tx1)
        {
            char letra = e.KeyChar;
            if (!char.IsDigit(letra) & letra != 8 & letra != 13)
            {
                e.Handled = true;
                MessageBox.Show("ingrese solo numeros");
            }

            if (letra == 13)
            {
                if (tx.Text == "")
                {
                    MessageBox.Show("no ha ingresado ningun numero");
                    tx.Focus();
                }
                else
                {
                    tx1.Focus();
                }

            }
        }
        #endregion
        //validar numero y pasar el foco aun boton
        #region
        public void validarnum(TextBox tx, KeyPressEventArgs e, Button btn)
        {
            char letra = e.KeyChar;
            if (!char.IsDigit(letra) & letra != 8 & letra != 13)
            {
                e.Handled = true;
                MessageBox.Show("ingrese solo numeros");
            }

            if (letra == 13)
            {
                if (tx.Text == "")
                {
                    MessageBox.Show("no ha ingresado ningun numero");
                    tx.Focus();
                }
                else
                {
                    btn.Focus();
                }

            }
        }
        #endregion
        //validacion de letras y pasar el foco a un textbox
        #region
        public void validarletras(TextBox tx, KeyPressEventArgs e, TextBox tx1)
        {
            char letra = e.KeyChar;
            if (!char.IsLetter(letra) & letra != 8 & letra != 13)
            {
                e.Handled = true;
                MessageBox.Show("ingrese solo letras");
            }

            if (letra == 13)
            {
                if (tx.Text == "")
                {
                    MessageBox.Show("no ha ingresado ningun dato");
                    tx.Focus();
                }
                else
                {
                    tx1.Focus();
                }

            }
        }
        #endregion
        #region
         public void espacio(MaskedTextBox tx, KeyPressEventArgs e, TextBox tx1)
        {
            char letra = e.KeyChar;
            if (!char.IsDigit(letra) & letra != 8 & letra != 13)
            {
                e.Handled = true;
                MessageBox.Show("ingrese solo numeros");
            }

            if (letra == 13)
            {
                if (String.IsNullOrEmpty(tx.Text))
                {
                    MessageBox.Show("asdasd");
                }
                else
                {
                    tx1.Focus();
                }

            }
        }
      
        #endregion
    }
}
