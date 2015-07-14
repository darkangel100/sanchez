using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Facturacion.Modelo;
using MySql.Data.MySqlClient;
using System.Data;

namespace Facturacion.Controlador
{
    class EmpresaDB
    {
        conexion con = new conexion();
        Empresa empre = null;

        public Empresa getEmpresa()
        {
            if (this.empre == null)
            {
                this.empre = new Empresa();
            }
            return this.empre;
        }
        public void setEmpresa(Empresa empres)
        {
            this.empre = empres;
        }
        public void limpiar()
        {
            this.empre = null;
        }
        public int InsertaEmpresa(Empresa emp)
        {
            MySqlCommand cmd;
            MySqlConnection cn = con.GetConnection();
            int resp;
            try
            {
                string comandoSql = "Insert Empresa Values ('" + emp.idEmpresa + "','" + emp.nomemp + "','" + emp.diremp + "','" + emp.telemp + "','" + emp.estemp + "')";
                //string comandoSql = "Insert empresa set nombre_empresa='" + emp.NombreEmpresa + "', direccion='" + emp.Direccion + "', pais='" + emp.Pais + "', telefono='" + emp.Telefono + "'";

                cmd = new MySqlCommand(comandoSql, cn);
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
            emp = null;
            return resp;
        }
        public List<Empresa> TraeEmpresas(string est)
        {
            EmpresaDB emp = null;
            List<Empresa> Listaempresa = new List<Empresa>();
            MySqlCommand cmd;
            MySqlConnection cn = con.GetConnection();
            try
            {
                string sqlcad = "Select * from empresa where est_emp='" + est + "' order by nom_emp";
                cmd = new MySqlCommand(sqlcad, cn);
                cmd.CommandType = CommandType.Text;
                cn.Open();
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    emp = new EmpresaDB();
                    emp.getEmpresa().idEmpresa = dr[0].ToString();
                    emp.getEmpresa().nomemp = dr[1].ToString();
                    emp.getEmpresa().diremp = dr[2].ToString();
                    emp.getEmpresa().telemp = dr[3].ToString();
                    emp.getEmpresa().estemp = dr[4].ToString();
                    Listaempresa.Add(emp.getEmpresa());
                }
                dr.Close();
            }
            catch (MySqlException ex)
            {
                emp = null;
                throw ex;
            }
            catch (Exception ex)
            {
                emp = null;
                throw ex;
            }
            cn.Close();
            cmd = null;
            return Listaempresa;
        }
        public int ActivarEmpresa(string ruc)
        {
            MySqlCommand cmd;
            MySqlConnection cn = con.GetConnection();
            int resp = 0;
            try
            {
                string sqlcad = "Update empresa set est_emp='A' WHERE idEmpresa='" + ruc + "'";
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
        public int DesactivarEmpresa(string ruc)
        {
            MySqlCommand cmd;
            MySqlConnection cn = con.GetConnection();
            int resp = 0;
            try
            {
                string sqlcad = "Update empresa set est_emp='P' WHERE idEmpresa='" + ruc + "'";
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
        public Empresa TraeEmpresa(string ruc)
        {
            EmpresaDB emp = null;
            MySqlCommand cmd;
            MySqlConnection cn = con.GetConnection();
            try
            {
                string sqlcad = "Select * from empresa Where idEmpresa='" + ruc + "'";
                cmd = new MySqlCommand(sqlcad, cn);
                cmd.CommandType = CommandType.Text;
                cn.Open();
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    emp = new EmpresaDB();
                    emp.getEmpresa().idEmpresa = dr[0].ToString();
                    emp.getEmpresa().nomemp = dr[1].ToString();
                    emp.getEmpresa().diremp = dr[2].ToString();
                    emp.getEmpresa().telemp = dr[3].ToString();
                    emp.getEmpresa().estemp = dr[4].ToString();
    
                }
                dr.Close();
            }
            catch (MySqlException ex)
            {
                emp = null;
                throw ex;
            }
            catch (Exception ex)
            {
                emp = null;
                throw ex;
            }
            cn.Close();
            cmd = null;
            return emp.getEmpresa();
        }
        public int ActualizaEmpreza(Empresa per)
        {
            MySqlCommand cmd;
            MySqlConnection cn = con.GetConnection();
            int resp;
            try
            {

                string sqlcad = "Update empresa set nom_emp='" + per.nomemp + "',dir_emp='" + per.diremp + "',tel_emp='" + per.telemp + "',est_emp='" + per.estemp + "' WHERE idEmpresa='" + per.idEmpresa + "'";
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
