using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStore_test.Models
{
    public class Book
    {
        //ID
        public int Id { get; set; }
        //Book`s name
        public string Name { get; set; }
        //автор книги
        public string Author { get; set; }
        //Цена
        public int Price { get; set; }
    }
}