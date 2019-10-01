using ConsoleNotes;
using System;
using Xunit;

namespace NotesTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("header", "description", 0)]
        [InlineData(null, null, 0)]
        [InlineData(null, null, 100)]
        public void CreateNoteTest(string header, string description, int id)
        {
            Note note = new Note(header, description);

            NoteController noteController = new NoteController();
            noteController.Create(header, description);

            Assert.Equal(note, noteController.GetNote(id));
        }


        [Theory]
        [InlineData("header", "description", 0)]
        [InlineData(null, null, 0)]
        [InlineData(null, null, 100)]
        public void DeleteNoteTest(string header, string description, int id)
        {
            Note note = new Note(header, description);

            NoteController noteController = new NoteController();
            noteController.Create(header, description);
            noteController.Delete(id);

            Assert.NotEqual(note, noteController.GetNote(id));
        }

        [Theory]
        [InlineData("header", "description", 0)]
        [InlineData(null, null, 0)]
        [InlineData(null, null, 100)]
        public void UpdateNoteTest(string header, string description, int id)
        {
            Note note = new Note("��������", "��������");

            NoteController noteController = new NoteController();
            noteController.Create(header, description);
            noteController.Update(id, "��������", "��������");

            Assert.Equal(note, noteController.GetNote(id));
        }
    }
}
