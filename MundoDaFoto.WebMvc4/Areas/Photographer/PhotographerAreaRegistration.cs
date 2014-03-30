using System.Web.Mvc;

namespace MundoDaFoto.WebMvc4.Areas.Photographer {
    public class PhotographerAreaRegistration : AreaRegistration {
        public override string AreaName {
            get {
                return "Photographer";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) {
            context.MapRoute(
                "Photographer_default",
                "Photographer/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
