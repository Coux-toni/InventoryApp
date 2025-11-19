using InventoryApp.Coree.Models;
using InventoryApp.Coree.Services;
using InventoryApp.Gui.Services;
using Microsoft.Extensions.Logging;

namespace InventoryApp.Gui
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
            // 2|OMXtseZFGDZZxI9vAOmQ1OGo354LBCaLpdGwHabO32a06153
            string token = Preferences.Get("ApiToken",string.Empty);
            string apiBase = "https://inventory.test/api";

            builder.Services.AddSingleton<MainPage>();
            builder.Services.AddSingleton<DashboardViewModel>();
            builder.Services.AddSingleton<IRepository>(new RestService(token, apiBase));
            builder.Services.AddSingleton<IPreferencesService>(new PreferenceService());

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
