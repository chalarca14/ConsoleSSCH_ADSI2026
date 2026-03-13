using ConsoleSSCH_ADSI2026.Facturacion;
using ConsoleSSCH_ADSI2026.Empleados;
using System;

namespace ConsoleSSCH_ADSI2026
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FacturasQuemadas Facturas = new FacturasQuemadas();
            EmpleadosQuemados Empleados = new EmpleadosQuemados();
            bool salir = false;

            while (!salir)
            {
                Console.WriteLine("******* Menu Principal ******");
                Console.WriteLine("1. Gestion de Facturas");
                Console.WriteLine("2. Gestion de Empleados");
                Console.WriteLine("3. Salir");
                Console.Write("Seleccione una opción: ");

                int opcion;
                while (!int.TryParse(Console.ReadLine(), out opcion))
                {
                    Console.WriteLine("Ingrese un número válido:");
                }

                switch (opcion)
                {
                    case 1:
                        MenuFacturas(Facturas);
                        break;
                    case 2:
                        MenuEmpleados(Empleados);
                        break;
                    case 3:
                        salir = true;
                        break;
                    default:
                        Console.WriteLine("la opcion no esta en el rango");
                        break;
                }
            }
        }

        static void MenuFacturas(FacturasQuemadas Facturas)
        {
            bool salir = false;
            while (!salir)
            {
                Console.WriteLine("******* Menu Facturas ******");
                Console.WriteLine("1. Mostrar Todas las Facturas");
                Console.WriteLine("2. Mostrar Facturas no pagadas");
                Console.WriteLine("3. total pendiente a pagar");
                Console.WriteLine("4. Facturas ordenadas de manera decendiente");
                Console.WriteLine("5. facturas Mayores a 1.000.000");
                Console.WriteLine("6. Volver");
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
                if (!salir) Facturas.Pausa();
            }
        }

        static void MenuEmpleados(EmpleadosQuemados Empleados)
        {
            bool salir = false;
            while (!salir)
            {
                Console.WriteLine("******* Menu Empleados ******");
                Console.WriteLine("1. Mostrar todos los empleados");
                Console.WriteLine("2. Mostrar empleados activos");
                Console.WriteLine("3. Mostrar empleados del departamento IT");
                Console.WriteLine("4. Ver salario promedio");
                Console.WriteLine("5. Empleado con mayor salario");
                Console.WriteLine("6. Contar empleados con salario mayor a 5.000.000");
                Console.WriteLine("7. Empleados agrupados por departamento");
                Console.WriteLine("8. Volver");
                Console.Write("Seleccione una opción: ");

                int opcion;
                while (!int.TryParse(Console.ReadLine(), out opcion))
                {
                    Console.WriteLine("Ingrese un número válido:");
                }

                switch (opcion)
                {
                    case 1:
                        Empleados.MostrarEmpleados();
                        break;
                    case 2:
                        Empleados.EmpleadosActivos();
                        break;
                    case 3:
                        Empleados.EmpleadosIT();
                        break;
                    case 4:
                        Empleados.SalarioPromedio();
                        break;
                    case 5:
                        Empleados.EmpleadoMayorSalario();
                        break;
                    case 6:
                        Empleados.ContarSalarioAlto();
                        break;
                    case 7:
                        Empleados.EmpleadosPorDepartamento();
                        break;
                    case 8:
                        salir = true;
                        break;
                    default:
                        Console.WriteLine("la opcion no esta en el rango");
                        break;
                }
                if (!salir) Empleados.Pausa();
            }
        }
    }
}