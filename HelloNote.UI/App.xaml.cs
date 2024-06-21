using HelloNote.Shared;

namespace HelloNote.UI;

public partial class App : Application
{
	public App(AppDbContext dbContext)
	{
		InitializeComponent();

		dbContext.Database.EnsureCreated();

		MainPage = new AppShell();
	}
}

