using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flights_project
{
    public class LoginService : IloginService
    {
        private IAirLineDAO _arilineDAO;
        private ICustomerDAO _customerADO;

        public LoginService(IAirLineDAO airLineDAO, ICustomerDAO customerDAO)
        {
            _arilineDAO = airLineDAO;
            _customerADO = customerDAO;
        }

        public bool TryAdminLogin(string userName, string password, out LoginToken<Administrator> token)
        {
            if (userName.ToUpper() == flightCenterConfig.ADMIN_NAME && password == flightCenterConfig.ADMIN_PASSWORD)
            {
                token = new LoginToken<Administrator>();
                token.user = new Administrator();
                return true;
            }
            token = null;
            return false;
        }

        public bool TryAirLineLogin(string userName, string password, out LoginToken<AirlineCompany> token)
        {
            AirlineCompany company = _arilineDAO.GetAirLineByUserName(userName);

            if (password == company.Password && company != null) 
            {
                token = new LoginToken<AirlineCompany>() { user = company };
                return true;
            }
            else
            {
                try
                {
                    if (company == null)
                    {
                        token = null;
                        return false;
                    }
                    throw new WrongPasswordException();
                }
                catch (WrongPasswordException e)
                {
                    token = new LoginToken<AirlineCompany>() { user = company };
                    return false;
                }
            }
        }


        public bool TryCustomerLogin(string userName, string password, out LoginToken<Customer> token)
        {
            token = new LoginToken<Customer>();

            while (userName == _customerADO.GetCustomerByUserName(userName).UserName)
            {
                if (password == _customerADO.GetCustomerByUserName(userName).Password)
                {
                    token.user = new Customer();
                    return true;
                }
                else
                {
                    throw new WrongPasswordException();
                }
            }
            return false;
        }
    }
}
