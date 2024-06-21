using HelloNote.UI.Views;

namespace HelloNote.UI;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		Routing.RegisterRoute(nameof(NotesListPage), typeof(NotesListPage));
	}
}

