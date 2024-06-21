using System;
namespace HelloNote.Shared.Services
{
	public interface INoteService
	{
		IEnumerable<Note> GetNotes();
	}
}

