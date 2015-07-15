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
                // string sqlcad = "Insert Empresa Values ('" + emp.NombreEmpresa + "','" + emp.Direccion+ "','" + emp.Pais + "','" + emp.Telefono + "')";
                string comandoSql = "Insert empresa set nom_emp='" + emp.nomemp + "', dir_emp='" + emp.diremp + "', tel_emp='" + emp.telemp + "', est_emp='" + emp.estemp + "'";

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
        public int ActualizaEmpresa(Empresa emp)
        {
            MySqlCommand cmd;
            MySqlConnection cn = con.GetConnection();
            int resp;
            try
            {

                string sqlcad = "Update empresa set dir_emp='" + emp.diremp + "',tel_emp='" + emp.telemp + "',est_emp='" + emp.estemp +  "' WHERE nom_emp='" + emp.nomemp + "'";
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
        public List<Empresa> TraeEmpresas()
        {
            EmpresaDB emp = null;
            List<Empresa> Listaempresa = new List<Empresa>();
            MySqlCommand cmd;
            MySqlConnection cn = con.GetConnection();
            try
            {
                string sqlcad = "Select * from empresa  order by nom_emp";
                cmd = new MySqlCommand(sqlcad, cn);
                cmd.CommandType = CommandType.Text;
                cn.Open();
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    emp = new EmpresaDB();
                    emp.getEmpresa().idEmpresa = int.Parse(dr[0].ToString());
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

        public Empresa TraeEmpresa(string ced)
        {
            EmpresaDB emp = null;
            MySqlCommand cmd;
            MySqlConnection cn = con.GetConnection();
            try
            {
                string sqlcad = "Select * from empresa Where nom_emp='" + ced + "'";
                cmd = new MySqlCommand(sqlcad, cn);
                cmd.CommandType = CommandType.Text;
                cn.Open();
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    emp = new EmpresaDB();
                    emp.getEmpresa().idEmpresa = int.Parse(dr[0].ToString());
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
    }
}
