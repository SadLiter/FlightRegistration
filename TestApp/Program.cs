using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TestApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sectors = { 6, 28, 15, 15, 17 };

            bool isOpen = true;

            while (isOpen)
            {
                Console.SetCursorPosition(0, 18);
                for (int i = 0; i < sectors.Length; i++)
                {
                    Console.WriteLine($"There are {sectors[i]} seats available in Sector {i + 1}");
                }

                Console.SetCursorPosition(0, 0);
                Console.WriteLine("Flight registration");
                Console.WriteLine("\n\nChoose your action\n\n1 - book seats\n\n2 - exit the program");
                Console.Write("\nYour choice: ");
                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        Console.Write("Please enter a sector: ");
                        int userSector = Convert.ToInt32(Console.ReadLine()) - 1;
                        if (sectors.Length <= userSector || userSector < 0)
                        {
                            Console.WriteLine("That sector doesn't exist!");
                        }
                        Console.Write("Please enter how many seats you wish to book: ");
                        int userPlaceAmount = Convert.ToInt32(Console.ReadLine());
                        if (sectors[userSector] < userPlaceAmount)
                        {
                            Console.WriteLine($"There are not enough seats in the sector. Seats available: {sectors[userSector]}");
                            break;
                        }
                        if (userPlaceAmount <= 0)
                        {
                            Console.WriteLine("You have entered an incorrect number!");
                            break;
                        }
                        sectors[userSector] -= userPlaceAmount;
                        break;
                    case 2:
                        isOpen = false;
                        Console.Clear();
                        Console.WriteLine("You've successfully exited!");
                        break;
                }
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
