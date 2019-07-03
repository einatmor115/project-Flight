using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flights_project
{
    public class Country : IPoco
    {
        public long ID { get; set; }
        public string CountryName { get; set; }

        public Country()
        {
        }

        public Country(string countryName)
        {
            CountryName = countryName;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (obj is Country == false)
            {
                return false;
            }
            return this == obj as Country;
        }

        public override int GetHashCode()
        {
            return this.ID.GetHashCode();
        }

        public static bool operator ==(Country a, Country b)
        {
            if (a.ID == b.ID)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(Country a, Country b)
        {
            return !(a == b);
        }

        public override string ToString()
        {
            return $"ID:{ID}, CountryName:{CountryName}";
        }
    }
}
