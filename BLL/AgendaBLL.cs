using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace EjerciciosLibro.BLL
{
   public  class AgendaBLL
    {
        public static void insertar(Hashtable hash, string contacto, string numero)
        {
            hash.Add(numero, contacto);
        }
    }
}
