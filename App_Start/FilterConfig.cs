using System.Web;
using System.Web.Mvc;

namespace Phamtrungnhat_Ktrape
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
