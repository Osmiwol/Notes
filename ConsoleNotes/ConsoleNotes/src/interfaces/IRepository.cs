using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleNotes
{
    public interface IRepository : IDisposable
    {
        IEnumerable<Note> GetNotesList();
        Note GetNote(int id);
        void Create(Note note);

        void Create(string header,string description);
        void Update(Note note);
        void Update(int id,Note note);

        void Update(int id, string header, string description);
        void Delete(int id);
        void Save();

    }
}
