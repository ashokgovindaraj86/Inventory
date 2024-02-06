using Inventory_Management_App.Models;
using Inventory_Management_App.Service;
using System.Text.Json.Nodes;

 class Program
{
      

    private static void Main(string[] args)
    {

        FlightService flightService = new FlightService();
        Flights f1 = new Flights(flightNo: 1, departure: "YUL", arrival: "YYZ", days: 1);
        Flights f2 = new Flights(flightNo: 2, departure: "YUL", arrival: "YYC", days: 1);
        Flights f3 = new Flights(flightNo: 3, departure: "YUL", arrival: "YVR", days: 1);
        Flights f4 = new Flights(flightNo: 4, departure: "YUL", arrival: "YYZ", days: 2);
        Flights f5 = new Flights(flightNo: 5, departure: "YUL", arrival: "YYC", days: 2);
        Flights f6 = new Flights(flightNo: 6, departure: "YUL", arrival: "YVR", days: 2);
        flightService.addFlight(f1);
        flightService.addFlight(f2);
        flightService.addFlight(f3);
        flightService.addFlight(f4);
        flightService.addFlight(f5);
        flightService.addFlight(f6);

        //User Story 1
        flightService.viewFlightsDetails();

        //User Story 2
        flightService.loadOrdersList("coding-assigment-orders.json");
        Console.ReadLine();

    }
}