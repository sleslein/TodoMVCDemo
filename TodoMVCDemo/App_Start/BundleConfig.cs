using System.Web;
using System.Web.Optimization;
using System.Web.Optimization.React;

namespace TodoMvcDemo
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new BabelBundle("~/bundles/shared").Include(
                        "~/Scripts/respond.js",
                        "~/Scripts/react/react.js",
                        "~/Scripts/react/reactDOM.js",
                        "~/Scripts/simpleComponent.jsx"
                    ));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/Site.css"));
        }
    }
}