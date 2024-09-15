using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise56
{
    public class Staff : Person
    {
        public int EmployeeID { get; set; }
        public string Department { get; set; }

        public Staff(string name, string address, int employeeID, string department) : base(name, address)
        {
            EmployeeID = employeeID;
            Department = department;
        }
    }
}
