using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSUniversalLib
{
    public class Calc
    {
        public static int GetQuaForProd(int count, int widht, int lenght, 
            int product_mat, int material_prod)
        {

            if (count < 1 || widht < 1 || lenght < 1 
                || product_mat < 1 ||
                material_prod < 1 || product_mat > 3
                || material_prod > 2)
            {
                return -1;
            }


            double[] prodT = { 1.1, 2.5, 8.43 };
            double[] matT = { 0.003, 0.0012 };

            double rez = (count * (widht * lenght) * prodT[product_mat - 1]);
            double brak = (rez * (matT[material_prod - 1])) + rez;
            rez = Math.Ceiling(brak);
            return Convert.ToInt32(rez);

        }
    }
}
