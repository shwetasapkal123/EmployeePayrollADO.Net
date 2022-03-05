using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayrollServiceADONet
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WELCOME to EmployeePayroll in ADO.Net");
            EmployeeRepository employeeRepository = new EmployeeRepository();
            EmployeeModel model = new EmployeeModel
            {
                Address = "Karnataka",
            Name = "Hima",
            Gender = 'F',
            Phone = 9800765434,
            BasicPay = 65430,
           Start_Date = DateTime.Now,
           Department="Developer",
           Deductions=500.00,
           Taxable=300.00,
           IncomeTax=478.00,
           NetPay=30000.00,
           Id=2
            };
            //employeeRepository.GetAllEmployee();
           // employeeRepository.AddEmployee(model);
            employeeRepository.GetAllEmployeesWithDataAdapter();
            Console.ReadLine();
        }
    }
}
