using System;
using System.Collections.ObjectModel;
using HelloNote.Shared;
using HelloNote.Shared.Services;

namespace HelloNote.UI.ViewModels
{
	public class NotesListPageViewModel : BindableObject
	{

		private ObservableCollection<Note> _notes;
        private readonly INoteService _noteService;

        public ObservableCollection<Note> Notes
		{
			get => _notes;
			set
			{
				_notes = value;
				OnPropertyChanged();
			}
		}

		public NotesListPageViewModel(INoteService noteService)
		{
			_noteService = noteService;
			Notes = new ObservableCollection<Note>();
			RefreshNotes();
		}

        private void RefreshNotes()
        {
			Notes.Clear();
			foreach(var note in _noteService.GetNotes())
			{
				Notes.Add(note);
			}
        }
    }
}

