using Microsoft.Extensions.Logging;
using Selab.Src.LocalDatabase;

namespace Selab
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            /*string creadentioalPath = @"E:\_NhomHocTap\.net Maui\Selab\GenerateKey.json";
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", creadentioalPath);*/
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                });

            builder.Services.AddMauiBlazorWebView();
           
#if DEBUG
    		builder.Services.AddBlazorWebViewDeveloperTools();
            builder.Services.AddSingleton<ISqlService, Database>();
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
