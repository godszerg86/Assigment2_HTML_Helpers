using System.Web;
using System.Web.Mvc;

namespace Assigment2_HTML_Helpers
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
