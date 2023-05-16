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
    public class OrderItemController : ApiController
    {
        [HttpGet]
        [Route("api/orderitem")]
        public HttpResponseMessage AllOrderItem()
        {
            try
            {
                var data = OrderItemServices.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);

            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }



        [HttpGet]
        [Route("api/orderitem/{id}")]
        public HttpResponseMessage GetOrderItem(int id)
        {
            try
            {
                var data = OrderItemServices.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch
            {
                return Request.CreateResponse(HttpStatusCode.NotFound, "OrderItem not found");
            }

        }





        [HttpPost]
        [Route("api/orderitem/add")]
        public HttpResponseMessage AddOrderItem(OrderItemDTO orderitems)
        {
            try
            {
                var data = OrderItemServices.Add(orderitems);
                return Request.CreateResponse(HttpStatusCode.OK, "OrderItem has been added");
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }




        [HttpPost]
        [Route("api/orderitem/update")]
        public HttpResponseMessage UpdateOrderItem(OrderItemDTO orderitems)
        {
            try
            {
                var data = OrderItemServices.Update(orderitems);
                return Request.CreateResponse(HttpStatusCode.OK, "OrderItem information has been updated");
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }



        [HttpGet]
        [Route("api/orderitem/delete/{id}")]
        public HttpResponseMessage DeleteOrderItem(int id)
        {
            try
            {
                var data = OrderItemServices.Delete(id);
                return Request.CreateResponse(HttpStatusCode.NotFound, "OrderItem has been deleted.");
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound, ex.Message);
            }


        }
    }
}