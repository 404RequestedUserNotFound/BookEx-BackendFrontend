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

    public class ReceiptController : ApiController
    {
        [HttpGet]
        [Route("api/receipt")]
        public HttpResponseMessage AllReceipt()
        {
            try
            {
                var data = ReceiptServices.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);

            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }



        [HttpGet]
        [Route("api/receipt/{id}")]
        public HttpResponseMessage GetReceipt(int id)
        {
            try
            {
                var data = ReceiptServices.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch
            {
                return Request.CreateResponse(HttpStatusCode.NotFound, "Receipt not found");
            }

        }





        [HttpPost]
        [Route("api/receipt/add")]
        public HttpResponseMessage AddReceipt(ReceiptDTO receipts)
        {
            try
            {
                var data = ReceiptServices.Add(receipts);
                return Request.CreateResponse(HttpStatusCode.OK, "Receipt has been added");
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }




        [HttpPost]
        [Route("api/receipt/update")]
        public HttpResponseMessage UpdateReceipt(ReceiptDTO receipts)
        {
            try
            {
                var data = ReceiptServices.Update(receipts);
                return Request.CreateResponse(HttpStatusCode.OK, "Receipt information has been updated");
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }



        [HttpGet]
        [Route("api/receipt/delete/{id}")]
        public HttpResponseMessage DeleteReceipt(int id)
        {
            try
            {
                var data = ReceiptServices.Delete(id);
                return Request.CreateResponse(HttpStatusCode.NotFound, "Receipt has been deleted.");
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound, ex.Message);
            }


        }
    }
}