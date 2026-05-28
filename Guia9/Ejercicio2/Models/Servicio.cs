using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2.Models
{
    internal class Servicio
    {
        public int edad0;
        public int edad1;
        public int edad2; 
        public int edad3;
        public double Monto;
        public double porcentaje0;
        public double porcentaje1;
        public double porcentaje2;
        public double porcentaje3;
        public double monto0;
        public double monto1;
        public double monto2; 
        public double monto3;

        public void RegistrarMontoARepartir(double monto)
        {
            Monto = monto;
        }

        public void RegistrarEdad(int edad, int nroNinia)
        {
            switch (nroNinia)
            {
                case 0:
                    edad0 = edad;
                    break;
                case 1:
                    edad1 = edad;
                    break;
                case 2:
                    edad2 = edad;
                    break;
                case 3:
                    edad3 = edad;
                    break;
                default:
                    
                    break;
            }
            
        }

        public void CalcularMontosYPorcentajesARepartir()
        {
            int sumaEdades = edad0 + edad1 + edad2 + edad3;
            porcentaje0 = (edad0 * 100.0) / sumaEdades;
            porcentaje1 = (edad1 * 100.0) / sumaEdades;
            porcentaje2 = (edad2 * 100.0) / sumaEdades;
            porcentaje3 = (edad3 * 100.0) / sumaEdades;
            monto0 = (porcentaje0 * Monto) / 100;
            monto1 = (porcentaje1 * Monto) / 100;
            monto2 = (porcentaje2 * Monto) / 100;
            monto3 = (porcentaje3 * Monto) / 100;
        }
    }
}
