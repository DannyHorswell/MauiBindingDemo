using MauiApp1.Classes;
using Microsoft.Extensions.Logging;

namespace MauiApp1;

public static class MauiProgram
{

	static Model appModleSingleton = null;


    public static Model AppModleSingleton
	{
		get
		{
			if (appModleSingleton == null)
			{
                // Singleton holding app level data
                appModleSingleton = new Model();

                // Add soem data initially
                appModleSingleton.AddSomeData();
            }

			return appModleSingleton;
		}
	}


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

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
