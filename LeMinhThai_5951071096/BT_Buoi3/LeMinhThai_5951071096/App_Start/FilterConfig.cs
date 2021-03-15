using System.Web;
using System.Web.Mvc;

namespace LeMinhThai_5951071096
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
