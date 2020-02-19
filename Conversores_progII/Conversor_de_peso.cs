using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversores_progII
{
    class Conversor_de_peso
    {
        
        public string[] Tipo = { "peso" };

        public string[][] etiquetas =
      {
            new string [] {"Kilogramo","Gramo","Miligramo","MicroGramo","Libra","Onza", "Tonelada", "Stone" ," tonelada larga", "tonelada corta"},
                 };
        double[][] valores =
     {
            new double[] { 1, 1000, 1e+6 , 1e+9, 2.20462, 35.274, 0.001, 0.157473, 0.000984207,0.00110231 },
             };
        public double convertir(int de, int a, double cantidad, int opcion)
        {
            return Math.Round(valores[opcion][a] / valores[opcion][de] * cantidad, 2);
        }

    }
}
