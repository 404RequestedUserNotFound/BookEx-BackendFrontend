using DAL.Interface;
using DAL.Models;
using DAL.Repos;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataAccessFactory
    {
        public static IAuth AuthDataAccess()
        {
            return new AdminRepo();
        }


        public static IRepo<Admin, int, bool> AdminDataAccess()
        {
            return new AdminRepo();
        }
        public static IRepo<Category, int, bool> CategoryDataAccess()
        {
            return new CategoryRepo();
        }
        public static IRepo<Employee, int, bool> EmployeeDataAccess()
        {
            return new EmployeeRepo();
        }




        public static IRepo<Book, int, bool> BookDataAccess()
        {
            return new BookRepo();
        }
        public static IRepo<Order, int, bool> OrderDataAccess()
        {
            return new OrderRepo();
        }
        public static IRepo<Customer, int, bool> CustomerDataAccess()
        {
            return new CustomerRepo();
        }


        public static IRepo<OrderItem, int, bool> OrderItemDataAccess()
        {
            return new OrderItemRepo();
        }
        public static IRepo<Receipt, int, bool> ReceiptDataAccess()
        {
            return new ReceiptRepo();
        }
        public static IRepo<Author, int, bool> AuthorDataAccess()
        {
            return new AuthorRepo();
        }




        public static IRepo<Publisher, int, bool> PublisherDataAccess()
        {
            return new PublisherRepo();
        }
        public static IRepo<Borrow, int, bool> BorrowDataAccess()
        {
            return new BorrowRepo();
        }
        public static IRepo<Reservation, int, bool> ReservationDataAccess()
        {
            return new ReservationRepo();
        }
    }
}
