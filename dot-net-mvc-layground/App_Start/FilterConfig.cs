﻿using System.Web;
using System.Web.Mvc;

namespace dot_net_mvc_layground
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
