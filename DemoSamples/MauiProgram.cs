﻿using Microsoft.Extensions.Logging;

namespace DemoSamples;

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

#if DEBUG
		builder.Logging.AddDebug();
#endif
		builder.ConfigureMauiHandlers(handlers =>
		{
		#if iOS
			handlers.AddHandler(typeof(Entry), typeof(EntrySubclassedHandler));
		#endif

		});

		return builder.Build();
	}

	
}

