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
            bundles.Add(new ScriptBundle("~/bundles/shared").Include(
                        "~/Scripts/jquery/jquery-3.1.1.js",
                        "~/Scripts/bootstrap/bootstrap.js",
                        "~/Scripts/respond.js"
                    ));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            bundles.Add(new BabelBundle("~/bundles/todoapp").Include(
                    "~/Scripts/react/react.js",
                    "~/Scripts/react/reactDOM.js",
                    "~/Scripts/director.js",
                    "~/Scripts/classNames.js",
                    "~/Scripts/utils.js",
                    "~/Scripts/todoModel.js",
                    "~/Scripts/todoItem.jsx",
                    "~/Scripts/footer.jsx",
                    "~/Scripts/app.jsx"
                ));
        }
    }
}