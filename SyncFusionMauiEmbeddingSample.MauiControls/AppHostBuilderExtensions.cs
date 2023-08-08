using CommunityToolkit.Maui;
using Syncfusion.Maui.Core.Hosting;

namespace SyncFusionMauiEmbeddingSample.MauiControls;

public static class AppHostBuilderExtensions
{
    public static MauiAppBuilder UseMauiControls(this MauiAppBuilder appBuilder)
        => appBuilder
            .UseMauiCommunityToolkit()
            .ConfigureSyncfusionCore();
}
