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
        Persona per = null;

        public Persona getPersona()
        {
            if (this.per == null)
            {
                this.per = new Persona();
                Cuenta login = new Cuenta();
                this.per.Cuenta = login;
            }
            return this.per;
        }
        public void setPersona(Persona pers)
        {
            this.per = pers;
        }
        public int InsertaCuenta(Persona per)
        {
            MySqlCommand cmd;
            MySqlConnection cn = con.GetConnection();
            int resp;
            try
            {
                string sqlcad = "Insert cuenta Values ('" + per.cedper + "','" + per.apeper + "','" + per.nomper + "','" + per.dirper + "','" + per.telper + "','" + per.estper + "','" + per.Cuenta.clacuent + "')";
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
            per = null;
            return resp;
        }
        public List<Persona> Traepersonas(string est)
        {
            CuentaDB per = null;
            List<Persona> ListaUsu = new List<Persona>();
            MySqlCommand cmd;
            MySqlConnection cn = con.GetConnection();
            try
            {
                string sqlcad = "Select * from cuenta where est_cuent='" + est + "' order by ape_cuent";
                cmd = new MySqlCommand(sqlcad, cn);
                cmd.CommandType = CommandType.Text;
                cn.Open();
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    per = new CuentaDB();
                    per.getPersona().cedper = dr[0].ToString();
                    per.getPersona().apeper = dr[1].ToString();
                    per.getPersona().nomper = dr[2].ToString();
                    per.getPersona().dirper = dr[3].ToString();
                    per.getPersona().telper = dr[4].ToString();
                    per.getPersona().estper = dr[5].ToString();
                    per.getPersona().Cuenta.clacuent = dr[6].ToString();
                    per.getPersona().Nombre = per.getPersona().apeper + " " + per.getPersona().nomper;
                    ListaUsu.Add(per.getPersona());
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
            return ListaUsu;
        }
        public Persona Traepersona(string ced)
        {
            CuentaDB per = null;
            MySqlCommand cmd;
            MySqlConnection cn = con.GetConnection();
            try
            {
                string sqlcad = "Select * from cuenta Where ced_cuent='" + ced + "'";
                cmd = new MySqlCommand(sqlcad, cn);
                cmd.CommandType = CommandType.Text;
                cn.Open();
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    per = new CuentaDB();
                    per.getPersona().cedper = dr[0].ToString();
                    per.getPersona().apeper = dr[1].ToString();
                    per.getPersona().nomper = dr[2].ToString();
                    per.getPersona().dirper = dr[3].ToString();
                    per.getPersona().telper = dr[4].ToString();
                    per.getPersona().estper = dr[5].ToString();
                    per.getPersona().Cuenta.clacuent = dr[6].ToString();

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
            return per.getPersona();
        }
        public int ActualizaCuenta(Persona per)
        {
            MySqlCommand cmd;
            MySqlConnection cn = con.GetConnection();
            int resp;
            try
            {
                string sqlcad = "Update cuenta set ape_cuent='" + per.apeper + "',nom_cuent='" + per.nomper + "',dir_cuent='" + per.dirper + "',tel_cuent='" + per.telper + "',est_cuent='" + per.estper + "',cla_cuent='" + per.Cuenta.clacuent + "' WHERE ced_cuent='" + per.cedper + "'";
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
       
      
        public int DesactivaCuenta(string ced)
        {
            MySqlCommand cmd;
            MySqlConnection cn = con.GetConnection();
            int resp = 0;
            try
            {
                string sqlcad = "Update cuenta set est_cuent='P' WHERE ced_cuent='" + ced + "'";
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
        public int ActivarCuenta(string ced)
        {
            MySqlCommand cmd;
            MySqlConnection cn = con.GetConnection();
            int resp = 0;
            try
            {
                string sqlcad = "Update cuenta set est_cuent='A' WHERE ced_cuent='" + ced + "'";
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
