using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Estetica
{
    class menu_inventario
    {
        private int opcion;
        private List <Articulo> lista_articulos;
        public void desplegar_menu()
        {
            lista_articulos = new List<Articulo>();
            opcion = 0;
            while (opcion != 5)
            {
                opcion = 0;
                while (opcion < 1 || opcion > 5)
                {
                    Console.WriteLine("BARBERIA LA 23\nINVENTARIO");
                    Console.WriteLine("*****************");
                    Console.WriteLine("1.-Agregar\n2.-Listar\n3.-Eliminar\n4.-Buscar\n5.-Salir");
                    Console.WriteLine("*****************");
                    Console.Write("ingrese una opcion: ");
                    opcion = Convert.ToInt32(Console.ReadLine());
                    if (opcion < 1 || opcion > 5)
                    {
                        Console.WriteLine("Ingrese una opcion valiada 1-5");
                    }
                    Console.Clear();
                }
                switch (opcion)
                {
                    case 1: //agregar
                        Articulo nuevo_articulo = new Articulo();
                        Console.WriteLine("Agregar articulo");
                        Console.Write("Codigo: ");
                        nuevo_articulo.Codigo = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Marca: ");
                        nuevo_articulo.Marca = Console.ReadLine();
                        Console.Write("Descripcion: ");
                        nuevo_articulo.Descripcion = Console.ReadLine();
                        Console.Write("Precio: $");
                        nuevo_articulo.Precio = Console.ReadLine();
                        lista_articulos.Add(nuevo_articulo);
                        Console.Clear();
                        break;

                    case 2://Listar
                        foreach (var i in lista_articulos)///checar con Articulos
                        {
                            Console.WriteLine("-----------------------------");
                            Console.WriteLine("Codigo:"+ i.Codigo);
                            Console.WriteLine("Marca:"+ i.Marca);
                            Console.WriteLine("Descripcion:"+ i.Descripcion);
                            Console.WriteLine("Precio: $ "+ i.Precio);
                            Console.WriteLine("-----------------------------");
                        }
                        Console.WriteLine("Presione cualquier tecla para salir de la lista...");
                        Console.ReadLine();
                        Console.Clear();
                        break;

                    case 3://Eliminar
                        Console.Write("Ingrese el codigo a eliminar:");
                        int codigo_eliminar = Convert.ToInt32(Console.ReadLine());
                        lista_articulos.RemoveAll(i => i.codigo == codigo_eliminar);
                        Console.Clear();
                        break;
                       
                    case 4://Buscar
                        Console.Write("Ingresa el codigo a buscar:");
                        int codigo_buscar = Convert.ToInt32(Console.ReadLine());

                        foreach (var i in lista_articulos)
                        {
                            if (i.Codigo == codigo_buscar)
                            {
                                Console.WriteLine("-----------------------------");
                                Console.WriteLine("Codigo:"+ i.Codigo);
                                Console.WriteLine("Marca:"+ i.Marca);
                                Console.WriteLine("Descripcion:"+ i.Descripcion);
                                Console.WriteLine("Precio: $ "+ i.Precio);
                                Console.WriteLine("-----------------------------");
                                
                                break;
                            }
                            
                        }
                        
                        break;
                    default://Salir
                       
                        break;
                }
            }
        }
        
    }

    class Articulo
    {
        public int codigo;
        public string marca;
        public string descripcion;
        public string precio;

        public int Codigo { get => codigo; set => codigo = value; }
        public string Marca { get => marca; set => marca = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string Precio { get => precio; set => precio = value; }
    }
}


