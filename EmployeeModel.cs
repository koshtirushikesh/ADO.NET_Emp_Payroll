using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayRoll
{
    public class EmployeeModel
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; } 
        public string Department { get; set; }
        public Char Gender { get; set; }
        public Double BasicPay { get; set; }
        public Double Deductions { get; set; }
        public Double TaxablePay { get; set; }
        public Double Tax { get; set; }
        public Double NetPay { get; set; }
        public DateTime StartDate { get; set; }
        public string City { get; set; }
        public string Country { get; set; }



    }
}
