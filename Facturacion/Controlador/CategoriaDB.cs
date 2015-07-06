using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Facturacion.Modelo;

namespace Facturacion.Controlador
{
    class CategoriaDB
    {
        conexion con = new conexion();
        Categoria cat = null;

        public Categoria getCategorias()
        {
            if (this.cat == null)
            {
                this.cat = new Categoria();
            }
            return this.cat;
        }
        public void setCategorias(Categoria cate)
        {
            this.cat = cate;
        }
        public void limpiar()
        {
            this.cat = null;
        }
        public int TraeCodigo()
        {
            int nro = 0; ;
            MySqlConnection cn = con.GetConnection();
            MySqlCommand cmd;
            try
            {
                string sqlcad = "Select max(SUBSTRING(idCat,1)) as nro from categoria";
                cmd = new MySqlCommand(sqlcad, cn);
                cn.Open();
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (DBNull.Value == dr["nro"])
                        nro = 0;
                    else
                        nro = Convert.ToInt32(dr["nro"]);
                }
                dr.Close();
            }
            catch (MySqlException ex)
            {
                nro = 0;
                throw ex;
            }
            catch (Exception ex)
            {
                nro = 0;
                throw ex;
            }
            cn.Close();
            cmd = null;
            return nro;
        }
         public int InsertaCategoria(Categoria cat)
        {
            MySqlCommand cmd;
            MySqlConnection cn = con.GetConnection();
            int resp;
            try
            {
                string sqlcad = "Insert categoria Values (" + cat.idcat + ",'" + cat.nomcat + "','" + cat.estcat + "')";
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
            cat = null;
            return resp;
        }
         public List<Categoria> TraeCategorias(string est)
         {
             CategoriaDB cat = null;
             List<Categoria> ListaCat = new List<Categoria>();
             MySqlCommand cmd;
             MySqlConnection cn = con.GetConnection();
             try
             {
                 string sqlcad = "Select * from categoria where est_cat='" + est + "' order by idCat";
                 cmd = new MySqlCommand(sqlcad, cn);
                 cmd.CommandType = CommandType.Text;
                 cn.Open();
                 MySqlDataReader dr = cmd.ExecuteReader();
                 while (dr.Read())
                 {
                     cat = new CategoriaDB();
                     cat.getCategorias().idcat=dr[0].ToString();
                     cat.getCategorias().nomcat = dr[1].ToString();
                     cat.getCategorias().estcat = dr[2].ToString();
                     ListaCat.Add(cat.getCategorias());
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
             return ListaCat;
         }
         public Categoria TraeCategoria(string cod)
         {
             CategoriaDB cat = null;
             MySqlCommand cmd;
             MySqlConnection cn = con.GetConnection();
             try
             {
                 string sqlcad = "Select * from categoria Where idCat='" + cod + "'";
                 cmd = new MySqlCommand(sqlcad, cn);
                 cmd.CommandType = CommandType.Text;
                 cn.Open();
                 MySqlDataReader dr = cmd.ExecuteReader();
                 while (dr.Read())
                 {
                     cat = new CategoriaDB(); 
                     cat.getCategorias().idcat = dr[0].ToString();
                     cat.getCategorias().nomcat = dr[1].ToString();
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
             return cat.getCategorias();
         }
         public int ActualizaCategoria(Categoria cat)
         {
             MySqlCommand cmd;
             MySqlConnection cn = con.GetConnection();
             int resp;
             try
             {
                 string sqlcad = "Update categoria set nom_cat='" +cat.nomcat  + "' WHERE idCat='" + cat.idcat + "'";
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
         public int DesactivarCategoria(string cod)
         {
             MySqlCommand cmd;
             MySqlConnection cn = con.GetConnection();
             int resp = 0;
             try
             {
                 string sqlcad = "Update categoria set est_cat='P' WHERE idCat='" + cod + "'";
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
         public int ActivarCategoria(string cod)
         {
             MySqlCommand cmd;
             MySqlConnection cn = con.GetConnection();
             int resp = 0;
             try
             {
                 string sqlcad = "Update categoria set est_cat='A' WHERE idCat='" + cod + "'";
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
