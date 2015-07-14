using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Facturacion.Modelo;
using MySql.Data.MySqlClient;
using System.Data;

namespace Facturacion.Controlador
{
    class RolDB
    {
        conexion con = new conexion();
        private Rol rol = null;

        public Rol getRol()
        {
            if (this.rol == null)
            {
                this.rol = new Rol();
            }
            return this.rol;
        }
        public void setRol(Rol rol)
        {
            this.rol = rol;
        }



        public int generarId()
        {
            int id = 1;
            if (id > 0)
            {
                id += 1;
            }
            return id;
        }
        public void crearNuevosRoles()
        {

            Rol r3 = new Rol();
            r3.nomrol = "Cliente";
            r3.idrol = 0;
            InsertaRol(r3);
            Rol r2 = new Rol();
            r2.nomrol = "Vendedor";
            r2.idrol = 1;
            InsertaRol(r2);
            Rol r1 = new Rol();
            r1.nomrol = "Gerente";
            r1.idrol = 2;
            InsertaRol(r1);

            Rol r4 = new Rol();
            r4.nomrol = "proveedor";
            r4.idrol = 3;
            InsertaRol(r4);
        }
        public int InsertaRol(Rol rol)
        {
            MySqlCommand cmd;
            MySqlConnection cn = con.GetConnection();
            int resp;
            try
            {
                string sqlcad = "Insert rol Values ('" + rol.idrol + "','" + rol.nomrol + "')";
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

            cn.Close();
            cmd = null;
            rol = null;
            return resp;
        }
        public List<Rol> TraeRol()
        {
            RolDB cat = null;
            List<Rol> ListaRol = new List<Rol>();
            MySqlCommand cmd;
            MySqlConnection cn = con.GetConnection();
            try
            {
                string sqlcad = "Select * from rol where idRol=1||idRol=2 order by nom_rol";
                cmd = new MySqlCommand(sqlcad, cn);
                cmd.CommandType = CommandType.Text;
                cn.Open();
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cat = new RolDB();
                    cat.getRol().idrol = Convert.ToInt32(dr[0].ToString());
                    cat.getRol().nomrol = dr[1].ToString();
                    ListaRol.Add(cat.getRol());
                }
                dr.Close();
            }
            catch (MySqlException ex)
            {
                cat = null;
                throw ex;
            }
            catch (Exception ex)
            {
                cat = null;
                throw ex;
            }
            cn.Close();
            cmd = null;
            return ListaRol;
        }
    }
}
