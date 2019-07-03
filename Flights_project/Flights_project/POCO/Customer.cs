using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flights_project
{
    public class Customer : IUser, IPoco
    {
        public long ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }
        public string PhoneNO { get; set; }
        public string CreditCardNumber { get; set; }

        public Customer()
        {
        }

        public Customer(string firstName, string lastName, string userName, string password, string address, string phoneNO, string creditCardNumber)
        {         
            FirstName = firstName;
            LastName = lastName;
            UserName = userName;
            Password = password;
            Address = address;
            PhoneNO = phoneNO;
            CreditCardNumber = creditCardNumber;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (obj is Customer == false)
            {
                return false;
            }
            return this == obj as Customer;
        }

        public override int GetHashCode()
        {
            return this.ID.GetHashCode();
        }

        public static bool operator ==(Customer a, Customer b)
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

        public static bool operator !=(Customer a, Customer b)
        {
            return !(a == b);
        }

        public override string ToString()
        {
            return $" firstName: {FirstName}, lastName:{LastName},userName:{UserName},password: " +
                $"{Password}, address:{Address}," +
                $"phoneNO: {PhoneNO}, creditCardNumber:{CreditCardNumber}";

        }
    }
}
