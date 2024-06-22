using HelloNote.UI.ViewModels;

namespace HelloNote.UI.Views;

public partial class NotePage : ContentPage
{
	public NotePage(NoteViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}
