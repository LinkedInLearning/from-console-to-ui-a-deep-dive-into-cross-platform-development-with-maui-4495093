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
    }
}

