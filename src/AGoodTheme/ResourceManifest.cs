using OrchardCore.ResourceManagement;

namespace AGoodTheme
{
    public class ResourceManifest : IResourceManifestProvider
    {
        public void BuildManifests(IResourceManifestBuilder builder)
        {
            var manifest = builder.Add();

            manifest
                .DefineStyle("AGoodTheme")
                .SetDependencies("bootstrap")
                .SetUrl("~/AGoodTheme/css/site.css")
                .SetVersion("1.0.0");
        }
    }
}
