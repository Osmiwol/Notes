using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleNotes
{
    public class View
    {
        private NoteController noteController = new NoteController();
        private string header = "\t\t--==Заметки==--";

        public void ShowHeader()
        {
            Console.WriteLine(header);
        }

        public void ShowMenu()
        {
            string inputKey, header, description;
            int id;
            while (true)
            {
                ShowHeader();
                Console.WriteLine("Выберите действие с заметками из предложенных ниже:");
                Console.WriteLine("1.Добавить новую.");
                Console.WriteLine("2.Править существующую.");
                Console.WriteLine("3.Показать одну.");
                Console.WriteLine("4.Показать все.");
                Console.WriteLine("5.Удалить одну.");
                Console.WriteLine("6.Очистить консоль.");
                Console.WriteLine("7.Помощь.");
                Console.WriteLine("8.Выход.");
                Console.Write("Введите номер действия: ");
                inputKey = Console.ReadLine();
                id = -1;
                switch(inputKey)
                {
                    case "1":
                        Console.Write("Введите заголовок заметки: ");
                        header = Console.ReadLine();
                        Console.Write("Введите описание заметки: ");
                        description = Console.ReadLine();
                        noteController.Create(header,description);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "2":
                        Console.Write("Введите номер заметки: ");
                        id = int.Parse(Console.ReadLine());
                        id--;
                        Console.Write("Введите новый заголовок для заметки: ");
                        header = Console.ReadLine();
                        Console.Write("Введите новый описание для заметки: ");
                        description = Console.ReadLine();
                        noteController.Update(id,header,description);
                        Console.ReadKey();
                        goto case "6";
                        break;
                    case "3":
                        Console.Write("Введите номер заметки: ");                        
                        id = int.Parse(Console.ReadLine());
                        id--;
                        header = noteController.GetNote(id).Header;
                        description = noteController.GetNote(id).Description;
                        
                        Console.WriteLine("Заголовок заметки: " + header);
                        Console.WriteLine("Описание заметки: " + description);
                        Console.ReadKey();
                        goto case "6";
                        break;
                    case "4":
                        int idElement = 0;
                        foreach (var element in noteController.GetNotesList())
                        {
                            idElement++;
                            Console.Write("Заметка №: " + idElement + " "); Console.WriteLine("Заголовок: " + element.Header);
                            Console.WriteLine("Описание: " + element.Description);
                        }
                        Console.ReadKey();
                        //List <var> = new List(noteController.GetBookList());
                        goto case "6";
                        break;
                    case "5":
                        Console.Write("Введите номер заметки: ");                        
                        id = int.Parse(Console.ReadLine());
                        id--;
                        noteController.Delete(id);
                        Console.ReadKey();
                        goto case "6";
                        break;
                    case "6":
                        Console.Clear();
                        break;
                    case "7":
                        Console.WriteLine("\nпросто введите номер действия,  " +
                            "\nкоторый хотите совершить и нажмите клавишу Enter.");
                        Console.ReadKey();
                        goto case "6";
                        break;
                    case "8":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Должно быть вы ошиблись, попробуйте снова.");
                        Console.ReadKey();
                        goto case "6";
                        break;
                }
            }
        }

    }
}
