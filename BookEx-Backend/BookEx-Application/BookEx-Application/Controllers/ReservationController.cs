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
    public class ReservationController : ApiController
    {
        [HttpGet]
        [Route("api/reservation")]
        public HttpResponseMessage AllReservation()
        {
            try
            {
                var data = ReservationServices.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);

            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }



        [HttpGet]
        [Route("api/reservation/{id}")]
        public HttpResponseMessage GetReservation(int id)
        {
            try
            {
                var data = ReservationServices.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch
            {
                return Request.CreateResponse(HttpStatusCode.NotFound, "Reservation request not found");
            }

        }



        [HttpPost]
        [Route("api/reservation/add")]
        public HttpResponseMessage AddReservation(ReservationDTO reservation)
        {
            try
            {
                var data = ReservationServices.Add(reservation);
                return Request.CreateResponse(HttpStatusCode.OK, "Scuccessfully Reserved");
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }




        [HttpPost]
        [Route("api/reservation/update")]
        public HttpResponseMessage UpdateReservation(ReservationDTO reservation)
        {
            try
            {
                var data = ReservationServices.Update(reservation);
                return Request.CreateResponse(HttpStatusCode.OK, "Reservation has been updated");
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }



        [HttpGet]
        [Route("api/reservation/delete/{id}")]
        public HttpResponseMessage DeleteReservation(int id)
        {
            try
            {
                var data = ReservationServices.Delete(id);
                return Request.CreateResponse(HttpStatusCode.NotFound, "Reservation has been removed.");
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound, ex.Message);
            }


        }
    }
}
