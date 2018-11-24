using System;
using System.Collections.Generic;
using System.Linq;

namespace ArraysAndListsLesson055
{
    class MainClass
    {

        public static void DoExercise_1()
        {
            var maxNames = 2;
            var names = new string[maxNames];
            int likesCount = 0;

            while(true)
            {
                Console.Write("Add name for facebook like: ");
                string name = Console.ReadLine();
                if(string.IsNullOrEmpty(name))
                {
                    break;
                }
                if (likesCount < maxNames)
                {
                    names[likesCount] = name;
                }
                likesCount++;
            }

            if (likesCount == 1)
            {
                Console.WriteLine("{0} likes your post", names[0]);
            }
            else if (likesCount == 2)
            {
                Console.WriteLine("{0} and {1} like your post", names[0], names[1]);
            }
            else if(likesCount > 2)
            {
                Console.WriteLine("{0}, {1} and {2} others like your post", names[0], names[1], likesCount - maxNames);
            }
        }

        private static void DoExercise_2()
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            char[] characters = name.ToCharArray();
            Array.Reverse(characters);

            var reverseName = string.Empty;
            foreach(var ch in characters)
            {
                reverseName += ch;
            }
            Console.WriteLine("Your name in reverse is: {0}", reverseName);
        }

        private static void DoExercise_3()
        {
            Console.WriteLine("Enter five unique integers:");
            List<int> l = new List<int>();
            do
            {
                Console.Write("Number {0}: ", l.Count + 1);
                int value = int.Parse(Console.ReadLine());
                if(l.Exists(v => v == value))
                {
                    Console.WriteLine("Value already exists!");
                }
                else
                {
                    l.Add(value);
                }
            } while (l.Count < 5);

            l.Sort();

            Console.WriteLine(string.Join(", ", l));
        }

        private static void DoExercise_4()
        {

            Console.WriteLine("Write a number or write 'Quit' to exit: ");
            var numbers = new List<int>();
            while(true)
            {
                string answer = Console.ReadLine().ToLower();
                if(answer.Equals("quit"))
                {
                    break;
                }
                else
                {
                    int number = int.Parse(answer);
                    numbers.Add(number);
                }
            }

            Console.WriteLine("Unique numbers entered by user:");
            var uniqueNumbers = numbers.Distinct<int>();
            foreach(var nr in uniqueNumbers)
            {
                Console.WriteLine(nr);
            }

        }

        private static void DoExercise_5()
        {
            Console.WriteLine("Write a list of at least five numbers separated with coma sign e.g 1,2,3,4,5,6:");

            string[] values;
            while(true)
            {
                string answer = Console.ReadLine();
                values = answer.Split(',');
                if (values.Length >= 5)
                {
                    break;
                }
                Console.WriteLine("Invalid list, try again:");
            }

            int[] numbers = Array.ConvertAll<string, int>(values, int.Parse);

            Array.Sort(numbers);
            foreach(var number in numbers)
            {
                Console.WriteLine(number);
            }
        }

        public static void Main(string[] args)
        {
            bool quit = false;
            while(!quit)
            {
                Console.WriteLine("Choose exercise");
                Console.WriteLine("1.Facebook likes\n2.Reversed name\n3.Sort five numbers\n4.Unique numbers\n5.Three smallest numbers");

                int exerciseNr = int.Parse(Console.ReadLine());

                switch(exerciseNr)
                {
                    case 1:
                        DoExercise_1();
                        break;
                    case 2:
                        DoExercise_2();
                        break;
                    case 3:
                        DoExercise_3();
                        break;
                    case 4:
                        DoExercise_4();
                        break;
                    case 5:
                        DoExercise_5();
                        break;
                    default:
                        Console.WriteLine("No such exercise!");
                        break;
                }

                Console.Write("Quit? (y/n): ");
                quit = Console.ReadLine().ToLower() == "y";
            }
        }

    }
}
