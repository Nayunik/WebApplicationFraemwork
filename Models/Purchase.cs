using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplicationFraemwork.Models
{
    public class Purchase
    {
        //Id покупки
        public int PurchaseId { get; set; }
        //ФИО покупателя
        public string Person { get; set; }
        //Адрес покупателя
        public string Address { get; set; }
        //Id книги
        public int BookId { get; set; }
        //Дата и время покупки
        public DateTime Date { get; set; }
    }
}