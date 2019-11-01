using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Estetica
{
    class Program
    {
        static void Main(string[] args)
        {
            int value = 0;
            menu_inventario inventario1 = new menu_inventario();
            Menu_reservacion reservacion1 = new Menu_reservacion();


            while (value < 1 || value > 3)
            {
                Console.WriteLine("         BARBERIA LA 23");
                Console.WriteLine("***************************");
                Console.WriteLine("             MENU" +
                    "\n1.-Inventario\n2.-Reservaciones\n3.-Informacion del personal\n");
                Console.WriteLine("***************************");
                Console.Write("Seleccione una opcion del menu: ");
                value = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (value)
                {
                    case 1:
                        inventario1.desplegar_menu();
                        value = 0;
                        break;
                    case 2:
                        reservacion1.desplegar_menu();
                        value = 0;
                        break;
                    default:

                        break;
                }

            }

        }

    }

}