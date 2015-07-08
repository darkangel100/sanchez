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
                string sqlcad = "Select max(SUBSTRING(idProd,3)) as nro from producto";
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
                string sqlcad = "Insert producto Values('" + pro.idpro + "','" + pro.idcat + "','" + pro.nompro + "','" + pro.precom + "','" + pro.canpro + "','" + pro.porgan + "','" + pro.pregan + "','" + pro.ivasn + "','" + pro.preven + "','" + pro.fecing + "','" + pro.estpro + "')";
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
        public List<Producto> Traeproductos(string est)
        {
            ProductoDB pro = null;
            List<Producto> ListaPro = new List<Producto>();
            MySqlCommand cmd;
            MySqlConnection cn = con.GetConnection();
            try
            {
                string sqlcad = "Select * from producto where est_pro='" + est + "' order by nom_prod";
                cmd = new MySqlCommand(sqlcad, cn);
                cmd.CommandType = CommandType.Text;
                cn.Open();
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    pro = new ProductoDB();
                    pro.getProductos().idpro = dr[0].ToString();
                    pro.getProductos().idcat = dr[1].ToString();
                    pro.getProductos().nompro = dr[2].ToString();
                    pro.getProductos().precom = Convert.ToDouble(dr[3].ToString());
                    pro.getProductos().canpro = Convert.ToInt32(dr[4].ToString());
                    pro.getProductos().porgan = Convert.ToDouble(dr[5].ToString());
                    pro.getProductos().pregan = Convert.ToDouble(dr[6].ToString());
                    pro.getProductos().ivasn = dr[7].ToString();
                    pro.getProductos().preven = Convert.ToDouble(dr[8].ToString());
                    pro.getProductos().fecing = dr[9].ToString();
                    pro.getProductos().estpro = dr[10].ToString();
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
        public int Actualizaproducto(Producto pro)
        {
            MySqlCommand cmd;
            MySqlConnection cn = con.GetConnection();
            int resp;
            try
            {
                string sqlcad = "Update producto set idCat='" + pro.idcat + "',nom_prod='" + pro.nompro + "',pre_com=" + pro.precom + ",stock_prod=" + pro.canpro + ",por_gan=" + pro.porgan + ",pre_gan=" + pro.pregan + ",iva_sn='" + pro.ivasn + "',pre_ven=" + pro.preven + ",fec_ing='" + pro.fecing + "',est_pro='" + pro.estpro + "' WHERE idProd='" + pro.idpro + "'";
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
        public Producto Traeproducto(string cod)
        {
            ProductoDB pro = null;
            MySqlCommand cmd;
            MySqlConnection cn = con.GetConnection();
            try
            {
                string sqlcad = "Select * from producto Where idProd='" + cod + "'";
                cmd = new MySqlCommand(sqlcad, cn);
                cmd.CommandType = CommandType.Text;
                cn.Open();
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    pro = new ProductoDB();
                    pro.getProductos().idpro = dr[0].ToString();
                    pro.getProductos().idcat = dr[1].ToString();
                    pro.getProductos().nompro = dr[2].ToString();
                    pro.getProductos().precom = Convert.ToDouble(dr[3].ToString());
                    pro.getProductos().canpro = Convert.ToInt32(dr[4].ToString());
                    pro.getProductos().porgan = Convert.ToDouble(dr[5].ToString());
                    pro.getProductos().pregan = Convert.ToDouble(dr[6].ToString());
                    pro.getProductos().ivasn = dr[7].ToString();
                    pro.getProductos().preven = Convert.ToDouble(dr[8].ToString());
                    pro.getProductos().fecing = dr[9].ToString();
                    pro.getProductos().estpro = dr[10].ToString();
                    
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
            return pro.getProductos();
        }
        public int DesactivarProducto(string idProd)
        {
            MySqlCommand cmd;
            MySqlConnection cn = con.GetConnection();
            int resp = 0;
            try
            {
                string sqlcad = "Update producto set est_pro='P' WHERE idProd='" + idProd + "'";
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
        public int ActivarProducto(string idProd)
        {
            MySqlCommand cmd;
            MySqlConnection cn = con.GetConnection();
            int resp = 0;
            try
            {
                string sqlcad = "Update producto set est_pro='A' WHERE idProd='" + idProd + "'";
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
