using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using Facturacion.Modelo;
using System.Data;


namespace Facturacion.Controlador
{
    class PersonaDB
    {
        conexion con = new conexion();
        Persona per = null;

        public Persona getPersona()
        {
            if (this.per == null)
            {
                this.per = new Persona();
            }
            return this.per;
        }
        public void setPersona(Persona pers)
        {
            this.per = pers;
        }
        public int InsertaPersona(Persona per)
        {
            MySqlCommand cmd;
            MySqlConnection cn = con.GetConnection();
            int resp;
            try
            {
                //string sqlcad = "Insert persona Values ('" + per.cedper + "','" + per.apeper + "','" + per.nomper + "','" + per.dirper + "','" + per.telper + "','" + per.estper + "'," + per.idrol + ")";
                string sqlcad = "Insert persona set ced_per='" + per.cedper + "', ape_per='" + per.apeper + "', nom_per='" + per.nomper + "', dir_per='" + per.dirper + "',tel_per='" + per.telper + "',est_per='" + per.estper + "',idRol=" + per.idrol + "";
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
        public List<Persona> TraePersonas(string est)
        {
            PersonaDB per = null;
            List<Persona> ListaCli = new List<Persona>();
            MySqlCommand cmd;
            MySqlConnection cn = con.GetConnection();
            try
            {
                string sqlcad = "Select * from persona where est_per='" + est + "' order by ape_per";
                cmd = new MySqlCommand(sqlcad, cn);
                cmd.CommandType = CommandType.Text;
                cn.Open();
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    per = new PersonaDB();
                    per.getPersona().cedper = dr[0].ToString();
                    per.getPersona().apeper = dr[1].ToString();
                    per.getPersona().nomper = dr[2].ToString();
                    per.getPersona().dirper = dr[3].ToString();
                    per.getPersona().telper = dr[4].ToString();
                    per.getPersona().estper = dr[5].ToString();

                    per.getPersona().Nombre = per.getPersona().apeper + " " + per.getPersona().nomper;
                    ListaCli.Add(per.getPersona());
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
            return ListaCli;
        }
        public Persona TraePersona(string ced)
        {
            PersonaDB per = null;
            MySqlCommand cmd;
            MySqlConnection cn = con.GetConnection();
            try
            {
                string sqlcad = "Select * from persona Where ced_per='" + ced + "'";
                cmd = new MySqlCommand(sqlcad, cn);
                cmd.CommandType = CommandType.Text;
                cn.Open();
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    per = new PersonaDB();
                    per.getPersona().cedper = dr[0].ToString();
                    per.getPersona().apeper = dr[1].ToString();
                    per.getPersona().nomper = dr[2].ToString();
                    per.getPersona().dirper = dr[3].ToString();
                    per.getPersona().telper = dr[4].ToString();
                    per.getPersona().estper = dr[5].ToString();
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
        public int ActualizaPersona(Persona per)
        {
            MySqlCommand cmd;
            MySqlConnection cn = con.GetConnection();
            int resp;
            try
            {

                string sqlcad = "Update persona set ape_per='" + per.apeper + "',nom_per='" + per.nomper + "',dir_per='" + per.dirper + "',tel_per='" + per.telper + "',est_per='" + per.estper + "' WHERE ced_per='" + per.cedper + "'";
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
        public int DesactivarPersona(string ced)
        {
            MySqlCommand cmd;
            MySqlConnection cn = con.GetConnection();
            int resp = 0;
            try
            {
                string sqlcad = "Update persona set est_per='P' WHERE ced_per='" + ced + "'";
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
        public int ActivarPersona(string ced)
        {
            MySqlCommand cmd;
            MySqlConnection cn = con.GetConnection();
            int resp = 0;
            try
            {
                string sqlcad = "Update persona set est_per='A' WHERE ced_per='" + ced + "'";
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
        public int traeIdRol(string nom)//trae id de rol
        {
            int num = 0;
            //RolDB r = null;
            MySqlCommand cmd;
            MySqlConnection cn = con.GetConnection();
            try
            {
                string sqlrol = "Select * from rol where nom_rol='" + nom + "'";
                cmd = new MySqlCommand(sqlrol, cn);
                cmd.CommandType = CommandType.Text;
                cn.Open();
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    num = Convert.ToInt32(dr["idRol"]);
                }

                dr.Close();
            }
            catch (MySqlException ex)
            {
                num = 0;
                throw ex;
            }
            catch (Exception ex)
            {
                num = 0;
                throw ex;
            }
            cn.Close();
            cmd = null;
            return num;
        }
        public string traenumero()
        {
            MySqlConnection cn = con.GetConnection();
            MySqlCommand cmd;
            string num = "";
            try
            {
                string Sqlcad = "Select max(idPersona)as num from persona";
                cmd = new MySqlCommand(Sqlcad, cn);
                cn.Open();
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    num = dr["num"].ToString();
                }
                dr.Close();
            }
            catch (MySqlException ex)
            {
                num = "";
                throw ex;
            }
            catch (Exception ex)
            {
                num = "";
                throw ex;
            }
            cn.Close();
            cmd = null;
            return num;
        }//trae numrero
    }
}
