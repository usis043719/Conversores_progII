﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversores_progII
{
    class Conversor_de_longitud
    {
        public string[] Tipo = { "longitudes" };

        public string[][] etiquetas =
      {
            new string [] {"Metro", "Cm", "Pulgada", "pie", "Varas","Yardas","Km","Milla", "Milimetro","MicroMetro", "NanoMetro", "milla nautica"},
                 };
        double[][] valores =
     {
            new double[] { 1, 100, 39.3701, 3.28084, 1.1963081929167, 1.09361, 0.001, 0.000621371, 1000, 1e+6, 1e+9,0.000539957 },
             };
        public double convertir(int de, int a, double cantidad, int opcion)
        {
            return Math.Round(valores[opcion][a] / valores[opcion][de] * cantidad, 2);
        }

    }
}
    
