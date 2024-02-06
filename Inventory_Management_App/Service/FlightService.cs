using Inventory_Management_App.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Management_App.Service
{
    internal class FlightService
    {
        List<Flights> Flights= new List<Flights>();

        

        public void addFlight(Flights flights)
        {
            Flights.Add(flights);
        }
        

        public void viewFlightsDetails()
        {
            foreach(var flight in Flights)
            {
                flight.viewFlightDetails();
            }
        }

        public void loadOrdersList(string FilePath)
        {
            var orders = JsonConvert.DeserializeObject<Dictionary<string, Orders>>(File.ReadAllText(FilePath));

            foreach (var flight in Flights)
            {
                foreach (var orderKeyValuePair in orders)
                {
                    Orders order = new Orders(orderKeyValuePair.Key,orderKeyValuePair.Value.getDestination(),flight);
                    
                    

                    if (order.getDestination().Equals(flight.getArrival(), StringComparison.OrdinalIgnoreCase) && order.getFlights().getflightNo() == flight.getflightNo())
                    {
                        flight.orders.Add(order);
                        Console.WriteLine($"order: {order.getOrderId()}, flightNumber: {flight.getflightNo()}, departure: {flight.getDeparture()}, arrival: {flight.getArrival()}, day: {flight.getDays()}");
                        orders.Remove(orderKeyValuePair.Key);
                        var count = flight.orders.Count(a => a.getDestination() == flight.getArrival() && a.getFlights().getflightNo() == a.getFlightNo() );
                        if(count >= 20)
                        break;
                    }
                }
            }

            foreach (var remainingOrder in orders)
            {
                Console.WriteLine($"order: {remainingOrder.Key}, flightNumber: not scheduled");
            }
        }
    }
}
