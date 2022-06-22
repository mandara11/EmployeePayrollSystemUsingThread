using EmployeePayrollSystemUsingThread;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace EmployeePayrollTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Given10Employee_WhenAddedToList_ShouldMatchEmployeeEntries()
        {
            List<EmployeeDetails> employeeDetails = new List<EmployeeDetails>();
            employeeDetails.Add(new EmployeeDetails(EmployeeID: 1, EmployeeName: "Bruce", PhoneNumber: "9988776699", Address: "xyz", Department: "HR", Gender: "M", BasicPay: 100, Deductions: 2, TaxablePay: 20, Tax: 100, NetPay: 400, City: "Banglore", Country: "India"));
            employeeDetails.Add(new EmployeeDetails(EmployeeID: 2, EmployeeName: "Wayne", PhoneNumber: "9988776699", Address: "xyz", Department: "HR", Gender: "M", BasicPay: 100, Deductions: 2, TaxablePay: 20, Tax: 100, NetPay: 400, City: "Banglore", Country: "India"));
            employeeDetails.Add(new EmployeeDetails(EmployeeID: 3, EmployeeName: "Peter", PhoneNumber: "9988776699", Address: "xyz", Department: "HR", Gender: "M", BasicPay: 100, Deductions: 2, TaxablePay: 20, Tax: 100, NetPay: 400, City: "Banglore", Country: "India"));
            employeeDetails.Add(new EmployeeDetails(EmployeeID: 4, EmployeeName: "Parker", PhoneNumber: "9988776699", Address: "xyz", Department: "HR", Gender: "M", BasicPay: 100, Deductions: 2, TaxablePay: 20, Tax: 100, NetPay: 400, City: "Banglore", Country: "India"));
            employeeDetails.Add(new EmployeeDetails(EmployeeID: 5, EmployeeName: "Tony", PhoneNumber: "9988776699", Address: "xyz", Department: "HR", Gender: "M", BasicPay: 100, Deductions: 2, TaxablePay: 20, Tax: 100, NetPay: 400, City: "Banglore", Country: "India"));
            employeeDetails.Add(new EmployeeDetails(EmployeeID: 6, EmployeeName: "Stark", PhoneNumber: "9988776699", Address: "xyz", Department: "HR", Gender: "M", BasicPay: 100, Deductions: 2, TaxablePay: 20, Tax: 100, NetPay: 400, City: "Banglore", Country: "India"));
            employeeDetails.Add(new EmployeeDetails(EmployeeID: 7, EmployeeName: "Bruce", PhoneNumber: "9988776699", Address: "xyz", Department: "HR", Gender: "M", BasicPay: 100, Deductions: 2, TaxablePay: 20, Tax: 100, NetPay: 400, City: "Banglore", Country: "India"));
            employeeDetails.Add(new EmployeeDetails(EmployeeID: 8, EmployeeName: "Banner", PhoneNumber: "9988776699", Address: "xyz", Department: "HR", Gender: "M", BasicPay: 100, Deductions: 2, TaxablePay: 20, Tax: 100, NetPay: 400, City: "Banglore", Country: "India"));
            employeeDetails.Add(new EmployeeDetails(EmployeeID: 9, EmployeeName: "Clark", PhoneNumber: "9988776699", Address: "xyz", Department: "HR", Gender: "M", BasicPay: 100, Deductions: 2, TaxablePay: 20, Tax: 100, NetPay: 400, City: "Banglore", Country: "India"));
            employeeDetails.Add(new EmployeeDetails(EmployeeID: 10, EmployeeName: "Kent", PhoneNumber: "9988776699", Address: "xyz", Department: "HR", Gender: "M", BasicPay: 100, Deductions: 2, TaxablePay: 20, Tax: 100, NetPay: 400, City: "Banglore", Country: "India"));

            EmployeePayrollOperations employeePayrollOperations = new EmployeePayrollOperations();
            DateTime startDateTime = DateTime.Now;
            employeePayrollOperations.addEmployeeToPayroll(employeeDetails);
            DateTime stopDateTime = DateTime.Now;
            Console.WriteLine("Duration without Thread: " + (stopDateTime - startDateTime));

            DateTime startDateTimeThread = DateTime.Now;
            employeePayrollOperations.addEmployeeToPayrollWithThread(employeeDetails);
            DateTime stopDateTimeThread = DateTime.Now;
            Console.WriteLine("Duration with Thread: " + (stopDateTimeThread - startDateTimeThread));
        }
    }
}