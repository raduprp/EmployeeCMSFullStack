using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }

        public string EmployeeFirstName { get; set; }

        public string EmployeeLastName { get; set; }

        public string EmployeeEmail { get; set; }

        public string EmployeeSex { get; set; }

        public string BirthDate { get; set; }

        public string PhotoFileName { get; set; }
    }
}
