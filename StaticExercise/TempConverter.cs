using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExercise
{
    internal static class TempConverter
    {
   
        public static double FahrenheitToCelsius(double fahrenheit)
        {
            /* C = (F – 32) *5 / 9;*/
            return (fahrenheit - 32) * 5 / 9f;
        }

        public static double CelsiusToFahrenheit(double celsius)
        {
            /*F = (C * 9) / 5 + 32;*/
           return (celsius * 9) / 5 + 32;
            
            }
        
    }
}
