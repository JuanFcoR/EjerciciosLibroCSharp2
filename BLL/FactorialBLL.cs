using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosLibro.BLL
{
    public class FactorialBLL
    {
        public int FunFactorial(int num)
        {
            if (num == 1 || num <= 0)
                return 1;
            else
            {
                return num* FunFactorial(num-1);
            } 
        }
    }
}
