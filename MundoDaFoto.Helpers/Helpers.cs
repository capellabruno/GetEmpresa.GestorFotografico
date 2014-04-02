using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;


namespace MundoDaFoto.Helpers
{
    public static class Helpers
    {
        public static MvcHtmlString DropDownListCustom(this HtmlHelper helper, string name, IEnumerable<SelectListItem> itens, string nameFirstItem)
        {
            StringBuilder build = new StringBuilder();

            build.Append("<div class='btn-group'>\n");
            build.Append("<button type=\"button\" class=\"btn btn-default dropdown-toggle\" data-toggle=\"dropdown\">" + nameFirstItem + "<span class=\"caret\"></span></button>\n");
            build.Append("<ul class=\"dropdown-menu\" role=\"menu\" id='" + name + "'>\n");
            foreach (SelectListItem item in itens)
            {
                build.Append("<li role='presentation' value=\"" + item.Value + "\"><a href='#'>" + item.Text + "</a></li>\n");
            }

            build.Append("</ul>\n");
            build.Append("</div>\n");
            return MvcHtmlString.Create(build.ToString());
        }
    }
}
