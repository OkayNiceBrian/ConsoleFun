using System;

namespace ConsoleFun
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            int distance = 0;

            Console.WriteLine("Hello, adventurer! What's your name?");
            string name = Console.ReadLine();

            Player player = new Player(name);

            Console.WriteLine(player.getName() + "... Oof... glad I didn't have your parents.");
            pressEnter();
            Console.WriteLine("Welp, let's begin!");

            while (player.getHealth() > 0)
            {
                distance++;
                string fightOrRun = "";
                string animal = getAnimal();
                while (!Array.Exists(fightOrRunAnswers, element => element == fightOrRun))
                {
                    Console.WriteLine(player.getName() + " travels ever further down the path of truth...");
                    pressEnter();
                    Console.WriteLine("A wild " + animal + " attacks! Will you fight or run?");
                    fightOrRun = Console.ReadLine().ToLower();
                    if (!Array.Exists(fightOrRunAnswers, element => element == fightOrRun))
                    {
                        Console.WriteLine("Oops! You typed an invalid answer... You musta been raised wrong.");
                        pressEnter();
                    }
                }

                if (fightOrRun.Equals("fight") || fightOrRun.Equals("f"))
                {
                    Console.WriteLine("You chose to fight!");
                    pressEnter();
                    int outcome = rand.Next(0, 2);
                    if (outcome == 0)
                    {
                        int damage = rand.Next(5, 50);
                        Console.WriteLine("That " + animal + " fucked you up. You took " + damage + " damage.");
                        player.takeDamage(damage);
                        pressEnter();
                    } else
                    {
                        Console.WriteLine("You did it! You brutally murdered that " + animal + "! Hope you feel proud of yourself...");
                        pressEnter();
                    }
                } else
                {
                    Console.WriteLine("You chose to run!");
                    pressEnter();
                    int outcome = rand.Next(0, 2);
                    if (outcome == 0)
                    {
                        int damage = rand.Next(5, 50);
                        Console.WriteLine("That " + animal + " was faster than you expected. You took " + damage + " damage. Rough biz.");
                        player.takeDamage(damage);
                        pressEnter();
                    }
                    else
                    {
                        Console.WriteLine("You ran away from that " + animal + "! Who ever raised such a coward?");
                        pressEnter();
                    }
                }
                
            }
            Console.WriteLine("Congrats! You died! You made it " + distance + " steps toward true enlightenment. Better luck next time!");

        }

        static void pressEnter()
        {
            Console.WriteLine("(Press enter to continue)");
            Console.ReadKey();
            Console.WriteLine();
        }

        static string[] animals = { "goat", "pig", "chicken", "wolverine", "wildabeast", "penguin", "zebra", "leopard", "cat", "frog", "human", "isopod", "seaslug", "pufferfish", "hammerhead shark", "pteradactyl", "unicorn" };

        static string getAnimal()
        {
            Random r = new Random();
            int randomInt = r.Next(0, animals.Length - 1);
            return animals[randomInt];
        }

        static string[] fightOrRunAnswers = { "fight", "f", "run", "r" };
    }
}
