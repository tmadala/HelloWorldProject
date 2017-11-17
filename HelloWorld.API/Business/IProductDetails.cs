using HelloWorld.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldAPI.Business
{
   public interface IProductDetails
    {
       // List<Product> showDetails();
        bool SaveProducts(Products pob);
    }
    
}