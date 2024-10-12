using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_2024_III_PI_TAREAIII_2021130021
{
    class Program
    {
        static List<Boleto> boletos = new List<Boleto>();
        static List<Avion> aviones = new List<Avion>();
        static List<Factura> facturas = new List<Factura>();

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Menú de Aerolínea 2:");
                Console.WriteLine("1. Agregar Boleto");
                Console.WriteLine("2. Visualizar Boletos");
                Console.WriteLine("3. Imprimir Boleto");
                Console.WriteLine("4. Agregar Avión");
                Console.WriteLine("5. Visualizar Aviones");
                Console.WriteLine("6. Imprimir Avión");
                Console.WriteLine("7. Agregar Factura");
                Console.WriteLine("8. Visualizar Facturas");
                Console.WriteLine("9. Imprimir Factura");
                Console.WriteLine("0. Salir");
                Console.Write("Seleccione una opción: ");

                int opcion;
                if (!int.TryParse(Console.ReadLine(), out opcion))
                {
                    Console.WriteLine("Por favor, ingrese un número válido.");
                    continue;
                }

                switch (opcion)
                {
                    case 1:
                        AgregarBoleto();
                        break;
                    case 2:
                        VisualizarBoletos();
                        break;
                    case 3:
                        ImprimirBoleto();
                        break;
                    case 4:
                        AgregarAvion();
                        break;
                    case 5:
                        VisualizarAviones();
                        break;
                    case 6:
                        ImprimirAvion();
                        break;
                    case 7:
                        AgregarFactura();
                        break;
                    case 8:
                        VisualizarFacturas();
                        break;
                    case 9:
                        ImprimirFactura();
                        break;
                    case 0:
                        return;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
            }
        }

        static void AgregarBoleto()
        {
            try
            {
                Console.Write("Ingrese el ID del boleto: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Ingrese el nombre del pasajero: ");
                string pasajero = Console.ReadLine();
                Console.Write("Ingrese el destino: ");
                string destino = Console.ReadLine();
                Console.Write("Ingrese el precio: ");
                double precio = double.Parse(Console.ReadLine());

                boletos.Add(new Boleto(id, pasajero, destino, precio));
                Console.WriteLine("Boleto agregado exitosamente.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al agregar el boleto: " + ex.Message);
            }
        }

        static void VisualizarBoletos()
        {
            Console.WriteLine("Lista de Boletos:");
            foreach (var boleto in boletos)
            {
                Console.WriteLine(boleto);
            }
        }

        static void ImprimirBoleto()
        {
            Console.Write("Ingrese el ID del boleto a imprimir: ");
            int id = int.Parse(Console.ReadLine());
            var boleto = boletos.FirstOrDefault(b => b.Id == id);
            if (boleto != null)
            {
                Console.WriteLine(boleto);
            }
            else
            {
                Console.WriteLine("Boleto no encontrado.");
            }
        }

        static void AgregarAvion()
        {
            try
            {
                Console.Write("Ingrese el ID del avión: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Ingrese el modelo del avión: ");
                string modelo = Console.ReadLine();
                Console.Write("Ingrese la capacidad: ");
                int capacidad = int.Parse(Console.ReadLine());

                aviones.Add(new Avion(id, modelo, capacidad));
                Console.WriteLine("Avión agregado exitosamente.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al agregar el avión: " + ex.Message);
            }
        }

        static void VisualizarAviones()
        {
            Console.WriteLine("Lista de Aviones:");
            foreach (var avion in aviones)
            {
                Console.WriteLine(avion);
            }
        }

        static void ImprimirAvion()
        {
            Console.Write("Ingrese el ID del avión a imprimir: ");
            int id = int.Parse(Console.ReadLine());
            var avion = aviones.FirstOrDefault(a => a.Id == id);
            if (avion != null)
            {
                Console.WriteLine(avion);
            }
            else
            {
                Console.WriteLine("Avión no encontrado.");
            }
        }

        static void AgregarFactura()
        {
            try
            {
                Console.Write("Ingrese el ID de la factura: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Ingrese el ID del boleto asociado: ");
                int boletoId = int.Parse(Console.ReadLine());
                Console.Write("Ingrese el monto total: ");
                double monto = double.Parse(Console.ReadLine());

                facturas.Add(new Factura(id, boletoId, monto));
                Console.WriteLine("Factura agregada exitosamente.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al agregar la factura: " + ex.Message);
            }
        }

        static void VisualizarFacturas()
        {
            Console.WriteLine("Lista de Facturas:");
            foreach (var factura in facturas)
            {
                Console.WriteLine(factura);
            }
        }

        static void ImprimirFactura()
        {
            Console.Write("Ingrese el ID de la factura a imprimir: ");
            int id = int.Parse(Console.ReadLine());
            var factura = facturas.FirstOrDefault(f => f.Id == id);
            if (factura != null)
            {
                Console.WriteLine(factura);
            }
            else
            {
                Console.WriteLine("Factura no encontrada.");
            }
        }
    }

    class Boleto
    {
        public int Id { get; set; }
        public string Pasajero { get; set; }
        public string Destino { get; set; }
        public double Precio { get; set; }

        public Boleto(int id, string pasajero, string destino, double precio)
        {
            Id = id;
            Pasajero = pasajero;
            Destino = destino;
            Precio = precio;
        }

        public override string ToString()
        {
            return $"Boleto ID: {Id}, Pasajero: {Pasajero}, Destino: {Destino}, Precio: {Precio}";
        }
    }

    class Avion
    {
        public int Id { get; set; }
        public string Modelo { get; set; }
        public int Capacidad { get; set; }

        public Avion(int id, string modelo, int capacidad)
        {
            Id = id;
            Modelo = modelo;
            Capacidad = capacidad;
        }

        public override string ToString()
        {
            return $"Avión ID: {Id}, Modelo: {Modelo}, Capacidad: {Capacidad}";
        }
    }

    class Factura
    {
        public int Id { get; set; }
        public int BoletoId { get; set; }
        public double Monto { get; set; }

        public Factura(int id, int boletoId, double monto)
        {
            Id = id;
            BoletoId = boletoId;
            Monto = monto;
        }

        public override string ToString()
        {
            return $"Factura ID: {Id}, Boleto ID: {BoletoId}, Monto: {Monto}";
        }
    }
}