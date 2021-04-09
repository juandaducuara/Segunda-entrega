using System;
using System.Collections.Generic;
using System.Text;

namespace Repaso
{
    class pantalla
    {
        public void pantalla1()
        {

            for (int i = 30; i <= 79; i++)
            {

                Console.SetCursorPosition(i, 0); Console.WriteLine("═");
                Console.SetCursorPosition(30, 25); Console.Write("╚");
                Console.SetCursorPosition(80, 25); Console.Write("╝");
                Console.SetCursorPosition(30, 0); Console.Write("╔");
                Console.SetCursorPosition(80, 0); Console.Write("╗");
                Console.SetCursorPosition(i, 25); Console.WriteLine("═");
                Console.SetCursorPosition(i, 4); Console.WriteLine("═");
                Console.SetCursorPosition(31, 4); Console.WriteLine("▒");
                Console.SetCursorPosition(79, 4); Console.WriteLine("▒");
                Console.SetCursorPosition(i, 8); Console.WriteLine("═");
                Console.SetCursorPosition(31, 8); Console.WriteLine("▒");
                Console.SetCursorPosition(79, 8); Console.WriteLine("▒");
                Console.SetCursorPosition(i, 12); Console.WriteLine("═");
                Console.SetCursorPosition(31, 12); Console.WriteLine("▒");
                Console.SetCursorPosition(79, 12); Console.WriteLine("▒");
                Console.SetCursorPosition(i, 16); Console.WriteLine("═");
                Console.SetCursorPosition(31, 16); Console.WriteLine("▒");
                Console.SetCursorPosition(79, 16); Console.WriteLine("▒");
                Console.SetCursorPosition(48, 21); Console.Write("╚");
                Console.SetCursorPosition(54, 21); Console.Write("╝");
                Console.SetCursorPosition(48, 19); Console.Write("╔");
                Console.SetCursorPosition(54, 19); Console.Write("╗");

            }
            for (int i = 1; i <= 24; i++)
            {
                Console.SetCursorPosition(30, i); Console.WriteLine("║");

                Console.SetCursorPosition(80, i); Console.WriteLine("║");
            }
        }

        public void pantalla2()
        {

            for (int i = 30; i <= 79; i++)
            {

                Console.SetCursorPosition(i, 0); Console.WriteLine("═");
                Console.SetCursorPosition(30, 25); Console.Write("╚");
                Console.SetCursorPosition(80, 25); Console.Write("╝");
                Console.SetCursorPosition(30, 0); Console.Write("╔");
                Console.SetCursorPosition(80, 0); Console.Write("╗");
                Console.SetCursorPosition(i, 25); Console.WriteLine("═");
                Console.SetCursorPosition(i, 4); Console.WriteLine("═");
                Console.SetCursorPosition(31, 4); Console.WriteLine("▒");
                Console.SetCursorPosition(79, 4); Console.WriteLine("▒");
                Console.SetCursorPosition(i, 8); Console.WriteLine("═");
                Console.SetCursorPosition(31, 8); Console.WriteLine("▒");
                Console.SetCursorPosition(79, 8); Console.WriteLine("▒");
                Console.SetCursorPosition(i, 12); Console.WriteLine("═");
                Console.SetCursorPosition(31, 12); Console.WriteLine("▒");
                Console.SetCursorPosition(79, 12); Console.WriteLine("▒");
                Console.SetCursorPosition(i, 16); Console.WriteLine("═");
                Console.SetCursorPosition(31, 16); Console.WriteLine("▒");
                Console.SetCursorPosition(79, 16); Console.WriteLine("▒");


            }
            for (int i = 1; i <= 24; i++)
            {
                Console.SetCursorPosition(30, i); Console.WriteLine("║");

                Console.SetCursorPosition(80, i); Console.WriteLine("║");
            }
        }
    }
}
