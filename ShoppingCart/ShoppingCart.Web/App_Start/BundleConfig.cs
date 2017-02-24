using System.Web;
using System.Web.Optimization;

namespace ShoppingCart.Web
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/Jquery/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/Jquery/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/Jquery/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap/bootstrap.js",
                      "~/Scripts/bootstrap/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/css/Styles.css"
                     ));
            bundles.Add(new ScriptBundle("~/bundles/Angularjs").Include(
                     "~/Scripts/AngularJs/angular.min.js",
                     "~/Scripts/AngularJs/angular-resource.min.js",
                     "~/Scripts/AngularJs/angular-ui-router.min.js"
                ));
            bundles.Add(new ScriptBundle("~/bundles/app").Include(
                "~/Scripts/app/app.js",
                "~/Scripts/app/HomeController.js",
               "~/Scripts/app/ShoppingCartService.js",
              "~/Scripts/app/ShoppingCartRouting.js"
               ));
        }
    }
}
