using System;

namespace Repaso
{
    class Program
    {   
        static pantalla pantalla =  new pantalla();
        static void Main(string[] args)
        {
            int opcion;
            Console.WriteLine("­");
            do
            {
             
            Console.Clear();
            pantalla.pantalla1();
            
            Console.SetCursorPosition(50, 2); Console.WriteLine("FORTOX"); 

            Console.SetCursorPosition(44, 6);Console.WriteLine("1. Quienes Somos");
            Console.SetCursorPosition(44,10);Console.WriteLine("2. Menú Principal");
            Console.SetCursorPosition(47, 14); Console.WriteLine("3. Salir");
            Console.SetCursorPosition(44, 23); Console.WriteLine("Digite la opcion");
            Console.SetCursorPosition(51, 20); opcion = Convert.ToInt32(Console.ReadLine());
            
            switch (opcion)
            {
                case 1:QuienesSomos();
                    break;
                case 2:MenuPrincipal();
                    break;
                case 3:
                        Console.SetCursorPosition(42, 23); Console.WriteLine(" Hasta luego vuelva pronto ");
                    break;
                default:
                        
                        Console.SetCursorPosition(42, 23); Console.WriteLine("xX Opcion No ValidaXx");
                    break;
            }
            
            Console.SetCursorPosition(37,24); Console.WriteLine("»-» Presione tecla para continuar «-«");

            Console.ReadKey();
            } while (opcion != 3);
        }

        static void QuienesSomos()
        {
            Console.Clear();
            pantalla.pantalla2();
            Console.SetCursorPosition(50, 2); Console.WriteLine("INTEGRANTES");

            Console.SetCursorPosition(39, 6); Console.WriteLine("»-» Juan David Ducuara Molina «-«");
            Console.SetCursorPosition(39, 10); Console.WriteLine("»-» Fracisco Alejando Cifuentes «-«");
            Console.SetCursorPosition(39, 14); Console.WriteLine("»-» Daniel Santiago Martinez «-«");
            
            

        }
        static void MenuPrincipal()
        {
            int opcion;
            do
            {

            
            Console.Clear();
            pantalla.pantalla1();
            Console.SetCursorPosition(47, 2); Console.WriteLine("MENÚ PRINCIPAL");

            Console.SetCursorPosition(43, 6); Console.WriteLine("1-» Agregar personaje");
            Console.SetCursorPosition(43, 10); Console.WriteLine("2-» Listar personajes");
            Console.SetCursorPosition(43, 14); Console.WriteLine("3-» Buscar personajes");
            Console.SetCursorPosition(44, 18); Console.WriteLine("4-» Menú principal");
            Console.SetCursorPosition(51, 20); opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion)
                {
                    case 1:

                        Console.SetCursorPosition(43, 6); Console.WriteLine("     Pagina en proceso       ");
                        Console.SetCursorPosition(43, 10); Console.WriteLine("    Pagina en proceso       ");
                        Console.SetCursorPosition(43, 14); Console.WriteLine("    Pagina en proceso       ");
                        break;
                    case 2:

                        Console.SetCursorPosition(43, 6); Console.WriteLine("     Pagina en proceso       ");
                        Console.SetCursorPosition(43, 10); Console.WriteLine("    Pagina en proceso       ");
                        Console.SetCursorPosition(43, 14); Console.WriteLine("    Pagina en proceso       ");
                        break;
                    case 3:

                        Console.SetCursorPosition(43, 6); Console.WriteLine("     Pagina en proceso       ");
                        Console.SetCursorPosition(43, 10); Console.WriteLine("    Pagina en proceso       ");
                        Console.SetCursorPosition(43, 14); Console.WriteLine("    Pagina en proceso       ");
                        break;
                    case 4:
                        Console.SetCursorPosition(44, 23); Console.WriteLine("Saliendo de pagina");
                        break;
                    default:
                        Console.SetCursorPosition(46, 18); Console.WriteLine("Opcion incorrecta");
                        break;
                        Console.SetCursorPosition(37, 24); Console.WriteLine("»-» Presione tecla para continuar «-«");

                       
                }
                Console.ReadKey();

            } while (opcion != 4);

        }

        
    }
}
