using Fluid;
using Microsoft.Extensions.DependencyInjection;
using OrchardCore.ContentManagement;
using OrchardCore.ContentManagement.Display.ContentDisplay;
using OrchardCore.ContentManagement.Handlers;
using OrchardCore.ContentTypes.Editors;
using OrchardCore.Data.Migration;
using OrchardCore.Indexing;
using OrchardCore.Modules;
using OrchardCore.Title.Drivers;
using OrchardCore.Title.Handlers;
using OrchardCore.Title.Indexing;
using OrchardCore.Title.Models;
using OrchardCore.Title.Settings;
using OrchardCore.Title.ViewModels;

namespace OrchardCore.Title
{
    public class Startup : StartupBase
    {
        static Startup()
        {
            TemplateContext.GlobalMemberAccessStrategy.Register<TitlePartViewModel>();
            TemplateContext.GlobalMemberAccessStrategy.Register<TitlePartSettingsViewModel>();
        }

        public override void ConfigureServices(IServiceCollection services)
        {
            // Title Part
            services.AddScoped<IContentPartDisplayDriver, TitlePartDisplay>();
            services.AddContentPart<TitlePart>();
            services.AddScoped<IContentPartIndexHandler, TitlePartIndexHandler>();
            services.AddScoped<IContentPartHandler, TitlePartHandler>();
            services.AddScoped<IContentTypePartDefinitionDisplayDriver, TitlePartSettingsDisplayDriver>();

            services.AddScoped<IDataMigration, Migrations>();
        }
    }
}
