using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace EjerciciosLibro.BLL
{
    public class DiccionarioBLL
    {
        public static void insertar(Hashtable hash,  string palabra,string significado)
        {
            hash.Add(palabra, significado);
        }


    }
}
