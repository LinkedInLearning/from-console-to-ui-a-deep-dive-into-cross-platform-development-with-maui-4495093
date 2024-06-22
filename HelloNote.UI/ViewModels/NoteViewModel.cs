using System;
using System.Windows.Input;
using HelloNote.Shared;
using HelloNote.Shared.Services;

namespace HelloNote.UI.ViewModels
{
	public class NoteViewModel : BindableObject
	{

		private string _title;
		private string _content;

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

        public NoteViewModel(INoteService noteService)
		{
			_noteService = noteService;
			SaveCommand = new Command(CreateNote, CanSaveNote);
			BackCommand = new Command(OnBackButtonPressed);
		}

		private void CreateNote()
		{

			var newNote = new Note
			{
				Title = Title,
				Content = Content
			};

			_noteService.CreateNote(newNote);
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
	}
}

