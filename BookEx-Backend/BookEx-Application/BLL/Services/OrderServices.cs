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
    public class OrderServices
    {
        public static List<OrderDTO> Get()
        {
            var dbdata = DataAccessFactory.OrderDataAccess().Get();
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Order, OrderDTO>());
            var mapper = new Mapper(config);
            var data = mapper.Map<List<OrderDTO>>(dbdata);
            return data;
        }



        public static OrderDTO Get(int id)
        {
            var dbdata = DataAccessFactory.OrderDataAccess().Get(id);
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Order, OrderDTO>());
            var mapper = new Mapper(config);
            var data = mapper.Map<OrderDTO>(dbdata);
            return data;
        }

        public static bool Add(OrderDTO orderDTO)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<OrderDTO, Order>();
                cfg.CreateMap<Order, OrderDTO>();
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<Order>(orderDTO);

            if (Get(data.OrderId) != null)
            {
                return false;
            }
            return DataAccessFactory.OrderDataAccess().Insert(data);
        }



        public static bool Delete(int id)
        {
            return DataAccessFactory.OrderDataAccess().Delete(id);
        }



        public static bool Update(OrderDTO order)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<OrderDTO, Order>();
                cfg.CreateMap<Order, OrderDTO>();
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<Order>(order);
            return DataAccessFactory.OrderDataAccess().Update(data);
        }




        public static object GetAll()
        {
            throw new NotImplementedException();
        }
    }
}


