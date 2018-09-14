using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace BeachCabinReservation.Utility
{
    public static class HtmlHelpers
    {
        public static IHtmlContent RenderJsonConfigTag(this IHtmlHelper html, string scriptId, string json)
        {
            var hb = new HtmlContentBuilder();
            hb.AppendHtml(string.Format("<script id='{0}' type='application/json'>", scriptId));
            hb.AppendHtml(json);
            hb.AppendHtml("</script>");

            return hb;
        }

        public static IHtmlContent RenderJsonConfigTags(this IHtmlHelper html, Dictionary<string, string> dict)
        {
            var hb = new HtmlContentBuilder();
            foreach (var d in dict)
            {
                hb.AppendHtml(RenderJsonConfigTag(html, d.Key, d.Value));
            }

            return hb;
        }
    }
}
