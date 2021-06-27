using System;
using static System.Console;

/* Generate a Star Trek OC!
 * Created by @_tempvoid on twt
 * with help from my friend Karen!!
 */

namespace warmup
{
    class MainClass
    {
        static Character Chara = new Character();
        string choice;

        public static void Main()
        {

            WriteLine("Welcome to @_tempvoid's Star Trek OC generator!");
            WriteLine("Elements of this generator was taken from Star Trek: Adventures, the TTRPG," +
                "\notherwise, this was coded by me with help from a friend.");
            Run();

        }

        /*
         * a method which basically an enclosed loop! 
         * thank you to my programming teacher, Janell,
         * for this lol
         */
        private static void Run()
        {
            WriteLine("Type 'Engage' to generate a character, or 'Exit' to exit.");
            string choice = ReadLine();
            choice = choice.ToLower();

            if (choice == "engage")
            {
                Chara.describe();
                WriteLine("Press any key to continue.");
                ReadKey();
                Clear();

                /*
                 * at the end of each statement, the method is called
                 * again so that it loops back to the start of it!
                 */
                Run();
            }


            else if (choice == "exit")
            {
                WriteLine("Press any key to exit program");
                ReadKey();
            }


            else
            {
                WriteLine("Please type the options given; Generate or Exit.");
                WriteLine("Press any key to continue...");
                ReadKey();
                Clear();
                Run();
            }
        }

    }
}
