﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flights_project
{
    public interface ICustomerDAO : IBasicDB<Customer>
    {
        Customer GetCustomerByUserName(string name);
    }
}
