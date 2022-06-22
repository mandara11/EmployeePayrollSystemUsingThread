using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayrollSystemUsingThread
{
    public class EmployeePayrollOperations
    {
        public List<EmployeeDetails> employeePayrollDetailList = new List<EmployeeDetails>();
        //UC1: non threads 
        public void addEmployeeToPayroll(List<EmployeeDetails> employeeDataList)
        {
            employeePayrollDetailList.ForEach(employeeData =>
            {
                Console.WriteLine("Employee being added: " + employeeData.EmployeeName);
                this.addEmployeeToPayroll(employeeData);
                Console.WriteLine("Employee added: " + employeeData.EmployeeName);
            });
            Console.WriteLine(this.employeePayrollDetailList.ToString());
        }

        public void addEmployeeToPayrollWithThread(List<EmployeeDetails> employeePayrollDataList)
        {
            employeePayrollDetailList.ForEach(employeeData =>
            {
                Task thread = new Task(() =>
                {
                    Console.WriteLine("Employee being added: " + employeeData.EmployeeName);
                    this.addEmployeeToPayroll(employeeData);
                    Console.WriteLine("Employee added: " + employeeData.EmployeeName);
                });
                thread.Start();
            });
            Console.WriteLine(this.employeePayrollDetailList.Count);
        }

        public void addEmployeeToPayroll(EmployeeDetails emp)
        {
            //Thread.Sleep(100);//Added this code to so that this proccess take 100 milisecond everytime
            employeePayrollDetailList.Add(emp);
        }
        public int EmployeeCount()
        {
            return this.employeePayrollDetailList.Count;
        }
        public void Display()
        {
            foreach(EmployeeDetails employee in this.employeePayrollDetailList)
            {
                Console.WriteLine(employee.EmployeeID + "" + employee.EmployeeName + "" + employee.PhoneNumber +"" + employee.Address +"" + employee.Department + "" + employee.Gender + "" + employee.BasicPay + "" + employee.Deductions + "" + employee.TaxablePay + "" + employee.Tax + "" + employee.NetPay + "" + employee.City + "" + employee.Country);
            }
        }
    }
}
