using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaEntidades;
using capaDatos;

namespace capaNegocio
{
    public class logicaNegocioHabitaciones
    {
        accesoDatosHabitaciones hbt = new accesoDatosHabitaciones();
        public int insertarHabitaciones(Habitaciones hb)
        {
            return hbt.insertarHabitaciones(hb);
        }

        public List<Habitaciones> ListaHabitacion()
        {
            return hbt.ListarHabitacion();
        }
        public int EditarHabitacion(Habitaciones ht)
        {
            return hbt.EditarHabitacion(ht);
        }
        public int EliminarHabitacion(int Numero)
        {
            return hbt.EliminarHabitacion(Numero);
        }
        public Habitaciones BuscarHabitacionXcodigo(int Codigo)
        {
            return hbt.BuscarHabitacionXcodigo(Codigo);
        }
        public List<Habitaciones> BuscaHabitacionDatos(String dato)
        {
            return hbt.BuscaHabitacionDatos(dato);
        }
    }
}
