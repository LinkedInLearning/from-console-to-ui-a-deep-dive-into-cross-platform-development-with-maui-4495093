using HelloNote.UI.ViewModels;

namespace HelloNote.UI.Views;

public partial class NotesListPage : ContentPage
{
	public NotesListPage()
	{
		InitializeComponent();
		BindingContext = new NotesListPageViewModel();
	}

}
