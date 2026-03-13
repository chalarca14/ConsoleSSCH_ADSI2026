using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSSCH_ADSI2026.Empleados
{
    internal class Empleado
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Departamento { get; set; }
        public decimal Salario { get; set; }
        public bool Activo { get; set; }
    }
}
