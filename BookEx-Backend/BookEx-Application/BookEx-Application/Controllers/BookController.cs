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
    public class BookController : ApiController
    {
        [HttpGet]
        [Route("api/book")]
        public HttpResponseMessage AllBook()
        {
            try
            {
                var data = BookServices.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);

            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }



        [HttpGet]
        [Route("api/book/{id}")]
        public HttpResponseMessage GetBook(int id)
        {
            try
            {
                var data = BookServices.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch
            {
                return Request.CreateResponse(HttpStatusCode.NotFound, "Book not found");
            }

        }





        [HttpPost]
        [Route("api/book/add")]
        public HttpResponseMessage AddBook(BookDTO book)
        {
            try
            {
                var data = BookServices.Add(book);
                return Request.CreateResponse(HttpStatusCode.OK, "New book added");
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }




        [HttpPost]
        [Route("api/book/update")]
        public HttpResponseMessage UpdateBook(BookDTO book)
        {
            try
            {
                var data = BookServices.Update(book);
                return Request.CreateResponse(HttpStatusCode.OK, "Book's information updated");
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }



        [HttpGet]
        [Route("api/book/delete/{id}")]
        public HttpResponseMessage DeleteBook(int id)
        {
            try
            {
                var data = BookServices.Delete(id);
                return Request.CreateResponse(HttpStatusCode.NotFound, "Book deleted.");
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound, ex.Message);
            }


        }
    }

}



