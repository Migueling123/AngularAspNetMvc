using System.Web;
using System.Web.Optimization;

namespace AngularAspNet
{
    public class BundleConfig
    {
        // Para obtener más información sobre las uniones, visite https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/Script/Bundles").Include(
                       "~/Bundles/runtime-es5.js",
                       "~/Bundles/vendor-es5.js",
                       "~/Bundles/polyfills-es5.js",
                       "~/Bundles/main-es5.js"));

            bundles.Add(new StyleBundle("~/Content/Bootstrap").Include("~/Content/bootstrap.min.css"));

            BundleTable.EnableOptimizations = true;
        }
    }
}
