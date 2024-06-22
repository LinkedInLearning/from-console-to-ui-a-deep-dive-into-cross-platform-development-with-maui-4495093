using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using HelloNote.Shared;
using HelloNote.Shared.Services;
using HelloNote.UI.Views;

namespace HelloNote.UI.ViewModels
{
	public class NotesListPageViewModel : BindableObject
	{

		private ObservableCollection<Note> _notes;
        private readonly INoteService _noteService;
		public ICommand NewNoteCommand { get; }

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
			NewNoteCommand = new Command(OnNewNote);
		}

        private async void OnNewNote()
        {
			await Shell.Current.GoToAsync(nameof(NotePage));
        }

        public void RefreshNotes()
        {
			Notes.Clear();
			foreach(var note in _noteService.GetNotes())
			{
				Notes.Add(note);
			}
        }
    }
}

