using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Estetica
{
    class Menu_info_personal
    {
        private int opcion;
        private List<Empleado> lista_empleado = new List<Empleado>();
        public void desplegar_info_empleado()
        {
            do
            {
                do
                {
                    Console.WriteLine("BARBERIA LA 23\nINFORMACION DEL PEROSNAL");
                    Console.WriteLine("*****************");
                    Console.WriteLine("1.-Dar de alta\n2.-Consultar lista de empleados\n3.-Eliminar\n4.-Buscar\n5.-Salir");
                    Console.WriteLine("*****************");
                    Console.Write("ingrese una opcion: ");
                    opcion = Convert.ToInt32(Console.ReadLine());
                    switch (opcion)
                    {
                        case 1: //Agregar
                            Empleado empleado_nuevo = new Empleado();
                            Console.WriteLine("Alta empleado");
                            Console.WriteLine("************************");
                            Console.WriteLine("Matricula: ");
                            empleado_nuevo.Matricula = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Nombre:");
                            empleado_nuevo.Nombre = Console.ReadLine();
                            Console.WriteLine("Edad: ");
                            empleado_nuevo.Edad = Convert
                            Console.WriteLine("Telefono:");
                            Console.WriteLine("Pocision: ");
                            Console.Clear();
                            break;
                        case 2: //Consultar
                            break;
                        case 3: //Eliminar
                        case 4: //Buscar
                            break;
                        default: //Salir
                            break;
                    }
                } while (opcion < 1 || opcion >5);
            } while (opcion != 5);
           
        }

    }

    class Empleado
    {

        private int matricula;
        private string nombre;
        private string edad;
        private int telefono;
        private string posicion;

        public int Matricula { get => matricula; set => matricula = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Edad { get => edad; set => edad = value; }
        public int Telefono { get => telefono; set => telefono = value; }
        public string Posicion { get => posicion; set => posicion = value; }
    }
}
