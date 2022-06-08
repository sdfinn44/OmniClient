

namespace OmniClient;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
            .UseMauiCommunityToolkit()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

		RegisterServices(builder.Services);
        RegisterPages(builder.Services);
        RegisterViewModels(builder.Services);

        return builder.Build();
	}

	private static void RegisterServices(IServiceCollection services)
    {
		services.AddTransient<ExampleService>();
    }

    private static void RegisterPages(IServiceCollection services)
    {
        services.AddTransient<ExamplePage>();
    }

    private static void RegisterViewModels(IServiceCollection services)
    {
        services.AddTransient<ExampleViewModel>();
    }
}
