using HelloWorldAPI.Models;
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
        APIContext _webcontext = new APIContext();        public bool SaveProducts(HelloWorld.DAL.Products pobj)        {
            _webcontext.products.Add(pobj);
            int m = _webcontext.SaveChanges();            if (m == 1)            {                return true;            }            else            {                return false;            }

        }

  
    }
}