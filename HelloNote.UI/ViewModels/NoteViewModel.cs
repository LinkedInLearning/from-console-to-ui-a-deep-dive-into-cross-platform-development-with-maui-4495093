using System;
using System.Windows.Input;
using HelloNote.Shared;
using HelloNote.Shared.Services;

namespace HelloNote.UI.ViewModels
{
	public class NoteViewModel : BindableObject
	{
		private int _id;
		private string _title;
		private string _content;

		public bool IsExistingNote => Id != 0;

		public int Id
		{
			get { return _id; }
			set {
				_id = value;
				OnPropertyChanged();
				OnPropertyChanged(nameof(IsExistingNote));
			}
		}

		public string Title
		{
			get => _title;
			set
			{
				_title = value;
				OnPropertyChanged();
				((Command)SaveCommand).ChangeCanExecute();
			}
		}

        public string Content
        {
            get => _content;
            set
            {
                _content = value;
                OnPropertyChanged();
                ((Command)SaveCommand).ChangeCanExecute();
            }
        }

		private readonly INoteService _noteService;
		public ICommand SaveCommand { get; }
        public ICommand BackCommand { get; }
		public ICommand DeleteCommand { get; }

        public NoteViewModel(INoteService noteService)
		{
			_noteService = noteService;
			SaveCommand = new Command(CreateNote, CanSaveNote);
			BackCommand = new Command(OnBackButtonPressed);
			DeleteCommand = new Command(DeleteNote);
		}

        private async void DeleteNote()
        {
			bool confirm = await Application.Current.MainPage.DisplayAlert("Confirm Delete", "Are you sure you want to delete this note?", "Yes", "No");
			if(confirm)
			{
				_noteService.DeleteNoteByTitle(Title);
				await Shell.Current.GoToAsync("..");
			}
        }

        private void CreateNote()
		{

			var newNote = new Note
			{
				Id = Id,
				Title = Title,
				Content = Content
			};

			if(Id == 0)
			{
                _noteService.CreateNote(newNote);
            }
			else
			{
				_noteService.UpdateNote(newNote);
			}
			
			Shell.Current.GoToAsync("..");
			
		}

		private bool CanSaveNote()
		{
			return !string.IsNullOrWhiteSpace(Title) && !string.IsNullOrWhiteSpace(Content);
		}

		private async void OnBackButtonPressed()
		{
			bool answer = await Application.Current.MainPage.DisplayAlert("Warning", "Do you really want to go back? Unsaved changes will be lost.", "Yes", "No");
			if(answer)
			{
				await Shell.Current.GoToAsync("..");
			}
		}

		public void LoadNoteByTitle(string title)
		{
			var note = _noteService.GetNoteByTitle(title);
			if(note != null)
			{
				Id = note.Id;
				Title = note.Title;
				Content = note.Content;
			}
			else
			{
				Id = 0;
				Title = string.Empty;
				Content = string.Empty;
			}
		}
	}
}

