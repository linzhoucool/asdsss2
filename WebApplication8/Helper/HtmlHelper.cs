using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication8.Helper
{
    public class HtmlHelper
    {

        public static class HtmlHelpersExtensions

        {
            public static IHtmlString BootstrapModalWindow(this HtmlHelper helper, DateTimeOffset? date)
            {
                var returnData = "";
                if (!date.HasValue)
                {
                    returnData = "-";
                }
                else
                {
                    returnData = date.Value.ToString("yyyy-MM-dd HH: mm");
                }
                return new HtmlString(returnData);
            }

        }
    }
}