using System.Web;
using System.Web.Mvc;

namespace AplicacionWebDePrueba__no_se_me_ocurre_otro_nombre_
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
