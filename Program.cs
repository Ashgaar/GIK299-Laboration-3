using System;
using System.Diagnostics;
using System.Linq;
using System.Collections.Generic;

namespace Laboration_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = mainMenu();
            }
        }
        private static bool mainMenu()
        {
            //Skriver ut de olika alternativen.
            Console.WriteLine("Välj ett alternativ");
            Console.WriteLine("1. Gångertabellen");
            Console.WriteLine("2. Summa, medelvärde, högsta och lägsta");
            Console.WriteLine("3. RNG");
            Console.WriteLine("4. Personer");
            Console.WriteLine("5. Avsluta");

            Console.Write("Välj ett alternativ: ");

            switch (Console.ReadLine())
            {
                case "1":
                    MultiplicationTable();
                    return true;
                case "2":
                    TotalAverageHighestLowest();
                    return true;
                case "3":
                    RandomNumberGenerator();
                    return true;
                case "4":
                    InformationAboutPerson();
                    return true;
                case "5":
                    Environment.Exit(0);
                    return false;
                default:
                    return true;
            }
        }
        private static void MultiplicationTable()
        {
            //Loopar igenom och skriver ut multiplikationstabellen.
            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    int result = i * j;
                    Console.Write("{0} * {1} = {2}\t", i, j, result);
                }
                Console.WriteLine("");
            }
        }
        private static void TotalAverageHighestLowest()
        {
            //Frågar hur många tal man vill ha.
            Console.Write("Skriv in hur många tal du vill ha: ");
            int lengthArray = Int32.Parse(Console.ReadLine());

            //Sätter längden på arrayen.
            int[] numbers = new int[lengthArray];

            //Frågar efter nummer.
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("Fyll i nummer: ");
                int numbersArray = Int32.Parse(Console.ReadLine());
                numbers[i] = numbersArray;
            }

            //Beräkningar.
            int biggest = numbers.Max();
            int smallest = numbers.Min();
            int total = numbers.Sum();
            float average = (numbers.Sum() / (float)lengthArray);

            //Skriver ut beräkningarna
            Console.WriteLine("{0} är störst och {1} är minst. Medelvärdet är {2} och summan är {3}.", biggest, smallest, average, total);
        }

        private static void RandomNumberGenerator()
        {
            //Frågar hur många tal som arrayen skall inkludera.
            Console.Write("Hur många tal vill du ha: ");
            int lengthArray = Int32.Parse(Console.ReadLine());

            //Deklarerar max och min värdet.
            int Min = 0;
            int Max = int.MaxValue;

            //Sätter längden på arrayen.
            int[] randomNumbers = new int[lengthArray];

            //Randomizing the numbers hells yeah brothers.
            Random randNum = new Random();
            for (int i = 0; i < randomNumbers.Length; i++)
            {
                randomNumbers[i] = randNum.Next(Min, Max);
            }

            //Sorterar arrayen.
            Array.Sort(randomNumbers);

            //Skriver ut arrayen.
            Console.WriteLine("{0}", string.Join(", ", randomNumbers));
        }

        private static void InformationAboutPerson()
        {
            bool ShowSubMenu = true;
            while (ShowSubMenu)
            {
                ShowSubMenu = SubMenu();
            }
        }

        public static bool SubMenu()
        {
            Console.WriteLine("Välj ett alternativ");
            Console.WriteLine("1. Visa alla personer");
            Console.WriteLine("2. Lägg till en person");
            Console.WriteLine("3. Avsluta");

            switch (Console.ReadLine())
            {
                case "1":
                    PrintAllPersons();
                    return true;
                case "2":
                    CreateAPerson();
                    return true;
                case "3":
                    return false;
                default:
                    return true;
            }
        }
        static List<Person> ListOfPersons = new List<Person>();
        private static void CreateAPerson()
        {
            Console.Write("Ange personens namn: ");
            string name = Console.ReadLine();

            Console.Write("Ange {0}s kön: ", name);
            string gender = Console.ReadLine();

            Console.Write("Ange {0}s hårfärg: ", name);
            string hairColor = Console.ReadLine();

            int hairLength;
            Console.Write("Ange {0}s hårlängd(cm): ", name);
            while (!Int32.TryParse(Console.ReadLine(), out hairLength))
            {
                Console.Write("Skriv endast in nummer: ");
            };

            Console.Write("Ange {0}s ögonfärg: ", name);
            string eyeColor = Console.ReadLine();

            DateTime birthday;
            Console.Write("Ange {0}s födelsedag(MM-DD-ÅÅÅÅ): ", name);
            while (!DateTime.TryParse(Console.ReadLine(), out birthday))
            {
                Console.Write("Skriv in ett korrekt datum (MM-DD-ÅÅÅÅ): ");
            }

            Person person = new Person(name, gender, birthday, eyeColor, hairColor, hairLength);

            ListOfPersons.Add(person);
        }

        public static void PrintAllPersons()
        {
            foreach (var person in ListOfPersons)
            {
                Console.WriteLine(person);
            }
        }
    }
}
