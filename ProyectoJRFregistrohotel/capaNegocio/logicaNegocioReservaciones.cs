using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaEntidades;
using capaDatos;

namespace capaNegocio
{
    public class logicaNegocioReservaciones
    {
        accesoDatosReservaciones rs = new accesoDatosReservaciones();
        public int insertarReservacion(Reservaciones re)
        {
            return rs.insertarReservacion(re);
        }

        public List<Reservaciones> ListaReservacion()
        {
            return rs.ListarReservacion();
        }
        public int EditarReservacion(Reservaciones re)
        {
            return rs.EditarReservacion(re);
        }
        public int EliminarReservacion(int Id)
        {
            return rs.EliminarReservacion(Id);
        }
        public Reservaciones BuscarReservacionXcodigo(int Codigo)
        {
            return rs.BuscarReservacionXcodigo(Codigo);
        }
        public List<Reservaciones> BuscaReservacionDatos(String dato)
        {
            return rs.BuscaReservacionDatos(dato);
        }
    }
}
