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
    public class BookServices
    {
        public static List<BookDTO> Get()
        {
            var dbdata = DataAccessFactory.BookDataAccess().Get();
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Book, BookDTO>());
            var mapper = new Mapper(config);
            var data = mapper.Map<List<BookDTO>>(dbdata);
            return data;
        }



        public static BookDTO Get(int id)
        {
            var dbdata = DataAccessFactory.BookDataAccess().Get(id);
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Book, BookDTO>());
            var mapper = new Mapper(config);
            var data = mapper.Map<BookDTO>(dbdata);
            return data;
        }



        public static BookDTO Get(string name)
        {
            var dbdata = DataAccessFactory.BookDataAccess().Get().FirstOrDefault(u => u.Title == name);
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Book, BookDTO>());
            var mapper = new Mapper(config);
            var data = mapper.Map<BookDTO>(dbdata);
            return data;
        }

        public static bool Add(BookDTO bookDTO)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<BookDTO, Book>();
                cfg.CreateMap<Book, BookDTO>();
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<Book>(bookDTO);

            if (Get(data.BookId) != null)
            {
                return false;
            }
            return DataAccessFactory.BookDataAccess().Insert(data);
        }



        public static bool Delete(int id)
        {
            return DataAccessFactory.BookDataAccess().Delete(id);
        }



        public static bool Update(BookDTO book)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<BookDTO, Book>();
                cfg.CreateMap<Book, BookDTO>();
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<Book>(book);
            return DataAccessFactory.BookDataAccess().Update(data);
        }




        public static object GetAll()
        {
            throw new NotImplementedException();
        }
    }
}


