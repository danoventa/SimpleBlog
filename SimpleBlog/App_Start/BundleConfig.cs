using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;


namespace SimpleBlog.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/admin/styles").Include("~/content/styles/bootstrap.css").Include("/content/styles/admin.css"));

            bundles.Add(new StyleBundle("~/styels").Include("~/content/styles/bootstrap.css").Include("~/content/styles/site.css"));
        }
    }
}