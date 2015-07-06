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
    class ProductoDB
    {
        conexion con = new conexion();
        Producto pro = null;

        public Producto getProductos()
        {
            if (this.pro == null)
            {
                this.pro = new Producto();
            }
            return this.pro;
        }
        public void setProductos(Producto prod)
        {
            this.pro = prod;
        }
        public void limpiar()
        {
            this.pro = null;
        }
        public int TraeCodigo()
        {
            int nro = 0; ;
            MySqlConnection cn = con.GetConnection();
            MySqlCommand cmd;
            try
            {
                string sqlcad = "Select max(SUBSTRING(idProd,1)) as nro from producto";
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
        public int Insertaproducto(Producto pro)
        {
            MySqlCommand cmd;
            MySqlConnection cn = con.GetConnection();
            int resp;
            try
            {
                string sqlcad = "Insert producto Values('" + pro.codpro + "','" + pro.codcat + "','" + pro.nompro + "','" + pro.precom + "','" + pro.canpro + "','" + pro.porgan + "','" + pro.pregan + "','" + pro.ivasn + "','" + pro.preven + "','" + pro.fecela + "')";
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
            pro = null;
            return resp;
        }
        public List<Producto> Traeproductos(string cat)
        {
            ProductoDB pro = null;
            List<Producto> ListaPro = new List<Producto>();
            MySqlCommand cmd;
            MySqlConnection cn = con.GetConnection();
            try
            {
                string sqlcad = "Select * from Producto where idCat='" + cat + "' order by nom_prod";
                cmd = new MySqlCommand(sqlcad, cn);
                cmd.CommandType = CommandType.Text;
                cn.Open();
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    pro = new ProductoDB();
                    pro.getProductos().codpro = dr[0].ToString();
                    pro.getProductos().codcat = dr[1].ToString();
                    pro.getProductos().nompro = dr[2].ToString();
                    pro.getProductos().precom = Convert.ToDouble(dr[3].ToString());
                    pro.getProductos().canpro = Convert.ToInt32(dr[4].ToString());
                    pro.getProductos().porgan = Convert.ToDouble(dr[5].ToString());
                    pro.getProductos().pregan = Convert.ToDouble(dr[6].ToString());
                    pro.getProductos().ivasn = dr[7].ToString();
                    pro.getProductos().preven = Convert.ToDouble(dr[8].ToString());
                    pro.getProductos().fecela = dr[9].ToString();
                    ListaPro.Add(pro.getProductos());
                }
                dr.Close();
            }
            catch (MySqlException ex)
            {
                pro = null;
                throw ex;
            }
            catch (Exception ex)
            {
                pro = null;
                throw ex;
            }
            cn.Close();
            cmd = null;
            return ListaPro;
        }
    }
}
