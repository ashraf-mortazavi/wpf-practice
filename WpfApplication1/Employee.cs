using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1
{
    class Employee
    {
        private string firstName;
        private string lastName;
        private string phone;

        public string FirstName
        {
            get
            {
                return firstName;
            }

            set
            {
                firstName = value;
            }
        }
        public string LastName
        {
            get
            {
                return lastName;
            }

            set
            {
                lastName = value;
            }
        }
        public string Phone
        {
            get
            {
                return phone;
            }

            set
            {

                if (value.Length == 10 && value != null && value != "")
                {
                    phone = value;
                }
                else
                    phone = "0000000000";
             
            }
        }

        public Employee()
        {
            FirstName = "John";
            LastName = "Doe";
            Phone = "0000000000";
        }

        public Employee(string firstName, string lastName, string phone)
        {
            FirstName = firstName;
            LastName = lastName;
            Phone = phone;

        }
        public override string ToString()
        {
            string output = string.Empty;
            output += string.Format("{0}, {1}", LastName, FirstName);
            if (Phone != null || Phone != "")
            {
                output += string.Format("({0}) {1}-{2}", Phone.Substring(0, 3), Phone.Substring(3, 3), Phone.Substring(6, 4));
            }
                return output;
        }

    }
}
