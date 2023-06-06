using Microsoft.AspNetCore.Builder;

using System.Web.Optimization;

namespace vending
{
    public class Startup
    {
        public void Configure(IApplicationBuilder app)
        {
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        }
    }
}
