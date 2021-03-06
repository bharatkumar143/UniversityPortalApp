﻿using System.Web;
using System.Web.Mvc;

namespace UniversityPortalApp.Web
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new HandleExceptionsAttribute());
            filters.Add(new CustomActionFilter());
        }
    }
}
