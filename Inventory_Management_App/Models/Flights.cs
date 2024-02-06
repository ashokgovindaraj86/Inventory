using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Management_App.Models
{
    internal class Flights
    {
        
        private int flightNo { get; set; }
        private string departure { get; set; }
        private string arrival { get; set; }
        private int days { get; set; }
        
        public List<Orders> orders { get; set; }

        public Flights(int flightNo, string departure, string arrival, int days)
        {
            this.flightNo = flightNo;
            this.departure = departure;
            this.arrival = arrival;
            this.days = days;
            this.orders = new List<Orders>();
        }

        public void viewFlightDetails()
        {
            Console.WriteLine("Flight: " + this.flightNo + ", departure: " + this.departure + ", arrival: " + this.arrival + ", day: " + this.days);
        }

        public int getflightNo()
        {
            return this.flightNo;
        }
        public string getDeparture()
        {
            return this.departure;
        }

        public string getArrival()
        {
            return this.arrival;
        }

        public int getDays()
        {
            return this.days;
        }
    }
}
