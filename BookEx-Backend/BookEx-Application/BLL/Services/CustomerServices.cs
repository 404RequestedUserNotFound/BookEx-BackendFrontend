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
    public class CustomerServices
    {
        public static List<CustomerDTO> Get()
        {
            var dbdata = DataAccessFactory.CustomerDataAccess().Get();
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Customer, CustomerDTO>());
            var mapper = new Mapper(config);
            var data = mapper.Map<List<CustomerDTO>>(dbdata);
            return data;
        }



        public static CustomerDTO Get(int id)
        {
            var dbdata = DataAccessFactory.CustomerDataAccess().Get(id);
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Customer, CustomerDTO>());
            var mapper = new Mapper(config);
            var data = mapper.Map<CustomerDTO>(dbdata);
            return data;
        }







        public static bool Add(CustomerDTO customerDto)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<CustomerDTO, Customer>();
                cfg.CreateMap<Customer, CustomerDTO>();
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<Customer>(customerDto);

            if (Get(data.CustomerId) != null)
            {
                return false;
            }
            return DataAccessFactory.CustomerDataAccess().Insert(data);
        }



        public static bool Delete(int id)
        {
            return DataAccessFactory.CustomerDataAccess().Delete(id);
        }



        public static bool Update(CustomerDTO customer)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<CustomerDTO, Customer>();
                cfg.CreateMap<Customer, CustomerDTO>();
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<Customer>(customer);
            return DataAccessFactory.CustomerDataAccess().Update(data);
        }




        public static object GetAll()
        {
            throw new NotImplementedException();
        }

    }
}
