using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaDatos;
using capaEntidades;

namespace capaNegocio
{
    public class logicaNegocioClientes
    {
        accesoDatosClientes cl = new accesoDatosClientes();
        public int insertarCliente(Clientes cls)
        {
            return cl.insertarCliente(cls);
        }

        public List<Clientes> ListaCliente()
        {
            return cl.ListarClientes();
        }
        public int EditarCliente(Clientes cls)
        {
            return cl.EditarCliente(cls);
        }
        public int EliminarCliente(int Numerocliente)
        {
            return cl.EliminarCliente(Numerocliente);
        }
        public Clientes BuscarClienteXcodigo(int NuCli)
        {
            return cl.BuscarClienteXcodigo(NuCli);
        }
        public List<Clientes> BuscaClienteDatos(String dato)
        {
            return cl.BuscaClienteDatos(dato);
        }
    }
}
