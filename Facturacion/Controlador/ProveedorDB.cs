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
    class ProveedorDB
    {
        conexion con = new conexion();

        Proveedor proveedor = null;

        public Proveedor getProveedor()
        {
            if (this.proveedor == null)
            {
                this.proveedor = new Proveedor();
            }
            return this.proveedor;
        }
        public void setProveedor(Proveedor proveedors)
        {
            this.proveedor = proveedors;
        }
        public int traeId(string nom)
        {
            int num = 0;
            //RolDB r = null;
            MySqlCommand cmd;
            MySqlConnection cn = con.GetConnection();
            try
            {
                string sqlrol = "Select * from proveedor where idPersona='" + nom + "'";
                cmd = new MySqlCommand(sqlrol, cn);
                cmd.CommandType = CommandType.Text;
                cn.Open();
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    num = Convert.ToInt32(dr["idPersona"]);
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

        public int traeidEmpresa(string nom)
        {
            int num = 0;
            //RolDB r = null;
            MySqlCommand cmd;
            MySqlConnection cn = con.GetConnection();
            try
            {
                string sqlrol = "Select * from empresa where nom_emp='" + nom + "'";
                cmd = new MySqlCommand(sqlrol, cn);
                cmd.CommandType = CommandType.Text;
                cn.Open();
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    num = Convert.ToInt32(dr["idEmpresa"]);
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


        public int Actualizaprovedor(Proveedor per)//metodo para modificar Cliente
        {
            MySqlCommand cmd;
            MySqlConnection cn = con.GetConnection();
            int resp;
            try
            {

                string sqlcad = "Update proveedor set idEmpresa='" + per.idempreProvee + "' WHERE idPersona='" + per.idperProvee + "'";
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

        public int InsertaProveedor(Proveedor per)
        {
            MySqlCommand cmd;
            MySqlConnection cn = con.GetConnection();
            int resp;
            try
            {
                string sqlcad = "Insert proveedor set  idPersona='" + per.idperProvee + "', idEmpresa='" + per.idempreProvee + "',ruc_provee='" + per.RucProveedor + "',est_provee='" + per.estprovee + "'";
                // string sqlcad = "Insert proveedor Values ('" + per.Ruc + "','" + per.Id_persona + "','" + per.IdEmpresa+  "')";
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
     
    }
}
