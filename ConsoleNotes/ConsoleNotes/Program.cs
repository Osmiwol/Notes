using System;

namespace ConsoleNotes
{
    class Program
    {

        public static void ShowView()
        {
            Note notes = new Note();

            string inpKey = "";
            while (true)
            {
                Console.WriteLine("\t\t\t**Hi, this is my console notes**\n");
                Console.WriteLine("Choise action from list below:" +
                    "\n1 - Add note." +
                    "\n2 - Edit note." +
                    "\n3 - Show note." + 
                    "\n4 - Show all notes." +
                    "\n5 - Remove note." +
                    "\n6 - Clear console." +
                    "\n7 - Help." +
                    "\n8 - Exit.");
                Console.Write("\nYour choise: ");
                inpKey = Console.ReadLine();
                switch (inpKey)
                {
                    case "1":
                        notes.AddNote();
                        Console.Clear();
                        break;
                    case "2":
                        notes.EditNote();
                        Console.Clear();
                        break;
                    case "3":
                        notes.ShowNote();
                        Console.Clear();
                        break;
                    case "4":
                        notes.ShowAllNotes();
                        Console.Clear();
                        break;
                    case "5":
                        notes.RemoveNote();
                        Console.Clear();
                        break;
                    case "6":
                        Console.Clear();
                        break;
                    case "7":
                        Console.WriteLine("\nJust type the number of action, " +
                            "\nthat you want to do, and press enter.");
                        Console.ReadKey();
                        goto case "6";
                    case "8":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("You must be mistaken, please, enter number from list.");
                        Console.ReadKey();
                        goto case "6";
                }
                
            }
            
            
        }

        static void Main(string[] args)
        {
            ShowView();
        }
    }
}
