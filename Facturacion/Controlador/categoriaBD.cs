using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data;
using Facturacion.Modelo;
using MySql.Data.MySqlClient;
using System.Data;

using System.Windows.Forms;


namespace Facturacion.Controlador
{
    class categoriaBD
    {
        conexion con = new conexion();
        Categoria categ = null;

        public Categoria getCategoria()
        {
            if (this.categ == null)
            {
                this.categ = new Categoria();
                
            }
            return this.categ;
        }
        public void setCategoria(Categoria cates)
        {
            this.categ = cates;
        }
        public void limpiar()
        {
            this.categ = null;
        }
        public int InsertaCategoria(Categoria categ)
        {

            MySqlCommand cmd;
            MySqlConnection cn = con.GetConnection();
            int resp;
            try
            {
                string sqlcad = "Insert Categoria Values('" + categ.idcategoria + "','"+ categ.nomcat +"','"+categ.estcat +"')";
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
            categ = null;
            return resp;
        }
        public List<Categoria> TraeCategorias()
        {
            categoriaBD categ = null;
            List<Categoria> Listacateg = new List<Categoria>();
            MySqlCommand cmd;
            MySqlConnection cn = con.GetConnection();

            try
            {
                string sqlcad = "Select * from categoria order by nom_cat";
                cmd = new MySqlCommand(sqlcad, cn);
                cmd.CommandType = CommandType.Text;
                cn.Open();
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    categ = new categoriaBD();
                    categ.getCategoria().idcategoria = dr[0].ToString();
                    categ.getCategoria().nomcat = dr[1].ToString();
                    categ.getCategoria().estcat = dr[2].ToString();
                    categ.getCategoria().Nombre = categ.getCategoria().nomcat + " " + categ.getCategoria().idcategoria; ;
                    Listacateg.Add(categ.getCategoria());
                }
                dr.Close();
            }
            catch (MySqlException ex)
            {
                categ = null;
                throw ex;
            }
            catch (Exception ex)
            {
                categ = null;
                throw ex;
            }
            cn.Close();
            cmd = null;
            return Listacateg;
        }
        public Categoria TraeCategoria(string idca)
        {
            categoriaBD categ = null;
            MySqlCommand cmd;
            MySqlConnection cn = con.GetConnection();
            try
            {
                string sqlcad = "Select * from categoria where idcategoria='" + idca + "'";
                cmd = new MySqlCommand(sqlcad, cn);
                cmd.CommandType = CommandType.Text;
                cn.Open();
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    categ = new categoriaBD();
                   categ.getCategoria().idcategoria = dr[0].ToString();
                   categ.getCategoria().nomcat = dr[1].ToString();
                   categ.getCategoria().estcat = dr[2].ToString();

                }
                dr.Close();
            }
            catch (MySqlException ex)
            {
                categ = null;
                throw ex;
            }
            catch (Exception ex)
            {
                categ = null;
                throw ex;
            }
            cn.Close();
            cmd = null;
            return categ.getCategoria();
        }
        public int ActualizaCategoria(Categoria categ)
        {
            MySqlCommand cmd;
            MySqlConnection cn = con.GetConnection();
            int resp;
            try
            {
                string sqlcad = "Update categoria set nom_cat='" + categ.nomcat + "',est_per='" + categ.estcat + "' WHERE ced_per='" + categ.idcategoria + "'";
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
