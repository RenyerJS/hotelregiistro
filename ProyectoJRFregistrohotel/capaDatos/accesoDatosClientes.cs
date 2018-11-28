using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaEntidades;
using System.Data;
using System.Data.SqlClient;

namespace capaDatos
{
    public class accesoDatosClientes
    {
        SqlConnection cnx;
        Clientes cls = new Clientes();
        Conexion cn = new Conexion();
        SqlCommand cm = null;
        int indicador = 0;
        SqlDataReader dr = null;
        List<Clientes> listaClien = null;

        public int insertarCliente(Clientes cls)
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("nuevocliente", cnx);
                cm.Parameters.AddWithValue("@b", 1);
                cm.Parameters.AddWithValue("@NumeroCliente", "");
                cm.Parameters.AddWithValue("@Cedula", cls.Cedula);
                cm.Parameters.AddWithValue("@Nombres", cls.Nombres);
                cm.Parameters.AddWithValue("@Apellidos", cls.Apellidos);
                cm.Parameters.AddWithValue("@direccion", cls.Direccion);
                cm.Parameters.AddWithValue("@telefono", cls.Telefono);
                cm.Parameters.AddWithValue("@tipocliente", cls.Tipocliente);


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

        public int EditarCliente(Clientes cls)
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("nuevocliente", cnx);
                cm.Parameters.AddWithValue("@b", 3);
                cm.Parameters.AddWithValue("@NumeroCliente", "");
                cm.Parameters.AddWithValue("@Cedula", cls.Cedula);
                cm.Parameters.AddWithValue("@Nombres", cls.Nombres);
                cm.Parameters.AddWithValue("@Apellidos", cls.Apellidos);
                cm.Parameters.AddWithValue("@direccion", cls.Direccion);
                cm.Parameters.AddWithValue("@telefono", cls.Telefono);
                cm.Parameters.AddWithValue("@tipocliente", cls.Tipocliente);


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

        public List<Clientes> BuscaClienteDatos(String dato)
        {

            try
            {
                SqlConnection cnx = cn.conectar();
                cm = new SqlCommand("nuevocliente", cnx);
                cm.Parameters.AddWithValue("@b", 6);
                cm.Parameters.AddWithValue("@NumeroCliente", "");
                cm.Parameters.AddWithValue("@Cedula", dato);
                cm.Parameters.AddWithValue("@Nombres", dato);
                cm.Parameters.AddWithValue("@Apellidos", dato);
                cm.Parameters.AddWithValue("@direccion", dato);
                cm.Parameters.AddWithValue("@telefono", "");
                cm.Parameters.AddWithValue("@tipocliente", "");
                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();
                listaClien = new List<Clientes>();
                while (dr.Read())
                {
                    Clientes c = new Clientes();
                    c.NumeroCliente = Convert.ToInt32(dr["NumeroCliente"].ToString());
                    c.Nombres = dr["Nombres"].ToString();
                    c.Cedula = dr["Cedula"].ToString();
                    c.Apellidos = dr["Apellidos"].ToString();
                    c.Direccion = dr["direccion"].ToString();
                    c.Telefono = dr["telefono"].ToString();
                    c.Tipocliente = dr["tipocliente"].ToString();
                    listaClien.Add(c);
                }

            }
            catch (Exception e)
            {
                e.Message.ToString();
                listaClien = null;
            }
            finally { cm.Connection.Close(); }
            return listaClien;
        }

        public List<Clientes> ListarClientes()
        {

            try
            {
                SqlConnection cnx = cn.conectar();
                cm = new SqlCommand("nuevocliente", cnx);
                cm.Parameters.AddWithValue("@b", 2);
                cm.Parameters.AddWithValue("@NumeroCliente", "");
                cm.Parameters.AddWithValue("@Cedula", "");
                cm.Parameters.AddWithValue("@Nombres", "");
                cm.Parameters.AddWithValue("@Apellidos", "");
                cm.Parameters.AddWithValue("@direccion", "");
                cm.Parameters.AddWithValue("@telefono", "");
                cm.Parameters.AddWithValue("@tipoclient", "");
                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();
                listaClien = new List<Clientes>();
                while (dr.Read())
                {
                    Clientes c = new Clientes();
                    c.NumeroCliente = Convert.ToInt32(dr["NumeroCliente"].ToString());
                    c.Nombres = dr["Nombres"].ToString();
                    c.Cedula = dr["Cedula"].ToString();
                    c.Apellidos = dr["Apellidos"].ToString();
                    c.Direccion = dr["direccion"].ToString();
                    c.Telefono = dr["telefono"].ToString();
                    c.Tipocliente = dr["tipocliente"].ToString();
                    listaClien.Add(c);
                }

            }
            catch (Exception e)
            {
                e.Message.ToString();
                listaClien = null;
            }
            finally { cm.Connection.Close(); }
            return listaClien;
        }

        public Clientes BuscarClienteXcodigo(int NuCli)
        {
            Clientes cl = new Clientes();
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("nuevocliente", cnx);
                cm.Parameters.AddWithValue("@b", 5);
                cm.Parameters.AddWithValue("@NumeroCliente", NuCli);
                cm.Parameters.AddWithValue("Cedula", "");
                cm.Parameters.AddWithValue("@Nombres", "");
                cm.Parameters.AddWithValue("@Apelidos", "");
                cm.Parameters.AddWithValue("@direccion", "");
                cm.Parameters.AddWithValue("@telefono", "");
                cm.Parameters.AddWithValue("@tipocliente", "");
                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();
                dr.Read();

                cl.NumeroCliente = Convert.ToInt32(dr["NumeroCliente"].ToString());
                cl.Cedula = dr["Cedula"].ToString();
                cl.Nombres = dr["Nombres"].ToString();
                cl.Direccion = dr["direccion"].ToString();
                cl.Telefono = dr["telefono"].ToString();
                cl.Tipocliente = dr["tipocliente"].ToString();

            }
            catch (Exception e)
            {
                e.Message.ToString();
                cl = null;
            }
            finally
            {
                cm.Connection.Close();

            }
            return cl;
        }

        public int EliminarCliente(int NumeroCliente)
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("nuevocliente", cnx);
                cm.Parameters.AddWithValue("@b", 4);
                cm.Parameters.AddWithValue("@NumeroCliente", cls.NumeroCliente);
                cm.Parameters.AddWithValue("@Cedula", cls.Cedula);
                cm.Parameters.AddWithValue("@Nombres", cls.Nombres);
                cm.Parameters.AddWithValue("@Apellidos", cls.Apellidos);
                cm.Parameters.AddWithValue("@direccion", cls.Direccion);
                cm.Parameters.AddWithValue("@telefono", cls.Telefono);
                cm.Parameters.AddWithValue("@tipocliente", cls.Tipocliente);


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
