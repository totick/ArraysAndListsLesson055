using System;
using System.Collections.Generic;

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

        public static void Main(string[] args)
        {
            bool quit = false;
            while(!quit)
            {
                Console.WriteLine("Choose exercise");
                Console.WriteLine("1.Facebook likes");

                int exerciseNr = int.Parse(Console.ReadLine());

                switch(exerciseNr)
                {
                    case 1:
                        DoExercise_1();
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
