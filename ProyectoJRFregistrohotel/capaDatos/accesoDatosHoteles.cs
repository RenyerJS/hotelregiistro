using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using capaEntidades;

namespace capaDatos
{
    public class accesoDatosHoteles
    {
        SqlConnection cnx;
        Hoteles ht = new Hoteles();
        Conexion cn = new Conexion();
        SqlCommand cm = null;
        int indicador = 0;
        SqlDataReader dr = null;
        List<Hoteles> listaHotel = null;

        public int insertarHotel(Hoteles ht)
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("nuevoHotel", cnx);
                cm.Parameters.AddWithValue("@b", 1);
                cm.Parameters.AddWithValue("@Codigo", "");
                cm.Parameters.AddWithValue("@Nombre", ht.Nombre);
                cm.Parameters.AddWithValue("@Direccion", ht.Direccion);
                cm.Parameters.AddWithValue("@Categoria", ht.Categoria);


                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                cm.ExecuteNonQuery();
                indicador = 1;
            }
            catch (Exception e)
            {
                e.Message.ToString();
                indicador = 0;
            }
            finally { cm.Connection.Close(); }
            return indicador;
        }

        public int EditarHotel(Hoteles ht)
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("nuevoHotel", cnx);
                cm.Parameters.AddWithValue("@b", 3);
                cm.Parameters.AddWithValue("@Codigo", "");
                cm.Parameters.AddWithValue("@Nombre", ht.Nombre);
                cm.Parameters.AddWithValue("@Direccion", ht.Direccion);
                cm.Parameters.AddWithValue("@Categoria", ht.Categoria);

                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                cm.ExecuteNonQuery();
                indicador = 1;
            }
            catch (Exception e)
            {
                e.Message.ToString();
                indicador = 0;
            }
            finally { cm.Connection.Close(); }
            return indicador;
        }

        public List<Hoteles> BuscaHotelesDatos(String dato)
        {

            try
            {
                SqlConnection cnx = cn.conectar();
                cm = new SqlCommand("nuevoHotel", cnx);
                cm.Parameters.AddWithValue("@b", 6);
                cm.Parameters.AddWithValue("@Codigo", "");
                cm.Parameters.AddWithValue("@Nombre", dato);
                cm.Parameters.AddWithValue("@Direccion", dato);
                cm.Parameters.AddWithValue("@Categoria", dato);
                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();
                listaHotel = new List<Hoteles>();
                while (dr.Read())
                {
                    Hoteles ho = new Hoteles();
                    ho.Codigo = Convert.ToInt32(dr["Codigo"].ToString());
                    ho.Nombre = dr["nombres"].ToString();
                    ho.Direccion = dr["Direccion"].ToString();
                    ho.Categoria = dr["Categoria"].ToString();
                    listaHotel.Add(ho);
                }

            }
            catch (Exception e)
            {
                e.Message.ToString();
                listaHotel = null;
            }
            finally { cm.Connection.Close(); }
            return listaHotel;
        }

        public List<Hoteles> ListarHotel()
        {

            try
            {
                SqlConnection cnx = cn.conectar();
                cm = new SqlCommand("nuevoHotel", cnx);
                cm.Parameters.AddWithValue("@b", 2);
                cm.Parameters.AddWithValue("@Codigo", "");
                cm.Parameters.AddWithValue("@Nombre", "");
                cm.Parameters.AddWithValue("@Direccion", "");
                cm.Parameters.AddWithValue("@Categoria", "");
                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();
                listaHotel = new List<Hoteles>();
                while (dr.Read())
                {
                    Hoteles ho = new Hoteles();
                    ho.Codigo = Convert.ToInt32(dr["Codigo"].ToString());
                    ho.Nombre = dr["nombres"].ToString();
                    ho.Direccion = dr["Direccion"].ToString();
                    ho.Categoria = dr["Categoria"].ToString();
                    listaHotel.Add(ho);
                }

            }
            catch (Exception e)
            {
                e.Message.ToString();
                listaHotel = null;
            }
            finally { cm.Connection.Close(); }
            return listaHotel;
        }

        public Hoteles BuscarHotelXcodigo(int codigo)
        {
            Hoteles ht = new Hoteles();
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("nuevoHotel", cnx);
                cm.Parameters.AddWithValue("@b", 5);
                cm.Parameters.AddWithValue("@Codigo", codigo);
                cm.Parameters.AddWithValue("@Nombre", "");
                cm.Parameters.AddWithValue("@Direccion", "");
                cm.Parameters.AddWithValue("@Categoria", "");

                ht.Codigo = Convert.ToInt32(dr["Codigo"].ToString());
                ht.Nombre = dr["nombres"].ToString();
                ht.Direccion = dr["Direccion"].ToString();
                ht.Categoria = dr["Categoria"].ToString();
                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();
                dr.Read();



            }
            catch (Exception e)
            {
                e.Message.ToString();
                ht = null;
            }
            finally
            {
                cm.Connection.Close();

            }
            return ht;
        }

        public int EliminarHotel(int Codigo)
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("nuevoHotel", cnx);
                cm.Parameters.AddWithValue("@b", 4);
                cm.Parameters.AddWithValue("@Codigo", ht.Codigo);
                cm.Parameters.AddWithValue("@Nombre", ht.Nombre);
                cm.Parameters.AddWithValue("@Direccion", ht.Direccion);
                cm.Parameters.AddWithValue("@Categoria", ht.Categoria);


                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                cm.ExecuteNonQuery();
                indicador = 1;
            }
            catch (Exception e)
            {
                e.Message.ToString();
                indicador = 0;
            }
            finally { cm.Connection.Close(); }
            return indicador;
        }

    }
}
