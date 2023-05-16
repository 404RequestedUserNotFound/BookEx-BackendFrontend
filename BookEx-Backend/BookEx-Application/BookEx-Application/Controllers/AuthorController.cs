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
    public class AuthorController : ApiController
    {
        [HttpGet]
        [Route("api/author")]
        public HttpResponseMessage AllAuthor()
        {
            try
            {
                var data = AuthorServices.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);

            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }



        [HttpGet]
        [Route("api/author/{id}")]
        public HttpResponseMessage GetAuthor(int id)
        {
            try
            {
                var data = AuthorServices.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch
            {
                return Request.CreateResponse(HttpStatusCode.NotFound, "Admin not found");
            }

        }

        [HttpPost]
        [Route("api/author/add")]
        public HttpResponseMessage AddAuthor(AuthorDTO authors)
        {
            try
            {
                var data = AuthorServices.Add(authors);
                return Request.CreateResponse(HttpStatusCode.OK, "Author has been added");
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpPost]
        [Route("api/author/update")]
        public HttpResponseMessage UpdateAuthor(AuthorDTO authors)
        {
            try
            {
                var data = AuthorServices.Update(authors);
                return Request.CreateResponse(HttpStatusCode.OK, "Author information has been updated");
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpGet]
        [Route("api/author/delete/{id}")]
        public HttpResponseMessage DeleteAuthor(int id)
        {
            try
            {
                var data = AuthorServices.Delete(id);
                return Request.CreateResponse(HttpStatusCode.NotFound, "Author has been deleted.");
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound, ex.Message);
            }


        }
    }
}