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
    public class ReceiptServices
    {
        public static List<ReceiptDTO> Get()
        {
            var dbdata = DataAccessFactory.ReceiptDataAccess().Get();
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Receipt, ReceiptDTO>());
            var mapper = new Mapper(config);
            var data = mapper.Map<List<ReceiptDTO>>(dbdata);
            return data;
        }

        public static ReceiptDTO Get(int id)
        {
            var dbdata = DataAccessFactory.ReceiptDataAccess().Get(id);
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Receipt, ReceiptDTO>());
            var mapper = new Mapper(config);
            var data = mapper.Map<ReceiptDTO>(dbdata);
            return data;
        }

        public static bool Add(ReceiptDTO receiptDto)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<ReceiptDTO, Receipt>();
                cfg.CreateMap<Receipt, ReceiptDTO>();
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<Receipt>(receiptDto);

            if (Get(data.ReceiptId) != null)
            {
                return false;
            }
            return DataAccessFactory.ReceiptDataAccess().Insert(data);
        }



        public static bool Delete(int id)
        {
            return DataAccessFactory.ReceiptDataAccess().Delete(id);
        }



        public static bool Update(ReceiptDTO receipt)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<ReceiptDTO, Receipt>();
                cfg.CreateMap<Receipt, ReceiptDTO>();
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<Receipt>(receipt);
            return DataAccessFactory.ReceiptDataAccess().Update(data);
        }




        public static object GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
