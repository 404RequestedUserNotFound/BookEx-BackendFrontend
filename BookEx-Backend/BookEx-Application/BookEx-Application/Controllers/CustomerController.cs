using BLL.DTOs;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace BookEx_Application.Controllers
{
    [EnableCors("*", "*", "*")]
    public class CustomerController : ApiController
    {
        [HttpGet]
        [Route("api/customer")]
        public HttpResponseMessage AllCustomer()
        {
            try
            {
                var data = CustomerServices.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);

            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }

        [HttpGet]
        [Route("api/customer/{id}")]
        public HttpResponseMessage GetCustomer(int id)
        {
            try
            {
                var data = CustomerServices.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch
            {
                return Request.CreateResponse(HttpStatusCode.NotFound, "Customer not found");
            }

        }


        [HttpPost]
        [Route("api/customer/add")]
        public HttpResponseMessage AddCustomer(CustomerDTO customer)
        {
            try
            {
                var data = CustomerServices.Add(customer);
                return Request.CreateResponse(HttpStatusCode.OK, "Customer added");
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }




        [HttpPost]
        [Route("api/customer/update")]
        public HttpResponseMessage UpdateCustomer(CustomerDTO customer)
        {
            try
            {
                var data = CustomerServices.Update(customer);
                return Request.CreateResponse(HttpStatusCode.OK, "Customer information updated");
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }



        [HttpGet]
        [Route("api/customer/delete/{id}")]
        public HttpResponseMessage DeleteCustomer(int id)
        {
            try
            {
                var data = CustomerServices.Delete(id);
                return Request.CreateResponse(HttpStatusCode.NotFound, "Customer deleted.");
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound, ex.Message);
            }


        }

    }
}


