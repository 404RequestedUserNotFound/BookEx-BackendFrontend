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
    public class AuthorServices
    {
        public static List<AuthorDTO> Get()
        {
            var dbdata = DataAccessFactory.AuthorDataAccess().Get();
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Author, AuthorDTO>());
            var mapper = new Mapper(config);
            var data = mapper.Map<List<AuthorDTO>>(dbdata);
            return data;
        }

        public static AuthorDTO Get(int id)
        {
            var dbdata = DataAccessFactory.AuthorDataAccess().Get(id);
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Author, AuthorDTO>());
            var mapper = new Mapper(config);
            var data = mapper.Map<AuthorDTO>(dbdata);
            return data;
        }



        public static AuthorDTO Get(string AuthorName)
        {
            var dbdata = DataAccessFactory.AuthorDataAccess().Get().FirstOrDefault(u => u.AuthorName == AuthorName);
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Author, AuthorDTO>());
            var mapper = new Mapper(config);
            var data = mapper.Map<AuthorDTO>(dbdata);
            return data;
        }



        public static bool Add(AuthorDTO authorDto)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<AuthorDTO, Author>();
                cfg.CreateMap<Author, AuthorDTO>();
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<Author>(authorDto);

            if (Get(data.AuthorName) != null)
            {
                return false;
            }
            return DataAccessFactory.AuthorDataAccess().Insert(data);
        }



        public static bool Delete(int id)
        {
            return DataAccessFactory.AuthorDataAccess().Delete(id);
        }



        public static bool Update(AuthorDTO author)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<AuthorDTO, Author>();
                cfg.CreateMap<Author, AuthorDTO>();
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<Author>(author);
            return DataAccessFactory.AuthorDataAccess().Update(data);
        }




        public static object GetAll()
        {
            throw new NotImplementedException();
        }
    }
}