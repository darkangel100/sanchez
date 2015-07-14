using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Facturacion.Modelo;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;

namespace Facturacion.Controlador
{
    class CuentaDB
    {
        conexion con = new conexion();
        Cuenta cuenta = null;
        public Cuenta getCuenta()
        {
            if (this.cuenta == null)
            {
                this.cuenta = new Cuenta();
            }
            return this.cuenta;
        }
        public void setCuenta(Cuenta cuenta1)
        {
            this.cuenta = cuenta1;
        }
        public Cuenta iniciarSesion(string user, string passw)
        {
            Cuenta c = null;

            return c;
        }
        public int ingresacuenta(Cuenta cuen)
        {
            int resp;
            MySqlCommand cmd;
            MySqlConnection cnn = con.GetConnection();
            try
            {

                string comandoSql = "Insert cuenta set idPersona='" + cuen.idperCuen + "', nom_cuen='" + cuen.nomcuen + "', clave='" + cuen.Clave + "',est_cuen='" + cuen.estcuen + "'";

                cmd = new MySqlCommand(comandoSql, cnn);
                cmd.CommandType = CommandType.Text;
                cnn.Open();
                resp = cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                resp = 0;
                throw ex;
            }
            catch (Exception ex)
            {
                resp = 0;
                throw ex;
            }
            cmd = null;
            cnn.Close();
            return resp;

        }

        public int cuentaE()
        {
            MySqlCommand cmd;
            MySqlConnection cn = con.GetConnection();
            string commandLine = "SELECT COUNT(*) FROM cuenta";
            cmd = new MySqlCommand(commandLine, cn);
            cmd.CommandType = CommandType.Text;
            cn.Open();
            return Convert.ToInt32(cmd.ExecuteScalar());

        }
        public Cuenta TraeContra(string ced)
        {
            CuentaDB per = null;
            MySqlCommand cmd;
            MySqlConnection cn = con.GetConnection();
            try
            {
                string sqlcad = "Select * from cuenta Where nom_cuen='" + ced + "'";
                cmd = new MySqlCommand(sqlcad, cn);
                cmd.CommandType = CommandType.Text;
                cn.Open();
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    per = new CuentaDB();
                    per.getCuenta().nomcuen = dr[2].ToString();
                    per.getCuenta().Clave = dr[3].ToString();


                }
                dr.Close();
            }
            catch (MySqlException ex)
            {
                per = null;
                throw ex;
            }
            catch (Exception ex)
            {
                per = null;
                throw ex;
            }
            cn.Close();
            cmd = null;
            return per.getCuenta();
        }
        public Cuenta Traecuenta(string ced)
        {
            CuentaDB per = null;
            MySqlCommand cmd;
            MySqlConnection cn = con.GetConnection();
            try
            {
                string sqlcad = "Select * from cuenta Where idPersona='" + ced + "'";
                cmd = new MySqlCommand(sqlcad, cn);
                cmd.CommandType = CommandType.Text;
                cn.Open();
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    per = new CuentaDB();
                    per.getCuenta().nomcuen = dr[2].ToString();
                    per.getCuenta().Clave = dr[3].ToString();


                }
                dr.Close();
            }
            catch (MySqlException ex)
            {
                per = null;
                throw ex;
            }
            catch (Exception ex)
            {
                per = null;
                throw ex;
            }
            cn.Close();
            cmd = null;
            return per.getCuenta();
        }
        public int llenacuenta(Cuenta cuen)
        {

            MySqlCommand cmd;
            MySqlConnection cn = con.GetConnection();
            int resp;
            try
            {
                string sqlcad = "Insert cuenta set idPersona='" + cuen.Persona.idper + "', nom_cuen='" + cuen.nomcuen + "', clave='" + cuen.Clave + "',est_cuen='" + cuen.estcuen + "'";
                cmd = new MySqlCommand(sqlcad, cn);
                cn.Open();
                resp = cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                resp = 0;
                throw ex;
            }
            catch (Exception ex)
            {
                resp = 0;
                throw ex;
            }
            cn.Close();
            cmd = null;
            return resp;
        }
        public int ActualizaCuenta(Cuenta cuen)
        {
            MySqlCommand cmd;
            MySqlConnection cn = con.GetConnection();
            int resp;
            try
            {

                string sqlcad = "Update cuenta set nom_cuen='" + cuen.nomcuen + "',clave='" + cuen.Clave + "',est_cuen='" + cuen.estcuen + "' WHERE idPersona='" + cuen.idperCuen + "'";
                cmd = new MySqlCommand(sqlcad, cn);
                cmd.CommandType = CommandType.Text;
                cn.Open();
                resp = cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                resp = 0;
                throw ex;
            }
            catch (Exception ex)
            {
                resp = 0;
                throw ex;
            }
            cn.Close();
            cmd = null;
            return resp;
        }
    }
}
