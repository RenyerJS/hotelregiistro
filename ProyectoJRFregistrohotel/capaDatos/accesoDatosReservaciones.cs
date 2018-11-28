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
    public class accesoDatosReservaciones
    {
        SqlConnection cnx;
        Reservaciones re = new Reservaciones();
        Conexion cn = new Conexion();
        SqlCommand cm = null;
        int indicador = 0;
        SqlDataReader dr = null;
        List<Reservaciones> listaReservacion = null;


        public int insertarReservacion(Reservaciones re)
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("nuevaReservacion", cnx);
                cm.Parameters.AddWithValue("@b", 1);
                cm.Parameters.AddWithValue("@Id", "");
                cm.Parameters.AddWithValue("@Fecha", re.Fecha);
                cm.Parameters.AddWithValue("Tiempo", re.Tiempo);
                cm.Parameters.AddWithValue("@NumeroCliente", re.NumeroCliente);
                cm.Parameters.AddWithValue("@Numero", re.Numero);

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

        public int EditarReservacion(Reservaciones re)
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("nuevaReservacion", cnx);
                cm.Parameters.AddWithValue("@b", 3);
                cm.Parameters.AddWithValue("@Id", "");
                cm.Parameters.AddWithValue("@Fecha", re.Fecha);
                cm.Parameters.AddWithValue("Tiempo", re.Tiempo);
                cm.Parameters.AddWithValue("@NumeroCliente", re.NumeroCliente);
                cm.Parameters.AddWithValue("@Numero", re.Numero);


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

        public List<Reservaciones> BuscaReservacionDatos(String dato)
        {

            try
            {
                SqlConnection cnx = cn.conectar();
                cm = new SqlCommand("nuevaReservacion", cnx);
                cm.Parameters.AddWithValue("@b", 6);
                cm.Parameters.AddWithValue("@Id", "");
                cm.Parameters.AddWithValue("@Fecha", dato);
                cm.Parameters.AddWithValue("Tiempo", dato);
                cm.Parameters.AddWithValue("@NumeroCliente", dato);
                cm.Parameters.AddWithValue("@Numero", dato);
                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();
                listaReservacion = new List<Reservaciones>();
                while (dr.Read())
                {
                    Reservaciones r = new Reservaciones();
                    r.Id = Convert.ToInt32(dr["Id"].ToString());
                    r.Fecha = dr["Fecha"].ToString();
                    r.Tiempo = dr["Tiempo"].ToString();
                    r.NumeroCliente = dr["@NumeroCliente"].ToString();
                    r.Numero = dr["@Numero"].ToString();
                    listaReservacion.Add(r);
                }

            }
            catch (Exception e)
            {
                e.Message.ToString();
                listaReservacion = null;
            }
            finally { cm.Connection.Close(); }
            return listaReservacion;
        }

        public List<Reservaciones> ListarReservacion()
        {

            try
            {
                SqlConnection cnx = cn.conectar();
                cm = new SqlCommand("nuevaReservacion", cnx);
                cm.Parameters.AddWithValue("@b", 2);
                cm.Parameters.AddWithValue("@Id", "");
                cm.Parameters.AddWithValue("@Fecha", "");
                cm.Parameters.AddWithValue("Tiempo", "");
                cm.Parameters.AddWithValue("@NumeroCliente", re.NumeroCliente);
                cm.Parameters.AddWithValue("@Numero", re.Numero);
                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();
                listaReservacion = new List<Reservaciones>();
                while (dr.Read())
                {
                    Reservaciones r = new Reservaciones();
                    r.Id = Convert.ToInt32(dr["Id"].ToString());
                    r.Fecha = dr["Fecha"].ToString();
                    r.Tiempo = dr["Tiempo"].ToString();
                    r.NumeroCliente = dr["@NumeroCliente"].ToString();
                    r.Numero = dr["@Numero"].ToString();
                    listaReservacion.Add(r);
                }

            }
            catch (Exception e)
            {
                e.Message.ToString();
                listaReservacion = null;
            }
            finally { cm.Connection.Close(); }
            return listaReservacion;
        }

        public Reservaciones BuscarReservacionXcodigo(int Codigo)
        {
            Reservaciones re = new Reservaciones();
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("nuevaReservacion", cnx);
                cm.Parameters.AddWithValue("@b", 5);
                cm.Parameters.AddWithValue("@Id", Codigo);
                cm.Parameters.AddWithValue("@Fecha", "");
                cm.Parameters.AddWithValue("Tiempo", "");
                cm.Parameters.AddWithValue("@NumeroCliente", "");
                cm.Parameters.AddWithValue("@Numero", "");

                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();
                dr.Read();

                re.Id = Convert.ToInt32(dr["Id"].ToString());
                re.Fecha = dr["Fecha"].ToString();
                re.Tiempo = dr["Tiempo"].ToString();
                re.NumeroCliente = dr["@NumeroCliente"].ToString();
                re.Numero = dr["@Numero"].ToString();

            }
            catch (Exception e)
            {
                e.Message.ToString();
                re = null;
            }
            finally
            {
                cm.Connection.Close();

            }
            return re;
        }

        public int EliminarReservacion(int Id)
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("nuevaReservacion", cnx);
                cm.Parameters.AddWithValue("@b", 4);
                cm.Parameters.AddWithValue("@Id", Id);
                cm.Parameters.AddWithValue("@Fecha", re.Fecha);
                cm.Parameters.AddWithValue("@Tiempo", re.Tiempo);
                cm.Parameters.AddWithValue("@NumeroCliente", re.NumeroCliente);
                cm.Parameters.AddWithValue("@Numero", re.Numero);


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
