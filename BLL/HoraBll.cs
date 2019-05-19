using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosLibro.BLL
{
    public class HoraBll
    {
        public static string hora(DateTime h)
        {
            string horaA;
            horaA = Convert.ToString(h);
            return horaA;
        }
    }
}
