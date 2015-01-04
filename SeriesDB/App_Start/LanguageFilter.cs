using System.Web.Mvc;

namespace SeriesDB.App_Start { 
public class LanguageFilter
        : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        
        {
          var taal =  (string)filterContext.HttpContext.Session["taal"];
            SetLanguage(taal);
        }

       
            
        protected void SetLanguage(string language)
        {
            if (!string.IsNullOrEmpty(language))
            {
                System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo(language);
                System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(language);
            }
        }
        
    }
}