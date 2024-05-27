using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace conversor_tdd
{
    public class Conversor
    {
        private List<string> listaHistorico;

        public Conversor()
        {
            listaHistorico = new List<string>();
        }

        public double ConverterCelsiusParaFahrenheit(double temperatura)
        {
            var resultado = Math.Round((temperatura * 9 / 5) + 32, 2);
            listaHistorico.Insert(0, temperatura + "°C = " + resultado + "°F");
            return resultado;
        }
        public double ConverterCelsiusParaKelvin(double temperatura)
        {
            var resultado = Math.Round(temperatura + 273.15, 2);
            listaHistorico.Insert(0, temperatura + "°C = " + resultado + "K");
            return resultado;
        }
        
        public double ConverterKelvinParaCelsius(double temperatura)
        {
            var resultado = Math.Round(temperatura - 273.15, 2);
            listaHistorico.Insert(0, temperatura + "K = " + resultado + "°C");
            return resultado;
        }
        public double ConverterKelvinParaFahrenheit(double temperatura)
        {
            var resultado = Math.Round(((temperatura - 273.15) * 9 / 5) + 32, 2);
            listaHistorico.Insert(0, temperatura + "K = " + resultado + "°F");
            return resultado;
        }
        public double ConverterFahrenheitParaKelvin(double temperatura)
        {
            var resultado = Math.Round((temperatura - 32) * 5 / 9 + 273.15, 2);
            listaHistorico.Insert(0, temperatura + "°F = " + resultado + "K");
            return resultado;
        }

        public double ConverterFahrenheitParaCelsius(double temperatura)
        {
            var resultado = Math.Round((temperatura - 32) * 5 / 9, 2);
            listaHistorico.Insert(0, temperatura + "°F = " + resultado + "°C");
            return resultado;
        }

        public List<string> historico()
        {
            listaHistorico.RemoveRange(3, listaHistorico.Count - 3);
            return listaHistorico;
        }

    }
}