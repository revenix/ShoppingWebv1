﻿using System.Web;
using System.Web.Optimization;

namespace Shopping
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                       "~/Scripts/jquery-3.2.1.js",
                       "~/Scripts/jquery-ui-1.12.1.js",
                       "~/Scripts/bootstrap.min.js",
                        //"~/js/classie.js",
                        //"~/js/imagezoom.js",
                        //"~/js/jquery.flexisel.js",
                        //"~/js/jquery.flexslider.js",
                        //"~/js/responsive-tabs.js",
                        //"~/js/responsiveslides.min.js",
                        //"~/js/simpleCart.min.js",
                        //"~/js/cbpViewModeSwitch.js",
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));
            
            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/font-awesome.css",
                      "~/Content/css/component.css",
                      "~/Content/css/flexslider.css",
                      "~/Content/css/style.css",
                      "~/Content/site.css"));
        }
    }
}