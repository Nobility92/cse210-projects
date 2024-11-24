using System;

class Program
{
    static void Main(string[] args)
    { 
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();
        bool running = true;
        string confirm;
        string filename;

        while (running){
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Delete All");
            Console.WriteLine("6. Exit");
            Console.Write("What would you like to do?: ");

            string choice = Console.ReadLine();
            Console.WriteLine();

            if (choice == "1")
            {
                string prompt = promptGenerator.GetRandomPrompt();
                    Console.WriteLine(prompt);
                    Console.Write("> ");
                    string response = Console.ReadLine();

                    journal.AddEntry(new Entry(prompt, response));
            }
            else if ( choice == "2")
            {
                journal.DisplayAll();
            }

             else if ( choice == "3")
            {
                Console.Write("What is the filename?:");
                filename = Console.ReadLine();
                journal.LoadFromFile(filename);
                
            }

             else if ( choice == "4")
            {
                Console.Write("What is the filename?: ");
                    filename = Console.ReadLine();
                    journal.SaveToFile(filename);
            }
            else if (choice == "5")
            {
                Console.WriteLine("Are you sure you want to delete? (yes/no):");
                confirm = Console.ReadLine().ToLower();
                if (confirm == "yes")
                {
                    journal.DeleteAll();
                }
                else
                {
                    Console.WriteLine("Operation Aborted");
                }
            }

              else if ( choice == "6")
            {
                Console.Write("Are you sure you want to exit? (yes/no): ");
                    confirm = Console.ReadLine().ToLower();
                    if (confirm == "yes")
                    {
                        running = false;
                        Console.WriteLine("Goodbye");
                    }
                    else{
                        Console.WriteLine("Select a number from the menu");
                    }
            }
            else {
                Console.WriteLine("Invalid Choice");
            }

            }

    }
}