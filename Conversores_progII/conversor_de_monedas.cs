using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversores_progII
{
    class conversor_de_monedas
    {
        public string[] Tipo = { "moneda" };

        public string[][] etiquetas =
      {
            new string [] {"Dolar EE.UU","Colones(SV)","Yen","Rupia India","Lempiras", "Peso MX","BitCoin", "Quetzal", "Euro","Cordoba","Balboa","Peso Argentino", "Peso Chileno", "Peso Colombiano", "Soles(Peru)", "Dolar Canadiense", "Dolar Beliceño" , "libra egipcia", "rublo ruso", "real brasileño"},
                 };
        double[][] valores =
     {
            new double[] { 1, 8.75, 111.26, 71.55, 24.69, 19.36, 0.00026, 7.69, 0.88,32.95,1.00,39.95, 667.65, 3126.73,3.30, 1.33, 2.02, 15.61, 63.85,4.36  },
             };
        public double convertir(int de, int a, double cantidad, int opcion)
        {
            return Math.Round(valores[opcion][a] / valores[opcion][de] * cantidad, 2);
        }

    }
}

