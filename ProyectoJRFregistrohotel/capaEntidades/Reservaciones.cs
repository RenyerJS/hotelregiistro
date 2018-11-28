using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaEntidades
{
    public class Reservaciones
    {
        public int Id {get;set;}
	    public string Fecha {get;set;}
        public string Tiempo { get; set; }
        public string NumeroCliente { get; set; }
        public string Numero { get; set; }
    }
}
