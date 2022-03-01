using Microsoft.AspNetCore.Components.WebView.Maui;
using BagIt.Data;
using BagIt.Models;
using BagIt.Services;

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
		builder.Services.AddSingleton<WeatherForecastService>();
		builder.Services.AddSingleton<UserService>();

		return builder.Build();
	}
}
