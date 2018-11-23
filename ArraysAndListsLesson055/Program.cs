using System;

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

        }

        public static void Main(string[] args)
        {
            bool quit = false;
            while(!quit)
            {
                Console.WriteLine("Choose exercise");
                Console.WriteLine("1.Facebook likes\n2.Reversed name");

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
