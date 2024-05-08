using Microsoft.Extensions.Logging;

namespace QuotesPage
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
                });

            // No es necesario registrar QuotesPage como un servicio

            // Configurar QuotesPage como la página principal de la aplicación
            builder.Services.AddTransient<QuotesPage>(); // Registra la página QuotesPage
            builder.Services.AddTransient<Application>(sp => new App()); // Configura la página principal como App

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
