using HelloWorldAPI.Business;
using HelloWorldAPI.Models;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Results;

namespace HelloWorldAPI.Controllers
{
    [RoutePrefix("api/products")]
    public class ProductsController : ApiController
    {
        IProductDetails iproductdetails;
        public ProductsController(IProductDetails _iproductdetails)        {            iproductdetails = _iproductdetails;        }
        [HttpPost]
        [Route("addProduct")]
        [Authorize]
        public async Task<HttpResponseMessage> saveProductDetails(HelloWorld.DAL.Products pod)
        {



            Dictionary<string, string> dict = new Dictionary<string, string>();
            bool res = false;
            string errordetails = "";
            var errors = new List<string>();
            if (ModelState.IsValid)
            {
                try
                {
                    res = iproductdetails.SaveProducts(pod);

                }
                catch (Exception ex)
                {
                    throw ex;
                }


            }
            else
            {


                foreach (var state in ModelState)
                {
                    foreach (var error in state.Value.Errors)
                    {
                        string p = error.ErrorMessage;
                        errordetails = errordetails + error.ErrorMessage;

                    }
                }

                dict.Add("error", errordetails);
                return Request.CreateResponse(HttpStatusCode.BadRequest, dict);

            }

            if (res == true)
            {
                var showmessage = "Product Saved Successfully.";

                dict.Add("Message", showmessage);
                return Request.CreateResponse(HttpStatusCode.OK, dict);

            }
            else
            {
                var showmessage = "Product Not Saved Please try again.";

                dict.Add("Message", showmessage);
                return Request.CreateResponse(HttpStatusCode.BadRequest, dict);

            }
        }
    }

}
