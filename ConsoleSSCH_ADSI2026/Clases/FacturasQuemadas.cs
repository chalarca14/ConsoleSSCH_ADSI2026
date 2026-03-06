using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSSCH_ADSI2026.Clases
{
    public class FacturasQuemadas
    {
        List<Factura> facturas = new List<Factura>
            {
                new Factura {
                    Id = 1,
                    NumeroFactura = 001,
                    Cliente = "Cliente 1",
                    Total = 150000,
                    Pagada = true },
                new Factura {
                    Id = 2,
                    NumeroFactura = 002,
                    Cliente = "Cliente 2",
                    Total = 320000,
                    Pagada = false },
                new Factura {
                    Id = 3,
                    NumeroFactura = 003,
                    Cliente = "Cliente 3",
                    Total = 780000,
                    Pagada = true },
                new Factura {
                    Id = 4,
                    NumeroFactura = 004,
                    Cliente = "Cliente 4",
                    Total = 540000,
                    Pagada = false },
                new Factura {
                    Id = 5,
                    NumeroFactura = 005,
                    Cliente = "Cliente 5",
                    Total = 2100000,
                    Pagada = true },
                new Factura {
                    Id = 6,
                    NumeroFactura = 006,
                    Cliente = "Cliente 6",
                    Total = 99000,
                    Pagada = false },
                new Factura {
                    Id = 7,
                    NumeroFactura = 007,
                    Cliente = "Cliente 7",
                    Total = 450000,
                    Pagada = true },
                new Factura {
                    Id = 8,
                    NumeroFactura = 008,
                    Cliente = "Cliente 8",
                    Total = 1200000,
                    Pagada = false },
                new Factura {
                    Id = 9,
                    NumeroFactura = 009,
                    Cliente = "Cliente 9",
                    Total = 670000,
                    Pagada = true },
                new Factura {
                    Id = 10,
                    NumeroFactura = 010,
                    Cliente = "Cliente 10",
                    Total = 3050000,
                    Pagada = false
                }
            };
        public void MostrarFscturas()
        {
            foreach (Factura f in facturas)
            {
                ImprimirFactura(f);
            }
        }

        public void FacturasNoPagadas()
        {
            List<Factura> Nopagas = facturas.Where(x => x.Pagada == false).ToList();
            foreach (Factura f in Nopagas)
            {
                ImprimirFactura(f);

            }
        }

        public void TotalPagar()
        {
            decimal TotalPagar = facturas.Sum(x => x.Total);

            Console.WriteLine("Total pendiente a pagar: " + TotalPagar);
        }

        public void FacturasOrdenadas()
        {
            List<Factura> FacturasOrdenadas = facturas.OrderByDescending(x => x.Id).ToList();
            foreach (Factura f in FacturasOrdenadas)
            {
                ImprimirFactura(f);

            }
        }

        public void FacturasMayores()
        {
            List<Factura> FacturasMayores = facturas.Where(x => x.Total > 1000000).ToList();

            foreach (Factura f in FacturasMayores)
            {
                ImprimirFactura(f);
            }
        }

        public void Pausa()
        {
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
        }
        public void ImprimirFactura(Factura f)
        {
            Console.WriteLine("**********************************************************");
            Console.WriteLine("Id: " + f.Id);
            Console.WriteLine("Numero Factura: " + f.NumeroFactura);
            Console.WriteLine("Cliente: " + f.Cliente);
            Console.WriteLine("Total: " + f.Total);
            Console.WriteLine("Pagada: " + f.Pagada);
        }
    }
}
