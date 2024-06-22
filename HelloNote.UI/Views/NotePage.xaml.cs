using HelloNote.UI.ViewModels;

namespace HelloNote.UI.Views;

[QueryProperty(nameof(NoteTitle), "Title")]
public partial class NotePage : ContentPage
{

	public string NoteTitle { get; set; }

	public NotePage(NoteViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}

    protected override void OnAppearing()
    {
        base.OnAppearing();

		var viewModel = BindingContext as NoteViewModel;

		if(viewModel != null)
		{

			if(!string.IsNullOrEmpty(NoteTitle))
			{
				viewModel.LoadNoteByTitle(NoteTitle);
			}
			else
			{
				viewModel.Title = string.Empty;
				viewModel.Content = string.Empty;
			}
		}
    }
}
