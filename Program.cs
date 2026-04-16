using System;

class Program
{
    static void Main()
    {
        bool playAgain = true;

        while (playAgain)
        {
            User user = new User(25);
            Inventory inventory = new Inventory();
            VendingMachine vm = new VendingMachine(inventory);
            
                   Console.WriteLine("");
                    Console.WriteLine("╔═══════════════════════════════════════╗");
                    Console.WriteLine("║   SUPER NICE GOGO-GETTER 3000         ║");
                    Console.WriteLine("╚═══════════════════════════════════════╝");
                    Console.WriteLine("");
                   Console.WriteLine("It's 1999. You should probably buy some Gogo's");


            bool running = true;

            while (running)
            {
     

                PrintMainMenu();
                Console.Write("Choose: ");

                string choice = Console.ReadLine() ?? "";

                switch (choice)
                {
                    case "1":
                        BuySectionLoop(vm, user);
                        break;

                    case "2":
                        ShowNiklasReaction(user, ref running);
                        break;

                    case "3":
                        PrintMoneyDisplay(user);
                        break;

                    case "4":

                        int count = user.GetTotalCount();

                        PrintGameEnding(count, user);

                        running = false;
                        break;

                    default:
                    Console.WriteLine();
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
                }
            }

            Console.WriteLine();
            Console.Write("Play again? (yes/no): ");
            string resetChoice = Console.ReadLine() ?? "";

            if (resetChoice.ToLower() != "yes" && resetChoice.ToLower() != "y")
            {
                playAgain = false;
            }
        }
    }

