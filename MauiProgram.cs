using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;
using TabBarProblem.ViewModels;
using TabBarProblem.Views;

namespace TabBarProblem
{
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
                })
                .ConfigureEssentials(essentials =>
                {
                    essentials.UseVersionTracking();
                })
                .UseMauiCommunityToolkit();

#if DEBUG
		builder.Logging.AddDebug();
#endif

            builder.Services.AddSingleton<WelcomePage>();
            builder.Services.AddSingleton<WelcomePageViewModel>();

            builder.Services.AddSingleton<EmptyPage>();
            builder.Services.AddSingleton<EmptyPageViewModel>();

            return builder.Build();
        }
    }
}