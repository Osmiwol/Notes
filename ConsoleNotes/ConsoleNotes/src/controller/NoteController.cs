using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleNotes
{
    public class NoteController : IRepository
    {
        private List<Note> listNotes = new List<Note>(); 

        public void Create(Note note)
        {
            listNotes.Add(note);
        }

        public void Create(string header, string description)
        {
            Note note = new Note(header, description);
            listNotes.Add(note);
        }

        public void Delete(int id)
        {
            if (id > 0 || listNotes.Count > id)
            {
                                
                listNotes.RemoveAt(id);
            }
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Note> GetNotesList()
        {
            return listNotes;
        }

        public Note GetNote(int id)
        {
            
            if (id < 0 || listNotes.Count < id)
                return null;
            
            return listNotes[id].Clone();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Update(int id,Note note)
        {
            
            var item = GetNote(id);
            item.Merge(note);
        }

        public void Update(Note note)
        {
            throw new NotImplementedException();
        }

        public void Update(int id, string header, string description)
        {
            listNotes[id].Header = header;
            listNotes[id].Description = description;
        }
    }
}
