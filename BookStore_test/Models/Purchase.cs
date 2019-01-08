using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStore_test.Models
{
    public class Purchase
    {
        //Purchase ID
        public int PurchaseID { get; set; }
        //Name and second name of buyer
        public string Person { get; set; }
        //Adress of buyer
        public string Adress { get; set; }
        //ID of book
        public int BookID { get; set; }
        //Purchase Date
        public DateTime Date { get; set; }
    }
}