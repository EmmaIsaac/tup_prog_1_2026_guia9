using Ejercicio2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    internal class Program
    {
        static Servicio servicio = new Servicio();

        #region metodos
        static int MostrarPantallaSolicitarOpcionMenu()
        {
            Console.Clear();
            Console.WriteLine("Ingrese las siguientes opciones:\n\n");
            Console.WriteLine("1-Iniciar Monto a repartir");
            Console.WriteLine("2-Solicitar edad por niña");
            Console.WriteLine("3-Mostrar monto y porcentajes que corresponde a cada niña");
            Console.WriteLine("Otro-Salir.");
            int opcion = Convert.ToInt32(Console.ReadLine());
            return opcion;
        }

        static void MostrarPantallaSolicitarMontoARepartir()
        {
            Console.Clear();
            Console.WriteLine("Monto a repartir: \n\n");
            
            double mont = Convert.ToDouble(Console.ReadLine());
            servicio.RegistrarMontoARepartir(mont);
        }

        static void MostrarPantallaSolicitarEdadesNinias()
        {
            Console.Clear();
            Console.WriteLine("Edades de las niñas:\n\n");
            for (int nro = 0; nro < 4; nro++)
            {
                Console.WriteLine($"ingrese edad de la niña numero {nro+1}:");
                int ed = Convert.ToInt32(Console.ReadLine());
                servicio.RegistrarEdad(ed, nro);
            }
        }

        static void mostrarPantallaCalcularMostrarMonyoYPorcentajePorNinia()
        {
            Console.Clear();
            Console.WriteLine("Reparto de dinero:\n\n");
            servicio.CalcularMontosYPorcentajesARepartir();
            Console.WriteLine($"Niña 1 - Porcentaje: {servicio.porcentaje0.ToString("0.00")}% - Monto: ${servicio.monto0.ToString("0.00")}");
            Console.WriteLine($"Niña 2 - Porcentaje: {servicio.porcentaje1.ToString("0.00")}% - Monto: ${servicio.monto1.ToString("0.00")}");
            Console.WriteLine($"Niña 3 - Porcentaje: {servicio.porcentaje2.ToString("0.00")}% - Monto: ${servicio.monto2.ToString("0.00")}");
            Console.WriteLine($"Niña 4 - Porcentaje: {servicio.porcentaje3.ToString("0.00")}% - Monto: ${servicio.monto3.ToString("0.00")}");

            Console.WriteLine("Presione una tecla para volver al menu...");
            Console.ReadKey();
        }
        #endregion
        static void Main(string[] args)
        {
            MostrarPantallaSolicitarMontoARepartir();

            int op;

            do
            {
                op = MostrarPantallaSolicitarOpcionMenu();
                

                switch (op)
                {
                    case 1:
                        Program.MostrarPantallaSolicitarMontoARepartir();
                        break;
                    case 2:
                        Program.MostrarPantallaSolicitarEdadesNinias();
                        break;
                    case 3:
                        Program.mostrarPantallaCalcularMostrarMonyoYPorcentajePorNinia();
                        
                        break;
                    default:
                        op = -1;
                        break;
                }

            } while (op != -1);
            Console.WriteLine("Ingrese cualquier tecla para terminar...");
            Console.ReadKey();
        }
    }
}
