using System;
using System.Text;
using Microsoft.AspNetCore.Mvc;

namespace FlightAPI.Model{

    public class Flight{
       public int id {get; set;}
       public string FlightCode{get; set;}
       public int Seat{get; set;}
       public string FlightType{get; set;}
       public string Company{get; set;}
    }

}