using AutoMapper;
using BLL.DTOs;
using DAL;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class BorrowServices
    {
        public static List<BorrowDTO> Get()
        {
            var dbdata = DataAccessFactory.BorrowDataAccess().Get();
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Borrow, BorrowDTO>());
            var mapper = new Mapper(config);
            var data = mapper.Map<List<BorrowDTO>>(dbdata);
            return data;
        }



        public static BorrowDTO Get(int id)
        {
            var dbdata = DataAccessFactory.BorrowDataAccess().Get(id);
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Borrow, BorrowDTO>());
            var mapper = new Mapper(config);
            var data = mapper.Map<BorrowDTO>(dbdata);
            return data;
        }







        public static bool Add(BorrowDTO BorrowDto)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<BorrowDTO, Borrow>();
                cfg.CreateMap<Borrow, BorrowDTO>();
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<Borrow>(BorrowDto);

            if (Get(data.Id) != null)
            {
                return false;
            }
            return DataAccessFactory.BorrowDataAccess().Insert(data);
        }



        public static bool Delete(int id)
        {
            return DataAccessFactory.BorrowDataAccess().Delete(id);
        }



        public static bool Update(BorrowDTO borrow)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<BorrowDTO, Borrow>();
                cfg.CreateMap<Borrow, BorrowDTO>();
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<Borrow>(borrow);
            return DataAccessFactory.BorrowDataAccess().Update(data);
        }




        public static object GetAll()
        {
            throw new NotImplementedException();
        }


    }
}
