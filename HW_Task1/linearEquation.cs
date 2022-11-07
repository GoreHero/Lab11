using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace HW_Task1
{
    struct LinearEquation
    {
        double k;
        double b;
        
        public LinearEquation(double k, double b)
        {
            this.k = k;
            this.b = b;
        }
        public string Root()
        {

            if (k != 0)
            {
                double x1 = (-b) / k;
                return $"Корень уравнения = {x1}";
            }
            else if (k == 0 && b == 0)
                return "У уровнения нет корней";
            else
                return "Корень уровнения любое число";   

        }
    }
}
