using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSSCH_ADSI2026.Empleados
{
    internal class EmpleadosQuemados
    {
        List<Empleado> empleados = new List<Empleado>
        {
            new Empleado { Id = 1,  Nombre = "Ana García",     Departamento = "IT",       Salario = 7500000, Activo = true  },
            new Empleado { Id = 2,  Nombre = "Carlos López",   Departamento = "IT",       Salario = 6200000, Activo = true  },
            new Empleado { Id = 3,  Nombre = "Marta Torres",   Departamento = "RRHH",     Salario = 4800000, Activo = true  },
            new Empleado { Id = 4,  Nombre = "Luis Ramírez",   Departamento = "Finanzas", Salario = 8000000, Activo = false },
            new Empleado { Id = 5,  Nombre = "Sofía Medina",   Departamento = "IT",       Salario = 5500000, Activo = true  },
            new Empleado { Id = 6,  Nombre = "Pedro Herrera",  Departamento = "Ventas",   Salario = 3900000, Activo = true  },
            new Empleado { Id = 7,  Nombre = "Laura Jiménez",  Departamento = "Finanzas", Salario = 9200000, Activo = true  },
            new Empleado { Id = 8,  Nombre = "Jorge Castillo", Departamento = "Ventas",   Salario = 4100000, Activo = false },
            new Empleado { Id = 9,  Nombre = "Valentina Cruz", Departamento = "IT",       Salario = 6700000, Activo = true  },
            new Empleado { Id = 10, Nombre = "Andrés Mora",    Departamento = "RRHH",     Salario = 5000000, Activo = true  },
            new Empleado { Id = 11, Nombre = "Camila Ríos",    Departamento = "IT",       Salario = 7100000, Activo = false },
            new Empleado { Id = 12, Nombre = "Miguel Vargas",  Departamento = "Finanzas", Salario = 6300000, Activo = true  },
            new Empleado { Id = 13, Nombre = "Isabella Rojas", Departamento = "Ventas",   Salario = 5800000, Activo = true  },
            new Empleado { Id = 14, Nombre = "Sebastián Peña", Departamento = "RRHH",     Salario = 4600000, Activo = true  },
            new Empleado { Id = 15, Nombre = "Daniela Suárez", Departamento = "IT",       Salario = 8900000, Activo = true  },
        };

        public void MostrarEmpleados()
        {
            foreach (Empleado e in empleados)
            {
                ImprimirEmpleado(e);
            }
        }

        public void EmpleadosActivos()
        {
            List<Empleado> activos = empleados.Where(x => x.Activo == true).ToList();
            foreach (Empleado e in activos)
            {
                ImprimirEmpleado(e);
            }
        }

        public void EmpleadosIT()
        {
            List<Empleado> it = empleados.Where(x => x.Departamento == "IT").ToList();
            foreach (Empleado e in it)
            {
                ImprimirEmpleado(e);
            }
        }

        public void SalarioPromedio()
        {
            decimal promedio = empleados.Average(x => x.Salario);
            Console.WriteLine("Salario promedio: " + promedio);
        }

        public void EmpleadoMayorSalario()
        {
            Empleado top = empleados.OrderByDescending(x => x.Salario).First();
            Console.WriteLine("Empleado con mayor salario:");
            ImprimirEmpleado(top);
        }

        public void ContarSalarioAlto()
        {
            int cantidad = empleados.Count(x => x.Salario > 5000000);
            Console.WriteLine("Empleados que ganan más de $5.000.000: " + cantidad);
        }

        public void EmpleadosPorDepartamento()
        {
            var grupos = empleados.GroupBy(x => x.Departamento);
            foreach (var grupo in grupos)
            {
                Console.WriteLine("**********************************************************");
                Console.WriteLine("Departamento: " + grupo.Key + " (" + grupo.Count() + " empleados)");
                foreach (Empleado e in grupo)
                {
                    ImprimirEmpleado(e);
                }
            }
        }

        public void Pausa()
        {
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
        }

        public void ImprimirEmpleado(Empleado e)
        {
            Console.WriteLine("**********************************************************");
            Console.WriteLine("Id: " + e.Id);
            Console.WriteLine("Nombre: " + e.Nombre);
            Console.WriteLine("Departamento: " + e.Departamento);
            Console.WriteLine("Salario: " + e.Salario);
            Console.WriteLine("Activo: " + e.Activo);
        }
    }
}

