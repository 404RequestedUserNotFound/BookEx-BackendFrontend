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
    public class OrderController : ApiController
    {
        [HttpGet]
        [Route("api/order")]
        public HttpResponseMessage AllOrder()
        {
            try
            {
                var data = OrderServices.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);

            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }



        [HttpGet]
        [Route("api/order/{id}")]
        public HttpResponseMessage GetOrder(int id)
        {
            try
            {
                var data = OrderServices.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch
            {
                return Request.CreateResponse(HttpStatusCode.NotFound, "order not found");
            }

        }





        [HttpPost]
        [Route("api/order/add")]
        public HttpResponseMessage AddOrder(OrderDTO order)
        {
            try
            {
                var data = OrderServices.Add(order);
                return Request.CreateResponse(HttpStatusCode.OK, "New order added");
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }




        [HttpPost]
        [Route("api/order/update")]
        public HttpResponseMessage UpdateOrder(OrderDTO order)
        {
            try
            {
                var data = OrderServices.Update(order);
                return Request.CreateResponse(HttpStatusCode.OK, "Orders information updated");
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }



        [HttpGet]
        [Route("api/order/delete/{id}")]
        public HttpResponseMessage DeleteOrder(int id)
        {
            try
            {
                var data = OrderServices.Delete(id);
                return Request.CreateResponse(HttpStatusCode.NotFound, "order deleted.");
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound, ex.Message);
            }


        }
    }
}



