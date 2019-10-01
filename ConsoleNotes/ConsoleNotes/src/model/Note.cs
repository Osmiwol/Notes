using System;
using System.Collections.Generic;

/// <summary>
/// Summary description for Class1
/// </summary>
public class Note
{
    public string Header{ get; set; }
    public string Description { get; set; }

    public Note(string header,string description = "Описание")
    {
        Header = header;
        Description = description;
    }

    private Note(){}

    public void Merge(Note newValue)
    {
        this.Description = newValue.Description;
        this.Header = newValue.Description;
    }

    public Note Clone()
    {
        return new Note()
        {

            Header = this.Header,
            Description = this.Description,
        };
    }

}
