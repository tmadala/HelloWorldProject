﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace HelloWorldAPI
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API attribute routing
            config.MapHttpAttributeRoutes();
        }
    }
}
