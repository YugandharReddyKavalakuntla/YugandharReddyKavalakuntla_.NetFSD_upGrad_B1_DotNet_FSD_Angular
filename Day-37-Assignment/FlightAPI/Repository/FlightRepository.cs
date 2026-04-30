using System;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using FlightAPI.Model;
using System.Collections.Generic;

namespace FlightAPI.Repositories{
    public class FlightRepository {

        public static List<Flight> flights = new List<Flight>();


        
        public void AddFlight(Flight flight)
        {
            flights.Add(flight);
        }

        public List<Flight> GetFlights()
        {
            return flights;
        }

        public Flight GetFlight(int id)
        {
            return flights.FirstOrDefault(f =>f.id == id);
        }

        public void EditFlight(Flight flight)
        {
            var existing = flights.FirstOrDefault(f=>f.id == flight.id);
            if (existing != null)
            {
                existing.FlightCode = flight.FlightCode;
                existing.Seat = flight.Seat;
                existing.FlightType = flight.FlightType;
                existing.Company = flight.Company;
            }

        }

        public void DeleteFlight(int id)
        {
            var flight = flights.FirstOrDefault(f => f.id == id);

            if (flight != null)
            {
                flights.Remove(flight);
            }
        }
    }
}