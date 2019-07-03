using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flights_project
{
    public interface IAirLineDAO : IBasicDB<AirlineCompany>
    {
        AirlineCompany GetAirLineByUserName(string user_name);
        List<AirlineCompany> GetAirLineByCountry(int country_code);
    }
}
