using BLL.DTOs;
using DAL.Models;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace BLL.Services
{
    public class OrderItemServices
    {
        public static List<OrderItemDTO> Get()
        {
            var dbdata = DataAccessFactory.OrderItemDataAccess().Get();
            var config = new MapperConfiguration(cfg => cfg.CreateMap<OrderItem, OrderItemDTO>());
            var mapper = new Mapper(config);
            var data = mapper.Map<List<OrderItemDTO>>(dbdata);
            return data;
        }

        public static OrderItemDTO Get(int id)
        {
            var dbdata = DataAccessFactory.OrderItemDataAccess().Get(id);
            var config = new MapperConfiguration(cfg => cfg.CreateMap<OrderItem, OrderItemDTO>());
            var mapper = new Mapper(config);
            var data = mapper.Map<OrderItemDTO>(dbdata);
            return data;
        }



        //public static OrderItemDTO Get(int Quantity)
        //{
        //	var dbdata = DataAccessFactory.OrderItemDataAccess().Get().FirstOrDefault(u => u.Quantity == Quantity);
        //	var config = new MapperConfiguration(cfg => cfg.CreateMap<OrderItem, OrderItemDTO>());
        //	var mapper = new Mapper(config);
        //	var data = mapper.Map<OrderItemDTO>(dbdata);
        //	return data;
        //}



        public static bool Add(OrderItemDTO orderitemDto)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<OrderItemDTO, OrderItem>();
                cfg.CreateMap<OrderItem, OrderItemDTO>();
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<OrderItem>(orderitemDto);

            if (Get(data.Quantity) != null)
            {
                return false;
            }
            return DataAccessFactory.OrderItemDataAccess().Insert(data);
        }



        public static bool Delete(int id)
        {
            return DataAccessFactory.OrderItemDataAccess().Delete(id);
        }



        public static bool Update(OrderItemDTO orderitem)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<OrderItemDTO, OrderItem>();
                cfg.CreateMap<OrderItem, OrderItemDTO>();
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<OrderItem>(orderitem);
            return DataAccessFactory.OrderItemDataAccess().Update(data);
        }




        public static object GetAll()
        {
            throw new NotImplementedException();
        }
    }
}