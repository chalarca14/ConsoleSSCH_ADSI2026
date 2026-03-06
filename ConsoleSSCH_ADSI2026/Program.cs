using ConsoleSSCH_ADSI2026.Clases;
using System;
using System.Diagnostics;
namespace ConsoleSSCH_ADSI2026
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FacturasQuemadas Facturas = new FacturasQuemadas();
            bool salir = false;
            while (!salir)
            {
                Console.WriteLine("******* Menu ******");
                Console.WriteLine("1. Mostrar Todas las Facturas");
                Console.WriteLine("2. Mostrar Facturas no pagadas");
                Console.WriteLine("3. total pendiente a pagar");
                Console.WriteLine("4. Facturas ordenadas de manera decendiente");
                Console.WriteLine("5. facturas Mayores a 1.000.000");
                Console.WriteLine("6. Salir");
                Console.Write("Seleccione una opción: ");
                int opcion;
                while (!int.TryParse(Console.ReadLine(), out opcion))
                {
                    Console.WriteLine("Ingrese un número válido:");
                }

                switch (opcion)
                {
                    case 1:
                        Facturas.MostrarFscturas();
                        break;
                    case 2:
                        Facturas.FacturasNoPagadas();
                        break;
                    case 3:
                        Facturas.TotalPagar();
                        break;
                    case 4:
                        Facturas.FacturasOrdenadas();
                        break;
                    case 5:
                        Facturas.FacturasMayores();
                        break;
                    case 6:
                        salir = true;
                        break;
                    default:
                        Console.WriteLine("la opcion no esta en el rango");
                        break;
                }
                Facturas.Pausa();

            }
        }
    }
}
