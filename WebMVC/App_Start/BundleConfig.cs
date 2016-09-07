using System.Web;
using System.Web.Optimization;

namespace WebMVC
{
    public class BundleConfig
    {
        // Para obtener más información acerca de Bundling, consulte http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryui").Include(
                        "~/Scripts/jquery-ui-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.unobtrusive*",
                        "~/Scripts/jquery.validate*"));

            //AGREGO LOS JS DE UNIFI
            bundles.Add(new ScriptBundle("~/bundles/unifi").Include(
                        "~/Scripts/plugins/jquery/jquery.js",
                        "~/Scripts/plugins/jquery/jquery-migrate.js",        
                        "~/Scripts/js/custom.js",                        
                        "~/Scripts/js/plugins/owl*",
                        "~/Scripts/plugins/bootstrap/js/bootstrap.js",
                        "~/Scripts/plugins/back-to-top.js",
                        "~/Scripts/plugins/smoothScroll.js",
                        "~/Scripts/plugins/jquery.parallax.js",
                        "~/Scripts/plugins/owl-carousel/owl-carousel/owl.carousel.js",
                        "~/Scripts/plugins/revolution-slider/rs-plugin/js/jquery.themepunch.revolution.js",
                        "~/Scripts/Home/index.js",
                        "~/Scripts/js/shop.app.js",
                        "~/Scripts/js/plugins/owl-carousel.js",
                        "~/Scripts/js/plugins/revolution-slider.js",
                        "~/Scripts/js/plugins/style-switcher.js",                        
                        "~/Scripts/Funciones*"
                        ));
  



            // Utilice la versión de desarrollo de Modernizr para desarrollar y obtener información sobre los formularios. De este modo, estará
            // preparado para la producción y podrá utilizar la herramienta de creación disponible en http://modernizr.com para seleccionar solo las pruebas que necesite.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));
            
            bundles.Add(new StyleBundle("~/Content/themes/base/css").Include(
                        "~/Content/themes/base/jquery.ui.core.css",
                        "~/Content/themes/base/jquery.ui.resizable.css",
                        "~/Content/themes/base/jquery.ui.selectable.css",
                        "~/Content/themes/base/jquery.ui.accordion.css",
                        "~/Content/themes/base/jquery.ui.autocomplete.css",
                        "~/Content/themes/base/jquery.ui.button.css",
                        "~/Content/themes/base/jquery.ui.dialog.css",
                        "~/Content/themes/base/jquery.ui.slider.css",
                        "~/Content/themes/base/jquery.ui.tabs.css",
                        "~/Content/themes/base/jquery.ui.datepicker.css",
                        "~/Content/themes/base/jquery.ui.progressbar.css",
                        "~/Content/themes/base/jquery.ui.theme.css"
                        ));


                        bundles.Add(new StyleBundle("~/Content/css").Include(
                        //ESTILOS DE ECOMMERCE DE UNIFI
                        "~/Content/css/app.css",
                        "~/Content/css/blocks.css",
                        "~/Content/css/custom.css",
                        "~/Content/css/shop.style.css",
                        "~/Scripts/plugins/bootstrap/css/bootstrap.css",
	                    "~/Content/css/headers/header-v5.css",
	                    "~/Content/css/footers/footer-v4.css",
                        "~/Scripts/plugins/animate.css",
                        "~/Scripts/plugins/line-icons/line-icons.css",
                        "~/Scripts/plugins/scrollbar/css/jquery.mCustomScrollbar.css",
                        "~/Scripts/plugins/owl-carousel/owl-carousel/owl.carousel.css",
                        "~/Scripts/plugins/revolution-slider/rs-plugin/css/settings.css",
	                    "~/Content/css/theme-colors/default.css",  
                        "~/Scripts/plugins/font-awesome/css/font-awesome.css",
                        "~/Content/site.css"
                        ));
        }


    
	



    }
}