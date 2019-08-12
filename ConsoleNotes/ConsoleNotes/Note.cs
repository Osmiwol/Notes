using System;
using System.Collections.Generic;

/// <summary>
/// Summary description for Class1
/// </summary>
public class Note
{
    public Note(){}

    private Dictionary<string, string> notes = new Dictionary<string, string>();

    public void ShowAllNotes()
    {
        Console.WriteLine("\n");
        if (notes.Count != 0)
        {
            foreach (KeyValuePair<string, string> keyValue in notes)
                Console.WriteLine("Header of note: \n" + keyValue.Key + "\n Text of note: \n" + keyValue.Value);
        }
        else  Console.WriteLine("Your notes is empty, nothing to show.");
        Console.ReadKey();
    }

    public void AddNote()
    {
        string textNote = "", headerNote = "";

        Console.WriteLine("\nPlease,enter header of note: ");
        headerNote = Console.ReadLine();
        Console.WriteLine("\nPlease,enter text of note: ");
        textNote = Console.ReadLine();
        if ((textNote != "" || textNote != " " || textNote != null) &&
            (headerNote != "" || headerNote != " " || headerNote != null))
        {
            notes.Add(headerNote, textNote);
            Console.WriteLine("Note was successfully added.\n");
            Console.ReadKey();
        }
        else
        {
            Console.WriteLine("Your data is incorrect, please, try again with another data. \n");
            Console.ReadKey();
        }
        
    }

    public void RemoveNote()
    {
        string headerNote="";
        Console.WriteLine("\nPlease,enter header of note, that you want to delete: ");
        headerNote = Console.ReadLine();
        if ( (headerNote != "" || headerNote != " " || headerNote != null))
        {
            if (notes.ContainsKey(headerNote))
            {
                notes.Remove(headerNote );
                Console.WriteLine("Note was successfully remove.\n");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("You dont have note with header like: " + headerNote);
                Console.ReadKey();
            }
        }
        else
        {
            Console.WriteLine("Your data is incorrect, please, try again with another data. \n");
            Console.ReadKey();
        }
    }

    public void ShowNote()
    {
        string textNote = "", headerNote = "";
        Console.WriteLine("\nPlease,enter header of note, that you want to see: ");
        headerNote = Console.ReadLine();
        if ((headerNote != "" || headerNote != " " || headerNote != null))
        {
            if (notes.ContainsKey(headerNote))
            {
                textNote = notes[headerNote];
                Console.WriteLine("Text of your note: \n" + textNote);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("You dont have note with header like: " + headerNote);
                Console.ReadKey();
            }
            
        }
        else
        {
            Console.WriteLine("Your data is incorrect, please, try again with another data. \n");
            Console.ReadKey();
        }
    }

    public void EditNote()
    {
        string textNote = "", headerNote = "";

        Console.WriteLine("\nPlease,enter header of note, that you want to change: ");
        headerNote = Console.ReadLine();

        if (notes.ContainsKey(headerNote))
        {
            
            Console.WriteLine("\nPlease,enter text, that you want to set: ");
            textNote = Console.ReadLine();
            if ((textNote != "" || textNote != " " || textNote != null) &&
                (headerNote != "" || headerNote != " " || headerNote != null))
            {
                    notes[headerNote] = textNote;
                    Console.WriteLine("Note was successfully changed.\n");
                    Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Your data is incorrect, please, try again with another data. \n");
                Console.ReadKey();
            }
        }
        else
        {
            Console.WriteLine("You dont have note with header like: " + headerNote);
            Console.ReadKey();
        }

    }
}
