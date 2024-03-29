﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capgemini.Pecunia.Exceptions;
using Capgemini.Pecunia.Entities;
using Capgemini.Pecunia.DataAccessLayer;
using System.Text.RegularExpressions;

namespace Capgemini.Pecunia.BusinessLayer
{
    public class EmployeeBL
    {
        public static bool EmployeeLogInBL(Employee employee)
        {
            bool employeeLoggedIn = false;
            try
            {
                EmployeeDAL employeeDAL = new EmployeeDAL();
                employeeLoggedIn = employeeDAL.EmployeeLogInDAL(employee);
            }
            catch (Exception ex)
            {

                throw new PecuniaException(ex.Message);
            }

            return employeeLoggedIn;
        }

        private static bool ValidateEmployee(Employee employee)
        {
            StringBuilder sb = new StringBuilder();
            bool validEmployee = true;

            if (Regex.IsMatch(employee.EmployeeID, "[EMP][0-9]{14}$") != true)   //employeeID should start from "EMP" followed by digits and total length 14.
            {
                validEmployee = false;
                sb.Append(Environment.NewLine + "Invalid Employee ID");

            }
            if (employee.EmployeeName == " ")               //employee name should not be empty
            {
                validEmployee = false;
                sb.Append(Environment.NewLine + "Employee Name Required");

            }           
            if (Regex.IsMatch(employee.EmployeeName, "^[a-zA-Z ]{2,30}*$") != true)        //employee name can consist of only first name space and last name with total length upto 30 
            {
                validEmployee = false;
                sb.Append(Environment.NewLine + "Employee Name should be between 2 to 30 characters");

            }
            if (Regex.IsMatch(employee.EmployeeCode, "[EMC][0-9]{14}$") != true)     //employee code should start from "EMC" followed by digits and total length 14.  
            {
                validEmployee = false;
                sb.Append(Environment.NewLine + "Employee Code should be valid");

            }          
            if (Regex.IsMatch(employee.EmployeeEmail, @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$") != true) //employee email must consist of letters, numbers with @ and a domain name.
            {
                validEmployee = false;
                sb.Append(Environment.NewLine + "Employee Email should be valid");

            }            
            if (Regex.IsMatch(employee.EmployeePassword, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,10}$") != true)    //employee password must consist of atleast one small letter, one capital letter, special character and digits with total length upto 8-10
            {                
                validEmployee = false;
                sb.Append(Environment.NewLine + "Employee Password should be valid");

            }
            if (Regex.IsMatch(employee.EmployeeMobile, "^([9]{1})([234789]{1})([0-9]{8})$") != true)   //employee mobile number should be only digits and starting with "91" with total length upto 10 
            {
                validEmployee = false;
                sb.Append(Environment.NewLine + "Employee Mobile should be valid");

            }
            if (validEmployee == false)
                throw new PecuniaException(sb.ToString());
            return validEmployee;
        }


        public static bool AddEmployeeBL(Employee newEmployee)
        {
            bool employeeAdded = false;
            try
            {
                if (ValidateEmployee(newEmployee))
                {
                    EmployeeDAL employeeDAL = new EmployeeDAL();         //calling DAL class method to add employee
                    employeeAdded = employeeDAL.AddEmployeeDAL(newEmployee);
                }
            }
            catch (PecuniaException)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return employeeAdded;
        }

        public static List<Employee> GetAllEmployeesBL()
        {
            List<Employee> employeeList = null;
            try
            {
                EmployeeDAL employeeDAL = new EmployeeDAL();        //calling DAL class method to list employees
                employeeList = employeeDAL.GetAllEmployeesDAL();
            }
            catch (PecuniaException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return employeeList;
        }

        public static Employee SearchEmployeeBL(string searchEmployeeID)
        {
            Employee searchEmployee = null;
            try
            {
                EmployeeDAL employeeDAL = new EmployeeDAL();    //calling DAL class method to search employees
                searchEmployee = employeeDAL.SearchEmployeeDAL(searchEmployeeID);
            }
            catch (PecuniaException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return searchEmployee;

        }

        public static bool UpdateEmployeeBL(Employee updateEmployee)
        {
            bool employeeUpdated = false;
            try
            {
                if (ValidateEmployee(updateEmployee))
                {
                    EmployeeDAL employeeDAL = new EmployeeDAL();       //calling DAL class method to update employees
                    employeeUpdated = employeeDAL.UpdateEmployeeDAL(updateEmployee);
                }
            }
            catch (PecuniaException)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return employeeUpdated;
        }

        public static bool DeleteEmployeeBL(string deleteEmployeeID)
        {
            bool employeeDeleted = false;
            try
            {
                if (Regex.IsMatch(deleteEmployeeID, "[EMP][0-9]{14}$") == true)   //matching user provided employeeID with employeeID in list
                {
                    EmployeeDAL employeeDAL = new EmployeeDAL();
                    employeeDeleted = employeeDAL.DeleteEmployeeDAL(deleteEmployeeID);   //if matched, the employee is deleted by calling DAL class method
                }
                else
                {
                    throw new PecuniaException("Invalid Employee ID");
                }
            }
            catch (PecuniaException)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return employeeDeleted;
        }


    }
}
