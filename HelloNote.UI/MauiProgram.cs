using HelloNote.Shared;
using HelloNote.Shared.Services;
using HelloNote.UI.ViewModels;
using HelloNote.UI.Views;
using Microsoft.Extensions.Logging;

namespace HelloNote.UI;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

		builder.Services.AddSingleton<AppDbContext>();
		builder.Services.AddSingleton<INoteService, NoteService>();
		builder.Services.AddTransient<NotesListPage>();
        builder.Services.AddTransient<NotePage>();
        builder.Services.AddTransient<NoteViewModel>();



#if DEBUG
        builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}

