﻿using HelloWorldAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using HelloWorld.DAL;

namespace HelloWorldAPI.Business
{
    public class ProductDetails: IProductDetails
    {
        APIContext _webcontext = new APIContext();
            _webcontext.products.Add(pobj);
            int m = _webcontext.SaveChanges();

        }

  
    }
}