using System.Web;
using System.Web.Mvc;

namespace MundoDaFoto.WebMvc4 {
    public class FilterConfig {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters) {
            filters.Add(new HandleErrorAttribute());
        }
    }
}