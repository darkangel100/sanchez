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

        public List<Persona> Traeusuarios(string est)//trae todos los usuarios administrador o usuario
        {
            PersonaDB usu = null;
            List<Persona> ListaUsu = new List<Persona>();//crea la lista de los usuarios
            MySqlCommand cmd;//para ejecutar la base de datos 
            MySqlConnection cn = con.GetConnection();// conectar a la base de datos , obten la conexon
            try
            {
                // string sqlcad = "Select * from persona order by nom_usu";//cadena sql
                string sqlcad = "Select * from cuenta where est_cuen='" + est + "' order by nom_cuen";
                cmd = new MySqlCommand(sqlcad, cn);
                cmd.CommandType = CommandType.Text;
                cn.Open();// abre base de datos 
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())//permite leer los datos
                {
                    usu = new PersonaDB();
                    usu.getPersona().idper = int.Parse(dr[0].ToString());
                    usu.getPersona().cedper = dr[1].ToString();
                    usu.getPersona().apeper = dr[2].ToString();
                    usu.getPersona().nomper = dr[3].ToString();
                    usu.getPersona().dirper = dr[4].ToString();
                    usu.getPersona().telper = dr[5].ToString();
                    usu.getPersona().estper = dr[6].ToString();

                    usu.getPersona().Nombre = usu.getPersona().apeper + " " + usu.getPersona().nomper;
                    ListaUsu.Add(usu.getPersona());
                }
                dr.Close();
            }
            catch (MySqlException ex)
            {
                usu = null;
                throw ex;
            }
            catch (Exception ex)
            {
                usu = null;
                throw ex;
            }
            cn.Close();//cerras conexion
            cmd = null;//rompe el enlace y es basura
            return ListaUsu;// retorno a llenado datos
        }

        public Persona TraeUsuario(int ced)
        {
            PersonaDB per = null;
            MySqlCommand cmd;
            MySqlConnection cn = con.GetConnection();
            try
            {
                string sqlcad = "Select * from persona Where idPersona='" + ced + "'";
                cmd = new MySqlCommand(sqlcad, cn);
                cmd.CommandType = CommandType.Text;
                cn.Open();
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    per = new PersonaDB();
                    per.getPersona().idper = int.Parse(dr[0].ToString());
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
