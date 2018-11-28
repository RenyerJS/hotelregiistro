using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormReservacionHotel
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run( new FormReservaciones());
            //Application.Run(new FormHoteles());
            //Application.Run(new FormHabitaciones());
            //Application.Run(new Form1());
            Application.Run(new MDIReservacionHotel());
        }

           }
}
