using System;
namespace Uppgift_6._3
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Detta är ett Meny Program");
            string användarensVal = "";


            while (användarensVal != "3")
            {
                Meny();
                användarensVal = Console.ReadLine();
                Console.WriteLine();

                switch (användarensVal)
                {
                    case "1":
                        MenyValAddera();
                        break;

                    case "2":
                        MenyValStörstaTalet();

                        break;

                    case "3":
                        Console.WriteLine("Programmet kommer att avlsutas.....");
                        break;
                    default:
                        Console.WriteLine("Ågiltig val!");
                        break;
                }
                Console.WriteLine();
            }
        }

        static void Meny()
        {
            Console.WriteLine("Välj ett av alternativen");
            Console.WriteLine("1. Addera två tal");
            Console.WriteLine("2. Stärsta talet av två tal");
            Console.WriteLine("3. Avslta Programmet");
        }

        static void MenyValAddera()
        {
            Console.WriteLine("Skriv in tre tal som du ska addera ihåp:");
            int tal1 = int.Parse(Console.ReadLine());
            int tal2 = int.Parse(Console.ReadLine());
            int tal3 = int.Parse(Console.ReadLine());

            Console.WriteLine(tal1 + tal2 + tal3);
        }

        static int Störst(int tal1, int tal2)
        {


            if (tal1 > tal2)
            {
                return tal1;
            }
            else
            {
                return tal2;
            }

        }
        static void MenyValStörstaTalet()
        {
            Console.WriteLine("skriv in två tal för att ta reda på vilket av talen som är störst:");
            int tal1 = int.Parse(Console.ReadLine());
            int tal2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"Det Största tal är:{Störst(tal1, tal2)}");
        }
    }
}