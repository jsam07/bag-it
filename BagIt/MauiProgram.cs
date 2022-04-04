using BagIt.Models;
using Microsoft.AspNetCore.Components.WebView.Maui;

namespace BagIt;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.RegisterBlazorMauiWebView()
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
			});

		builder.Services.Configure<UsersDbSettings>(
			builder.Configuration.GetSection("UsersDbSettings")
		);

		builder.Services.AddBlazorWebView();

		return builder.Build();
	}
}
