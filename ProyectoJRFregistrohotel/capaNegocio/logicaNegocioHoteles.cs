using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaDatos;
using capaEntidades;

namespace capaNegocio
{
    public class logicaNegocioHoteles
    {
        accesoDatosHoteles hot = new accesoDatosHoteles();
        public int insertarHotel(Hoteles ht)
        {
            return hot.insertarHotel(ht);
        }

        public List<Hoteles> listaHotel()
        {
            return hot.ListarHotel();
        }
        public int EditarHotel(Hoteles ht)
        {
            return hot.EditarHotel(ht);
        }
        public int EliminarHotel(int Codigo)
        {
            return hot.EliminarHotel(Codigo);
        }
        public Hoteles BuscarHotelXcodigo(int codigo)
        {
            return hot.BuscarHotelXcodigo(codigo);
        }
        public List<Hoteles> BuscaHotelesDatos(String dato)
        {
            return hot.BuscaHotelesDatos(dato);
        }
    }
}
