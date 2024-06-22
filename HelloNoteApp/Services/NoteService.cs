using System;

namespace HelloNote.Shared.Services
{
	public class NoteService : INoteService
	{

        private readonly AppDbContext _dbContext;

		public NoteService(AppDbContext dbContext)
		{
            _dbContext = dbContext;
		}

        public IEnumerable<Note> GetNotes()
        {
            return _dbContext.Notes.ToList();
        }

        public void CreateNote(Note note)
        {
            _dbContext.Notes.Add(note);
            _dbContext.SaveChanges();
        }

        public Note GetNoteByTitle(string title)
        {
            return _dbContext.Notes.FirstOrDefault(n => n.Title == title);
        }

        public void UpdateNote(Note note)
        {
            var existingNote = _dbContext.Notes.Local.FirstOrDefault(n => n.Id == note.Id);

            if(existingNote != null)
            {
                _dbContext.Entry(existingNote).State = Microsoft.EntityFrameworkCore.EntityState.Detached;
            }

            _dbContext.Notes.Update(note);
            _dbContext.SaveChanges();
        }

        public void DeleteNoteByTitle(string title)
        {
            var note = _dbContext.Notes.FirstOrDefault(n => n.Title == title);
            if(note != null)
            {
                _dbContext.Notes.Remove(note);
                _dbContext.SaveChanges();
            }
        }
    }
}

