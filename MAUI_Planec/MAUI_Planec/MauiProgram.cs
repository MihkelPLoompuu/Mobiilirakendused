using Microsoft.Extensions.Logging;

namespace MAUI_Planec
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
                    fonts.AddFont("Monstserrat-Medium.ttf", "RegularFont");
                    fonts.AddFont("Monstserrat-SemiBold.ttf", "MediumFont");
                    fonts.AddFont("Monstserrat-Bold.ttf", "BoldFont");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
