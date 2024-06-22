using HelloNote.Shared;
using HelloNote.Shared.Services;
using HelloNote.UI.ViewModels;

namespace HelloNote.UI.Views;

public partial class NotesListPage : ContentPage
{
	public NotesListPage(INoteService noteService)
	{
		InitializeComponent();
		BindingContext = new NotesListPageViewModel(noteService);
	}

    protected override void OnAppearing()
    {
        base.OnAppearing();
		(BindingContext as NotesListPageViewModel)?.RefreshNotes();
    }

	private async void OnNoteSelected(object sender, SelectedItemChangedEventArgs e)
	{
		var note = e.SelectedItem as Note;
		if (note == null)
			return;

		await Shell.Current.GoToAsync($"{nameof(NotePage)}?Title={note.Title}");
	}
}
