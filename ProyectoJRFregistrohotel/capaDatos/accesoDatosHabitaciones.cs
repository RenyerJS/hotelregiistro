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
    public class accesoDatosHabitaciones
    {
        SqlConnection cnx;
        Habitaciones hb = new Habitaciones();
        Conexion cn = new Conexion();
        SqlCommand cm = null;
        int indicador = 0;
        SqlDataReader dr = null;
        List<Habitaciones> listaHabitacion = null;

        public int insertarHabitaciones(Habitaciones hb)
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("nuevaHabitacion", cnx);
                cm.Parameters.AddWithValue("@b", 1);
                cm.Parameters.AddWithValue("@IdHabitacion", "");
                cm.Parameters.AddWithValue("@Precio", hb.Precio);
                cm.Parameters.AddWithValue("@Codigo", hb.Codigo);
                cm.Parameters.AddWithValue("@Tipo", hb.Tipo);

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

        public int EditarHabitacion(Habitaciones ht)
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("nuevaHabitacion", cnx);
                cm.Parameters.AddWithValue("@b", 3);
                cm.Parameters.AddWithValue("@IdHabitacion", "");
                cm.Parameters.AddWithValue("@Precio", ht.Precio);
                cm.Parameters.AddWithValue("@Codigo", ht.Codigo);
                cm.Parameters.AddWithValue("@Tipo", ht.Tipo);

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

        public List<Habitaciones> BuscaHabitacionDatos(String dato)
        {

            try
            {
                SqlConnection cnx = cn.conectar();
                cm = new SqlCommand("nuevaHabitacion", cnx);
                cm.Parameters.AddWithValue("@b", 6);
                cm.Parameters.AddWithValue("@IdHabitacion", "");
                cm.Parameters.AddWithValue("@Precio", dato);
                cm.Parameters.AddWithValue("@Codigo", dato);
                cm.Parameters.AddWithValue("@Tipo", dato);
                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();
                listaHabitacion = new List<Habitaciones>();
                while (dr.Read())
                {
                    Habitaciones h = new Habitaciones();
                    h.IdHabitacion = Convert.ToInt32(dr["IdHabitacion"].ToString());
                    h.Precio = dr["Precio"].ToString();
                    h.Codigo = dr["Codigo"].ToString();
                    h.Tipo = dr["Tipo"].ToString();
                    listaHabitacion.Add(h);
                }

            }
            catch (Exception e)
            {
                e.Message.ToString();
                listaHabitacion = null;
            }
            finally { cm.Connection.Close(); }
            return listaHabitacion;
        }

        public List<Habitaciones> ListarHabitacion()
        {

            try
            {
                SqlConnection cnx = cn.conectar();
                cm = new SqlCommand("nuevabitacion", cnx);
                cm.Parameters.AddWithValue("@b", 2);
                cm.Parameters.AddWithValue("@IdHabitacion", "");
                cm.Parameters.AddWithValue("@Precio", hb.Precio);
                cm.Parameters.AddWithValue("@Codigo", hb.Codigo);
                cm.Parameters.AddWithValue("@Tipo", hb.Tipo);
                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();
                listaHabitacion = new List<Habitaciones>();
                while (dr.Read())
                {
                    Habitaciones h = new Habitaciones();
                    h.IdHabitacion = Convert.ToInt32(dr["IdHabitacion"].ToString());
                    h.Precio = dr["Precio"].ToString();
                    h.Codigo = dr["Codigo"].ToString();
                    h.Tipo = dr["Tipo"].ToString();
                    listaHabitacion.Add(h);
                }

            }
            catch (Exception e)
            {
                e.Message.ToString();
                listaHabitacion = null;
            }
            finally { cm.Connection.Close(); }
            return listaHabitacion;
        }

        public Habitaciones BuscarHabitacionXcodigo(int numero)
        {
            Habitaciones hb = new Habitaciones();
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("nuevHabitacion", cnx);
                cm.Parameters.AddWithValue("@b", 5);
                cm.Parameters.AddWithValue("@IdHabitacion", numero);
                cm.Parameters.AddWithValue("@Precio", "");
                cm.Parameters.AddWithValue("@Codigo", "");
                cm.Parameters.AddWithValue("@Tipo", "");
                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();
                dr.Read();

                hb.IdHabitacion = Convert.ToInt32(dr["IdHabitacion"].ToString());
                hb.Precio = dr["Precio"].ToString();
                hb.Codigo = dr["Codigo"].ToString();
                hb.Tipo = dr["Tipo"].ToString();

            }
            catch (Exception e)
            {
                e.Message.ToString();
                hb = null;
            }
            finally
            {
                cm.Connection.Close();

            }
            return hb;
        }

        public int EliminarHabitacion(int IdHabitacion)
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("nuevaHabitacion", cnx);
                cm.Parameters.AddWithValue("@b", 4);
                cm.Parameters.AddWithValue("@IdHabitacion", IdHabitacion);
                cm.Parameters.AddWithValue("@Precio", hb.Precio);
                cm.Parameters.AddWithValue("@Codigo", hb.Codigo);
                cm.Parameters.AddWithValue("@Tipo", hb.Tipo);


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
