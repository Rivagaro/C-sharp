
using System;
using System.Collections.Generic;


namespace Ejercicio_Estetica
{
    class Menu_reservacion
    {
        private int opcion;
        private List<Cliente> lista_reservas = new List<Cliente>();

        public void desplegar_reservacion()
        {
            opcion = 0;
            while (opcion != 5)
            {
                while (opcion < 1 || opcion > 5)
                {
                    Console.WriteLine("BARBERIA LA 23\nRESERVAIONES");
                    Console.WriteLine("*****************");
                    Console.WriteLine("1.-Agregar\n2.-Consultar reservaciones\n3.-Eliminar\n4.-Buscar\n5.-Salir");
                    Console.WriteLine("*****************");
                    Console.Write("ingrese una opcion: ");
                    opcion = Convert.ToInt32(Console.ReadLine());
                    switch (opcion)
                    {
                        case 1: //agregar
                            Cliente cliente_nuevo = new Cliente();
                            Console.WriteLine("Nueva reservacion");
                            Console.WriteLine("************************");
                            Console.Write("Nombre: ");
                            cliente_nuevo.Nombre = Console.ReadLine();
                            Console.Write("Telefono: ");
                            cliente_nuevo.Telefono = Console.ReadLine();
                            Console.Write("Fecha: ");
                            cliente_nuevo.Fecha = Console.ReadLine();
                            Console.Write("Hora:");
                            cliente_nuevo.Hora = Console.ReadLine();
                            Console.Write("Motivo de visita");
                            cliente_nuevo.Motivo_visita = Console.ReadLine();
                            Console.Write("************************");
                            lista_reservas.Add(cliente_nuevo);
                            Console.Clear();
                            break;
                        case 2: //listar
                            foreach (var i in lista_reservas)
                            {
                                Console.WriteLine("Libro de reservas");
                                Console.WriteLine("************************");
                                Console.WriteLine("Nombre: " + i.Nombre);
                                Console.WriteLine("Telefono: " + i.Telefono);
                                Console.WriteLine("Fecha: " + i.Fecha);
                                Console.WriteLine("Hora: " + i.Hora);
                                Console.WriteLine("Motivo de visita: " + i.Motivo_visita);
                                Console.WriteLine("************************");
                            }
                            Console.WriteLine("Presione cualquier tecla para regresar a menu de inventario...");
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        case 3: //eliminar
                            Console.WriteLine("Eliminar reservacion");
                            Console.WriteLine("************************");
                            Console.Write("Ingrese el numero de telefono de la reservacion a eliminar: ");
                            string tel_eliminar = (Console.ReadLine());
                            lista_reservas.RemoveAll(i => i.Telefono == tel_eliminar);
                            Console.Clear();
                            break;
                        case 4: //buscar

                            break;
                        default:
                            break;
                    }
                }
            }
        }
    }
    class Cliente
    {
        private string nombre;
        private string telefono;
        private string fecha;
        private string hora;
        private string motivo_visita;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Fecha { get => fecha; set => fecha = value; }
        public string Hora { get => hora; set => hora = value; }
        public string Motivo_visita { get => motivo_visita; set => motivo_visita = value; }
    }
}
