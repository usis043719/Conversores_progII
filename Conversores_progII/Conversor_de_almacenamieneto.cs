using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversores_progII
{
    class Conversor_de_almacenamieneto
    {
        public string[] Tipo = { "almacenamiento" };

        public string[][] etiquetas =
      {
            new string [] {"MegaBytes", "KiloBytes", "GigaBytes", "TeraBytes", "PentaBytes", "ExaBytes", "Bit", "Byte","nibble" ,"kilobit","megabit","gigabit","terabit","petabit","exabit" },
                 };
        double[][] valores =
     {
            new double[] { 1, 1024, 9.77e-4, 9.54e-7, 9.31e-10, 9.09e-13, 8e+6, 1e+6, 2.097152 , 8.192,8 ,0.01,7.63e-6,7.45e-9,7.28e-12},
             };
        public double convertir(int de, int a, double cantidad, int opcion)
        {
            return Math.Round(valores[opcion][a] / valores[opcion][de] * cantidad, 2);
        }
    }
}    