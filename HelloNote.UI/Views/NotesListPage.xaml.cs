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

}
