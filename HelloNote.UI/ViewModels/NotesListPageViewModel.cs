using System;
using System.Collections.ObjectModel;
using HelloNote.Shared;

namespace HelloNote.UI.ViewModels
{
	public class NotesListPageViewModel : BindableObject
	{

		private ObservableCollection<Note> _notes;

		public ObservableCollection<Note> Notes
		{
			get => _notes;
			set
			{
				_notes = value;
				OnPropertyChanged();
			}
		}

		public NotesListPageViewModel()
		{
			Notes = new ObservableCollection<Note>();
			RefreshNotes();
		}

        private void RefreshNotes()
        {
			Notes.Clear();
			Notes.Add(new Note { Title = "Sample Note", Content = "This is a sample note" });
            Notes.Add(new Note { Title = "Another Note", Content = "This is another sample note" });
        }
    }
}

