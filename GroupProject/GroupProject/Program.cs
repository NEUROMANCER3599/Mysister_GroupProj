using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GroupProject
{
    internal class Program
    {
        public static string[] KarmaRecord = new string[1]; //Karma Record System for each steps to ending
        public static int KarmaRecordIndex = 0; //Step index
        static void Main(string[] args)
        {
            MainBranch();
        }
        public static void MainBranch()
        {
            bool isValid;
            isValid = false;
            //introduction
            Console.WriteLine("\"Let's go home\"");
            Console.WriteLine("welcome to a game where \"you\" try to help go back home");
            Console.Write("\nBy the way, What is your name? : ");
            string playername = Console.ReadLine();

            Console.WriteLine("\"So, " + playername + " is your name!\"");
            Console.WriteLine("\"You will try to make it back home by making choices! Simple, right?\"");
            Console.WriteLine("\"Goodluck then, " + playername + ".\"");


            //start the game
            Console.WriteLine("\n\"You woke up on the sidewalk, next to you are bunches of beautiful flower.\"");
            Console.WriteLine("\"You wonder whom is it for?\"");

            //first choice
            Console.WriteLine("\"You Start walking straight ahead along the road.\"");
            Console.WriteLine("\"Thinking to yourself,trying to remember how did you ended up here.\"");
            Console.WriteLine("\n\"You Came across junction!\"");
            Console.WriteLine("\"Which way will you choose?\"");
            Console.WriteLine(">> (1) Left");
            Console.WriteLine(">> (2) Right");

            while (!isValid)
            {
                Console.Write("\nYour choice is: ");
                int choice1 = Convert.ToInt32(Console.ReadLine());
                switch (choice1)
                {
                    case 1:
                        TurnLeft();
                        isValid = true;
                        break;
                    case 2:
                        TurnRight();
                        isValid = true;
                        break;
                    default:
                        Console.WriteLine("You only got two choices");
                        break;
                }
            }
        }
        //Turning left stories
        public static void TurnLeft()
        {


            Console.WriteLine("\nYou choose to go left");
            Console.WriteLine("\n\"You walk into a dark alley which you have a feeling that it will be a shortcut.\"");
            Console.WriteLine("\"You come upon a homeless man sitting on a side of the road.\"");
            Console.WriteLine("\"He is begging for money and you have some pocket money with you.\"");
            Console.WriteLine("\nWhat do you want to do?");
            Console.WriteLine(">> (1) Give him money");
            Console.WriteLine(">> (2) Turned him down");

            bool isValid = false;
            while (!isValid)
            {
                Console.Write("\nYour choice is: ");
                int choice2 = Convert.ToInt32(Console.ReadLine());
                if (choice2 == 1)
                {
                    //Good Karma
                    Console.WriteLine("\n\"He seems in a bad place, You hope this little money could help him out.\"");
                    Console.WriteLine("\"Despite a small amount you gave him, He seem to be happy.\"");
                    Console.WriteLine("\"He reach back and handed me a glass bottle and said something along the line that it will be useful.\"");

                    Left1();
                    isValid = true;
                }
                else if (choice2 == 2)
                {
                    Console.WriteLine("\n\"He seems really mad and quickly latches up to you.\"");
                    Console.WriteLine("\"He hit you in the head, you fell down and never come back up.\"");
                    Console.WriteLine("\n You earned a \"Karma hits hard\" ending");
                    RestartCheck();
                    isValid = true;
                }
                else
                {
                    Console.WriteLine("You only get two choice");
                }
            }
        }

        public static void Left1()
        {
            KarmaRecordIndex = 0; // 1st Step
            Console.WriteLine("\n\"You continue walking ahead down the dark alley.\"");
            Console.WriteLine("\"You come upon piles of trash, it smelled pretty bad here so let move quickly.\"");
            Console.WriteLine("\"When suddenly you hear a loud meowing sound out of no where.\"");
            Console.WriteLine("\"There is a cat lay behind one of the trash bad, it seems to be badly injured.\"");
            Console.WriteLine("\nWhat do you want to do?");
            Console.WriteLine(">> (1) Help the cat");
            Console.WriteLine(">> (2) Leave it be");

            bool isValid = false;
            while (!isValid)
            {
                Console.Write("\nYour choice is: ");
                int choice2 = Convert.ToInt32(Console.ReadLine());
                if (choice2 == 1)
                {
                    //Good Karma
                    Console.WriteLine("\n\"You look around for something that could cover up its wound.\"");
                    Console.WriteLine("\"You found some rag cloth that is clean enough to use.\"");
                    Console.WriteLine("\"You then tied that cloth to the cat's leg hoping to at least stop the bleeding before you go on your way.\"");
                    KarmaRecord[KarmaRecordIndex] = "Good"; //Record Good Karma For 2nd Step
                    Left2();
                    isValid = true;
                }
                else if (choice2 == 2)
                {
                    //Bad Karma
                    Console.WriteLine("\n\"You decide to walk away, leaving that poor cat alone to face its cruel fate\"");
                    Console.WriteLine("\"Walking away despite that fact that you could have help it.\"");
                    Console.WriteLine("\"But it wasn't your problem, right?\"");
                    KarmaRecord[KarmaRecordIndex] = "Bad"; //Record Bad Karma For 2nd Step
                    Left2();
                    isValid = true;
                }
                else
                {
                    Console.WriteLine("You only get two choice");
                }
            }
        }

        public static void Left2()
        {
            KarmaRecordIndex = 1; // 2nd Step
            Console.WriteLine("\n\"You continue your journey into the alley.\"");
            Console.WriteLine("\"Until you stopped in your track, There is a big dog approching you.\"");
            Console.WriteLine("\"The dog seems mad and look like it could attack you in any moment.\"");
            Console.WriteLine("\"You remembered that you have the bottle from the homeless man.\"");
            Console.WriteLine("\nWhat do you want to do with it?");
            Console.WriteLine(">> (1) Use the bottle against the dog");
            Console.WriteLine(">> (2) Find another solution");

            bool isValid = false;
            while (!isValid)
            {
                Console.Write("\nYour choice is: ");
                int choice2 = Convert.ToInt32(Console.ReadLine());
                if (choice2 == 1)
                {
                    //Bad Karma
                    Console.WriteLine("\n\"You swing the glass bottle as the dog run up to you.\"");
                    Console.WriteLine("\"The bottle shatter upon the impact with the dog.\"");
                    Console.WriteLine("\"The dog looks hurt before it flee away with limping leg.\"");
                    KarmaRecord[KarmaRecordIndex] = "Bad"; //Record Bad Karma For 2nd Step
                    Left3();
                    isValid = true;
                }
                else if (choice2 == 2)
                {
                    Console.WriteLine("\n\"You don't want to retort to violence yet, so you try find to another way around.\"");
                    Console.WriteLine("\"You looking around until your eyes catches a glimsp of something on the ground.\"");
                    Console.WriteLine("\"It's a piece of chicken nugget! You picked in up and toss it to the dog, hoping to distract it.\"");
                    Console.WriteLine("\"The dog smell the chicken nugget before eating it, it seems happy and move out of your way.\"");
                    KarmaRecord[KarmaRecordIndex] = "Good"; //Record Bad Karma For 2nd Step
                    Left3();
                    isValid = true;
                }
                else
                {
                    Console.WriteLine("You only get two choice");
                }
            }
        }

        public static void Left3()
        {
            if (KarmaRecord[0] == "Good" && KarmaRecord[1] == "Good") //Saved both cat & dog scenario
            {

            }
            else if (KarmaRecord[0] == "Bad" && KarmaRecord[1] == "Good") //Save only dog scenario
            {

            }
            else if (KarmaRecord[0] == "Good" && KarmaRecord[1] == "Bad") // Save only cat scenario
            {

            }
            else if(KarmaRecord[0] == "Bad" && KarmaRecord[1] == "Bad") // Save none scenario
            {

            }

        }

        //Turning Right stories
        public static void TurnRight()
        {
            Console.WriteLine("\nYou choose to go right");
            Console.WriteLine("\n\"You walk into a dark alley which you have a feeling that it will be a shortcut.\"");
            Console.WriteLine("\"You come upon a homeless man sitting on a side of the road.\"");
            Console.WriteLine("\"He is begging for money and you have some pocket money with you.\"");
            Console.WriteLine("\nWhat do you want to do?");
            Console.WriteLine(">> (1) Give him money");
            Console.WriteLine(">> (2) Turned him down");

            bool isValid = false;
            while (!isValid)
            {
                Console.Write("\nYour choice is: ");
                int choice2 = Convert.ToInt32(Console.ReadLine());
                if (choice2 == 1)
                {
                    Console.WriteLine("\n\"He seems in a bad place, You hope this little money could help him out.\"");
                    Console.WriteLine("\"Despite a small amount you gave him, He seem to be happy.\"");
                    Console.WriteLine("\"He reach back and handed me a glass bottle and said something along the line that it will be useful.\"");
                    Left1();
                    isValid = true;
                }
                else if (choice2 == 2)
                {
                    Console.WriteLine("\n\"He seems really mad and quickly latches up to you.\"");
                    Console.WriteLine("\"He hit you in the head, you fell down and never come back up.\"");
                    Console.WriteLine("\n You earned a \"Karma hits hard\" ending");
                    RestartCheck();
                    isValid = true;
                }
                else
                {
                    Console.WriteLine("You only get two choice");
                }
            }
        }

        //Restart system
        public static void RestartCheck()
        {
            bool isValid;
            isValid = false;

            while (!isValid)
            {
                Console.WriteLine("\nWould you like to restart the game? | Yes/No ");
                string restartinput = Console.ReadLine();
                if (restartinput == "Yes" || restartinput == "yes")
                {
                    MainBranch();
                    isValid = true;
                }
                else if (restartinput == "No" || restartinput == "no")
                {
                    isValid = true;
                }
                else
                {
                    Console.WriteLine("\nInvalid Input");
                }
            }
        }
    }
}
