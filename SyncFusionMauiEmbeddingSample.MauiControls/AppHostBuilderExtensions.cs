using CommunityToolkit.Maui;

namespace SyncFusionMauiEmbeddingSample.MauiControls;

public static class AppHostBuilderExtensions
{
    public static MauiAppBuilder UseMauiControls(this MauiAppBuilder appBuilder)
        => appBuilder
            .UseMauiCommunityToolkit();
}
