using ClientsApp.Services;
using Microsoft.Extensions.Logging;

namespace ClientsApp;

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
			});

		builder.Services.AddHttpClient<ClientsOdataService>(client =>
		{
			client.BaseAddress = new Uri("http://localhost:5259/odata/");
			client.DefaultRequestHeaders.Add("Accept", "application/json");
		});

		builder.Services.AddMauiBlazorWebView();

#if DEBUG
		builder.Services.AddBlazorWebViewDeveloperTools();
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
