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
    public class BorrowController : ApiController
    {
        [HttpGet]
        [Route("api/borrow")]
        public HttpResponseMessage AllBorrow()
        {
            try
            {
                var data = BorrowServices.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);

            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }



        [HttpGet]
        [Route("api/borrow/{id}")]
        public HttpResponseMessage GetBorrow(int id)
        {
            try
            {
                var data = BorrowServices.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch
            {
                return Request.CreateResponse(HttpStatusCode.NotFound, "Borrow request not found");
            }

        }



        [HttpPost]
        [Route("api/borrow/add")]
        public HttpResponseMessage AddBorrow(BorrowDTO borrow)
        {
            try
            {
                var data = BorrowServices.Add(borrow);
                return Request.CreateResponse(HttpStatusCode.OK, "Scuccessfully borrowed");
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }




        [HttpPost]
        [Route("api/borrow/update")]
        public HttpResponseMessage UpdateBorrow(BorrowDTO borrow)
        {
            try
            {
                var data = BorrowServices.Update(borrow);
                return Request.CreateResponse(HttpStatusCode.OK, "Borrow has been updated");
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }



        [HttpGet]
        [Route("api/borrow/delete/{id}")]
        public HttpResponseMessage DeleteBorrow(int id)
        {
            try
            {
                var data = BorrowServices.Delete(id);
                return Request.CreateResponse(HttpStatusCode.NotFound, "Borrow has been removed.");
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound, ex.Message);
            }


        }

    }
}
