using AutoMapper;
using BLL.DTOs;
using DAL.Models;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class ReservationServices
    {
        public static List<ReservationDTO> Get()
        {
            var dbdata = DataAccessFactory.ReservationDataAccess().Get();
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Reservation, ReservationDTO>());
            var mapper = new Mapper(config);
            var data = mapper.Map<List<ReservationDTO>>(dbdata);
            return data;
        }

        public static ReservationDTO Get(int id)
        {
            var dbdata = DataAccessFactory.ReservationDataAccess().Get(id);
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Reservation, ReservationDTO>());
            var mapper = new Mapper(config);
            var data = mapper.Map<ReservationDTO>(dbdata);
            return data;
        }


        public static bool Add(ReservationDTO ReservationDto)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<ReservationDTO, Reservation>();
                cfg.CreateMap<Reservation, ReservationDTO>();
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<Reservation>(ReservationDto);

            if (Get(data.Id) != null)
            {
                return false;
            }
            return DataAccessFactory.ReservationDataAccess().Insert(data);
        }



        public static bool Delete(int id)
        {
            return DataAccessFactory.ReservationDataAccess().Delete(id);
        }

        public static bool Update(ReservationDTO reservation)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<ReservationDTO, Reservation>();
                cfg.CreateMap<Reservation, ReservationDTO>();
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<Reservation>(reservation);
            return DataAccessFactory.ReservationDataAccess().Update(data);
        }

        public static object GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
