using System.Web;
using System.Web.Mvc;
using SeriesDB.App_Start;

namespace SeriesDB
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new LanguageFilter());
        }
    }
}
