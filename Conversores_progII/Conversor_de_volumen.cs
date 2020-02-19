 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversores_progII
{
    class Conversor_de_volumen
    {
        public string[] Tipo = { "volumen" };

        public string[][] etiquetas =
      {
            new string [] {"Litro", "MiliLitro", "Metro Cubico", "Galon", "Pie Cubico", "Taza Americana","pulgada cubica","pie cubico", "onza liquida imperial" ,"cucharadita imperial",
                "cucharada imperial", "taza imperial","calon imperial","cuarto imperial","pinta imperial", "cucharadita EE.UU","cucharada EE.UU","onza liquida EE.UU","pinta EE.UU","cuarto EE.UU"},
             };
        double[][] valores =
     {
            new double[] { 1, 1000, 0.001, 0.264172, 0.0353147, 4.167,61.0237,0.0353147, 35.195, 169,56.312,3.52,0.219969,0.879877,1.76,203,
                67.628,33.814,2.113,1.057},
             };
        public double convertir(int de, int a, double cantidad, int opcion)
        {
            return Math.Round(valores[opcion][a] / valores[opcion][de] * cantidad, 2);
        }
    }
}
