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
			}
		}

        public string Content
        {
            get => _content;
            set
            {
                _content = value;
                OnPropertyChanged();
            }
        }

		private readonly INoteService _noteService;
		public ICommand SaveCommand { get; }

        public NoteViewModel(INoteService noteService)
		{
			_noteService = noteService;
			SaveCommand = new Command(CreateNote);
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
	}
}

