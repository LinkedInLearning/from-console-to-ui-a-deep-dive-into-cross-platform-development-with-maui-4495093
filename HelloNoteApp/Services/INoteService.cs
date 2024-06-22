﻿using System;
namespace HelloNote.Shared.Services
{
	public interface INoteService
	{
		IEnumerable<Note> GetNotes();
		void CreateNote(Note note);
		Note GetNoteByTitle(string title);
	}
}

