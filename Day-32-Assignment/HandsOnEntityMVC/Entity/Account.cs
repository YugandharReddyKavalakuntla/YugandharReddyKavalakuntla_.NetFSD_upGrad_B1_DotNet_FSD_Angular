using System;
using System.Collections.Generic;
using System.Text;

namespace HandsOnEntityMVC.Entity{

    public class Account{

        public int id{get; set;}
        public string? AccountType{get; set;}
        public string? customerName{get; set;}
        public double Balance{get; set;}

        public string? Branch{get; set;}
        public DateTime CreateDate{get; set;}






    }
}
