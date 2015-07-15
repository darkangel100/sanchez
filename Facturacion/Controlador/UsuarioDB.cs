using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Facturacion.Modelo;
using System.Data;

namespace Facturacion.Controlador
{
    class UsuarioDB
    {
        conexion con = new conexion();



        private Persona usuario = null;

        public Persona getUsuario()
        {
            if (this.usuario == null)
            {
                this.usuario = new Persona();
            }
            return this.usuario;
        }
        public void setUsuario(Persona usuario)
        {
            this.usuario = usuario;
        }
        public List<Persona> TraeUsuarios(string est)
        {
            PersonaDB per = null;
            List<Persona> ListaUsu = new List<Persona>();
            MySqlCommand cmd;
            MySqlConnection cn = con.GetConnection();
            try
            {
                string sqlcad = " select * from persona where idRol=1 || idRol=2 and est_per= '" + est + "'";
                cmd = new MySqlCommand(sqlcad, cn);
                cmd.CommandType = CommandType.Text;
                cn.Open();
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    per = new PersonaDB();
                    per.getPersona().cedper = dr[1].ToString();
                    per.getPersona().apeper = dr[2].ToString();
                    per.getPersona().nomper = dr[3].ToString();
                    per.getPersona().dirper = dr[4].ToString();
                    per.getPersona().telper = dr[5].ToString();
                    per.getPersona().estper = dr[6].ToString();
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


        public Persona TraeUsuario(string ced)
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
                    per.getPersona().cedper = dr[1].ToString();
                    per.getPersona().apeper = dr[2].ToString();
                    per.getPersona().nomper = dr[3].ToString();
                    per.getPersona().dirper = dr[4].ToString();
                    per.getPersona().telper = dr[5].ToString();
                    per.getPersona().estper = dr[6].ToString();
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
    }
}
