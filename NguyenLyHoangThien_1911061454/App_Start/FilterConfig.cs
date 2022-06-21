using System.Web;
using System.Web.Mvc;

namespace NguyenLyHoangThien_1911061454
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
