using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flights_project
{
    interface IFlightDAO : IBasicDB<Flight>
    {
        Dictionary<Flight, int> GetAllFlightsVacancy();
        Flight GetFlightById(int Id);
        List<Flight> GetFlightsByCustomer(Customer customer);
        List<Flight> GetFlightsByDepatureDate (DateTime departureDate);
        List<Flight> GetFlightsByDestinationCountry(int country_code);
        List<Flight> GetFlightsByLandingDate (DateTime landingDate);
        List<Flight> GetFlightsByOriginCountry (int country_code);
    }
}
