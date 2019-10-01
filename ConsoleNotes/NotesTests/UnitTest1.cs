using ConsoleNotes;
using System;
using Xunit;

namespace NotesTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("header", "description", 0)]
        public void CreateNoteTest(string header, string description, int id)
        {
            Note note = new Note(header, description);

            NoteController noteController = new NoteController();
            noteController.Create(header, description);

            Assert.Equal(note, noteController.GetNote(id));
        }
    }
}
