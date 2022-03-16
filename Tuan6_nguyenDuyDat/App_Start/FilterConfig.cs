using System.Web;
using System.Web.Mvc;

namespace Tuan6_nguyenDuyDat
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
