using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Management_App.Models
{
    internal class Orders
    {
        private string orderId { get; set; }
        private string destination { get; set; }
        private int flightNo { get; set; }
        private Flights flight { get; set; }

       
        public Orders(string orderId, string destination, Flights flight)
        {
            this.orderId = orderId;
            this.destination = destination;
            this.flightNo = (flight != null) ? flight.getflightNo() : 0;
            this.flight = flight;
        }

        public string getOrderId()
        {
            return this.orderId;
        }

        public string getDestination()
        {
            return this.destination;
        }
        public int getFlightNo()
        {
            return this.flightNo;
        }

        public Flights getFlights() { return this.flight; }
    }
}