    static void BuySectionLoop(VendingMachine vm, User user)
            {
                bool buyingDone = false;

                while (!buyingDone)
                {
                    PrintProductMenu(vm, user);
                    Console.Write("Enter number to buy: ");

                    if (int.TryParse(Console.ReadLine(), out int productChoice))
                    {
                        if (productChoice == 0)
                        {
                            Console.WriteLine();
                            
                            Console.WriteLine("═══════════════════════════════════════");
                            buyingDone = true;
                        }
                        else
                        {
                            vm.BuyProduct(productChoice, user);
                            Console.WriteLine();
                            Console.WriteLine("═══════════════════════════════════════");
                            Console.WriteLine();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input.");
                        Console.WriteLine();
                    }
                }
            }

    static void ShowNiklasReaction(User user, ref bool running)
    {
        int count = user.GetTotalCount();

        if (count == 0)
        {
            Console.WriteLine();
            Console.WriteLine("You have 0 Gogo's. Niklas feels misled and angrily walks away.");
                    return;
                }

                if (user.HasGold())
                {
                    Console.WriteLine();
                    Console.WriteLine("╔═══════════════════════════════════════╗");
                    Console.WriteLine("║           GOLDEN GOGO'S REACTION      ║");
                    Console.WriteLine("╚═══════════════════════════════════════╝");
                    Console.WriteLine();
                    Console.WriteLine("Is that a golden Gogo's!?");
                    Console.WriteLine("Niklas becomes very excited and begs you for it!");
                    Console.WriteLine("Do you give it to him?");
                    Console.WriteLine();
                    Console.WriteLine("  1. Yes");
                    Console.WriteLine("  2. No");
                    Console.WriteLine();

                    string giveChoice = Console.ReadLine() ?? "";

                    if (giveChoice == "1")
                    {
                        user.RemoveGold();
                        Console.WriteLine("╔═══════════════════════════════════════╗");
                        Console.WriteLine("║                 Yes                   ║");
                        Console.WriteLine("╚═══════════════════════════════════════╝");
                        Console.WriteLine();
                        Console.WriteLine("You give Niklas the Golden Gogo's.");
                        Console.WriteLine("He is incredibly thankful and lets you pet his hedgehog.");
                        Console.WriteLine();
                        Console.WriteLine("                                     \\ / \\/ \\/ / ,");
                        Console.WriteLine("                                   \\ /  \\/ \\/  \\/  / ,");
                        Console.WriteLine("                                 \\ \\ \\/ \\/ \\/ \\ \\/ \\/ /");
                        Console.WriteLine("                               .\\  \\/  \\/ \\/ \\/  \\/ / / /");
                        Console.WriteLine("                              '  / / \\/  \\/ \\/ \\/  \\/ \\ \\/ \\");
                        Console.WriteLine("                           .'     ) \\/ \\/ \\/ \\/  \\/  \\/ \\ / \\");
                        Console.WriteLine("                          /   o    ) \\/ \\/ \\/ \\/ \\/ \\/ \\// /");
                        Console.WriteLine("                        o'_ ',__ .'   ,.,.,.,.,.,.,.,'- '%");
                        Console.WriteLine("                                 // \\\\          // \\\\        ");
                        Console.WriteLine("                                ''  ''         ''  ''");
                        Console.WriteLine();
                        Console.WriteLine("You live happily ever after.");
                        Console.WriteLine("Yet sometimes, in the middle of the night, you wake up and wonder what might have been.");
                        Console.WriteLine();
                        Console.WriteLine("╔═══════════════════════════════════════╗");
                        Console.WriteLine("║          ----- THE END -----          ║");
                        Console.WriteLine("╚═══════════════════════════════════════╝");
                        running = false;
                    }
                    else
                    {
                        Console.WriteLine("╔═══════════════════════════════════════╗");
                        Console.WriteLine("║          ----- NO!-----               ║");
                        Console.WriteLine("╚═══════════════════════════════════════╝");
                        Console.WriteLine();
                        Console.WriteLine("Niklas starts crying.");
                        Console.WriteLine("You slowly walk away...");
                        Console.WriteLine();
                        Console.WriteLine("═══════════════════════════════════════");
                        Console.WriteLine("It's 25 years later...");
                        Console.WriteLine("═══════════════════════════════════════");
                        Console.WriteLine("You are now the head of a successful company, making millions of dollars and are extremely popular.");
                        Console.WriteLine();

                        Console.WriteLine("Sometimes, while grocery shopping, you think you see Niklas outside selling BingoLotter.");
                        Console.WriteLine("But you're never quite sure, since you can't make out his face underneath years of bad life decisions.");
                        
                        Console.WriteLine();

                        Console.WriteLine("╔═══════════════════════════════════════╗");
                        Console.WriteLine("║          ----- THE END -----          ║");
                        Console.WriteLine("╚═══════════════════════════════════════╝");

                        running = false;
                    }

                    return;
                }

                Console.WriteLine();
                Console.WriteLine("╔═══════════════════════════════════════╗");
                Console.WriteLine("║           NIKLAS'S REACTION           ║");
                Console.WriteLine("╚═══════════════════════════════════════╝");
                Console.WriteLine();

                if (count == 1)
                {
                    Console.WriteLine($"Only one Gogo's? And a {user.GetAllItemsAsText()} at that? Pathetic.");
                    Console.WriteLine("Niklas looks away in disgust.");
                }
                else if (count <= 2)
                {
                    Console.WriteLine($"You show Niklas {count} Gogo's.");
                    Console.WriteLine("He's not very impressed. You should buy more gogo's.");
                }
                else if (count <= 4)
                {
                    Console.WriteLine($"You show Niklas your collection: {user.GetAllItemsAsText()}.");
                    Console.WriteLine("He's pretty excited by all the colors!");
                }
                else
                {
                    Console.WriteLine($"You show Niklas your collection: {user.GetAllItemsAsText()}.");
                    Console.WriteLine("Wow, you sure do have a lot of gogo's!");
                }
                
                Console.WriteLine();
                Console.WriteLine("═══════════════════════════════════════");
            }

    static void PrintMainMenu()
    {
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("  1. Buy Gogo's");
        Console.WriteLine("  2. Show Gogo's collection to Niklas");
        Console.WriteLine("  3. Check my money");
        Console.WriteLine("  4. Exit Game");
        Console.WriteLine();
    }

    static void PrintProductMenu(VendingMachine vm, User user)
            {
                Console.WriteLine();
                Console.WriteLine("╔═══════════════════════════════════════╗");
                Console.WriteLine("║           AVAILABLE GOGO'S            ║");
                Console.WriteLine("╚═══════════════════════════════════════╝");
                Console.WriteLine();
                vm.ShowProducts();
                Console.WriteLine();
                Console.WriteLine("  0. Return to main menu");
                Console.WriteLine();
                Console.WriteLine($"Your Money: ${user.Money}");
                Console.WriteLine();
            }

    static void PrintMoneyDisplay(User user)
    {
        Console.WriteLine();
        Console.WriteLine("╔═══════════════════════════════════════╗");
        Console.WriteLine("║               YOUR BALANCE            ║");
        Console.WriteLine("╠═══════════════════════════════════════╣");
        Console.WriteLine($"║               Money: ${user.Money,-16}║");
        Console.WriteLine("╚═══════════════════════════════════════╝");
        Console.WriteLine();    }

    static void PrintGameEnding(int count, User user)
    {
        Console.WriteLine();
        Console.WriteLine("╔═══════════════════════════════════════╗");
        Console.WriteLine("║         GAME ENDING                   ║");
        Console.WriteLine("╚═══════════════════════════════════════╝");
        Console.WriteLine();

        if (count == 0)
        {
            Console.WriteLine("Gogo's are for babies.");
            Console.WriteLine("You invest all your money into pogs instead.");
        }
        else if (count == 1)
        {
            Console.WriteLine("You finished elementary school with 1 Gogo's.");
            Console.WriteLine(
                $"A lonely {user.GetAllItemsAsText()} sits in your pocket as a reminder of simpler times.");
        }
        else if (count <= 3)
        {
            Console.WriteLine($"You finished elementary school with {count} Gogo's.");
            Console.WriteLine($"A respectable collection.");
        }
        else if (count <= 5)
        {
            Console.WriteLine($"You finished elementary school with {count} Gogo's.");
            Console.WriteLine($"You were one of the popular kids. Everyone admired your collection.");
        }
        else
        {
            Console.WriteLine($"You finished elementary school with {count} Gogo's.");
            Console.WriteLine($"You became a legend.");
            Console.WriteLine($"Your collection is talked about to this day.");
        }

        Console.WriteLine();
        Console.WriteLine("╔═══════════════════════════════════════╗");
        Console.WriteLine("║          ----- THE END -----          ║");
        Console.WriteLine("╚═══════════════════════════════════════╝");
        Console.WriteLine();
    }
}
