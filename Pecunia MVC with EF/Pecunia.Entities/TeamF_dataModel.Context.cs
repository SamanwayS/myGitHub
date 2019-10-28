﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Capgemini.Pecunia.Entities
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class PecuniaEntities : DbContext
    {
        public PecuniaEntities()
            : base("name=PecuniaEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<CarLoan> CarLoans { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<EduLoan> EduLoans { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<FixedDeposit> FixedDeposits { get; set; }
        public virtual DbSet<HomeLoan> HomeLoans { get; set; }
        public virtual DbSet<Transaction> Transactions { get; set; }
    
        public virtual int applyCarLoan(Nullable<System.Guid> loanID, Nullable<System.Guid> customerID, Nullable<decimal> amountApplied, Nullable<decimal> interestRate, Nullable<decimal> eMI_amount, Nullable<byte> repaymentPeriod, Nullable<System.DateTime> dateOfApplication, string loanStatus, string occupation, Nullable<decimal> grossIncome, Nullable<decimal> salaryDeduction, string vehicleType)
        {
            var loanIDParameter = loanID.HasValue ?
                new ObjectParameter("LoanID", loanID) :
                new ObjectParameter("LoanID", typeof(System.Guid));
    
            var customerIDParameter = customerID.HasValue ?
                new ObjectParameter("CustomerID", customerID) :
                new ObjectParameter("CustomerID", typeof(System.Guid));
    
            var amountAppliedParameter = amountApplied.HasValue ?
                new ObjectParameter("AmountApplied", amountApplied) :
                new ObjectParameter("AmountApplied", typeof(decimal));
    
            var interestRateParameter = interestRate.HasValue ?
                new ObjectParameter("InterestRate", interestRate) :
                new ObjectParameter("InterestRate", typeof(decimal));
    
            var eMI_amountParameter = eMI_amount.HasValue ?
                new ObjectParameter("EMI_amount", eMI_amount) :
                new ObjectParameter("EMI_amount", typeof(decimal));
    
            var repaymentPeriodParameter = repaymentPeriod.HasValue ?
                new ObjectParameter("RepaymentPeriod", repaymentPeriod) :
                new ObjectParameter("RepaymentPeriod", typeof(byte));
    
            var dateOfApplicationParameter = dateOfApplication.HasValue ?
                new ObjectParameter("DateOfApplication", dateOfApplication) :
                new ObjectParameter("DateOfApplication", typeof(System.DateTime));
    
            var loanStatusParameter = loanStatus != null ?
                new ObjectParameter("LoanStatus", loanStatus) :
                new ObjectParameter("LoanStatus", typeof(string));
    
            var occupationParameter = occupation != null ?
                new ObjectParameter("Occupation", occupation) :
                new ObjectParameter("Occupation", typeof(string));
    
            var grossIncomeParameter = grossIncome.HasValue ?
                new ObjectParameter("GrossIncome", grossIncome) :
                new ObjectParameter("GrossIncome", typeof(decimal));
    
            var salaryDeductionParameter = salaryDeduction.HasValue ?
                new ObjectParameter("SalaryDeduction", salaryDeduction) :
                new ObjectParameter("SalaryDeduction", typeof(decimal));
    
            var vehicleTypeParameter = vehicleType != null ?
                new ObjectParameter("VehicleType", vehicleType) :
                new ObjectParameter("VehicleType", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("applyCarLoan", loanIDParameter, customerIDParameter, amountAppliedParameter, interestRateParameter, eMI_amountParameter, repaymentPeriodParameter, dateOfApplicationParameter, loanStatusParameter, occupationParameter, grossIncomeParameter, salaryDeductionParameter, vehicleTypeParameter);
        }
    
        public virtual int applyEduLoan(Nullable<System.Guid> loanID, Nullable<System.Guid> customerID, Nullable<decimal> amountApplied, Nullable<decimal> interestRate, Nullable<decimal> eMI_amount, Nullable<byte> repaymentPeriod, Nullable<System.DateTime> dateOfApplication, string loanStatus, string course, string instituteName, string studentID, Nullable<byte> repaymentHoliday)
        {
            var loanIDParameter = loanID.HasValue ?
                new ObjectParameter("LoanID", loanID) :
                new ObjectParameter("LoanID", typeof(System.Guid));
    
            var customerIDParameter = customerID.HasValue ?
                new ObjectParameter("CustomerID", customerID) :
                new ObjectParameter("CustomerID", typeof(System.Guid));
    
            var amountAppliedParameter = amountApplied.HasValue ?
                new ObjectParameter("AmountApplied", amountApplied) :
                new ObjectParameter("AmountApplied", typeof(decimal));
    
            var interestRateParameter = interestRate.HasValue ?
                new ObjectParameter("InterestRate", interestRate) :
                new ObjectParameter("InterestRate", typeof(decimal));
    
            var eMI_amountParameter = eMI_amount.HasValue ?
                new ObjectParameter("EMI_amount", eMI_amount) :
                new ObjectParameter("EMI_amount", typeof(decimal));
    
            var repaymentPeriodParameter = repaymentPeriod.HasValue ?
                new ObjectParameter("RepaymentPeriod", repaymentPeriod) :
                new ObjectParameter("RepaymentPeriod", typeof(byte));
    
            var dateOfApplicationParameter = dateOfApplication.HasValue ?
                new ObjectParameter("DateOfApplication", dateOfApplication) :
                new ObjectParameter("DateOfApplication", typeof(System.DateTime));
    
            var loanStatusParameter = loanStatus != null ?
                new ObjectParameter("LoanStatus", loanStatus) :
                new ObjectParameter("LoanStatus", typeof(string));
    
            var courseParameter = course != null ?
                new ObjectParameter("Course", course) :
                new ObjectParameter("Course", typeof(string));
    
            var instituteNameParameter = instituteName != null ?
                new ObjectParameter("InstituteName", instituteName) :
                new ObjectParameter("InstituteName", typeof(string));
    
            var studentIDParameter = studentID != null ?
                new ObjectParameter("StudentID", studentID) :
                new ObjectParameter("StudentID", typeof(string));
    
            var repaymentHolidayParameter = repaymentHoliday.HasValue ?
                new ObjectParameter("RepaymentHoliday", repaymentHoliday) :
                new ObjectParameter("RepaymentHoliday", typeof(byte));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("applyEduLoan", loanIDParameter, customerIDParameter, amountAppliedParameter, interestRateParameter, eMI_amountParameter, repaymentPeriodParameter, dateOfApplicationParameter, loanStatusParameter, courseParameter, instituteNameParameter, studentIDParameter, repaymentHolidayParameter);
        }
    
        public virtual int applyHomeLoan(Nullable<System.Guid> loanID, Nullable<System.Guid> customerID, Nullable<decimal> amountApplied, Nullable<decimal> interestRate, Nullable<decimal> eMI_amount, Nullable<byte> repaymentPeriod, Nullable<System.DateTime> dateOfApplication, string loanStatus, string occupation, Nullable<byte> serviceYears, Nullable<decimal> grossIncome, Nullable<decimal> salaryDeduction)
        {
            var loanIDParameter = loanID.HasValue ?
                new ObjectParameter("LoanID", loanID) :
                new ObjectParameter("LoanID", typeof(System.Guid));
    
            var customerIDParameter = customerID.HasValue ?
                new ObjectParameter("CustomerID", customerID) :
                new ObjectParameter("CustomerID", typeof(System.Guid));
    
            var amountAppliedParameter = amountApplied.HasValue ?
                new ObjectParameter("AmountApplied", amountApplied) :
                new ObjectParameter("AmountApplied", typeof(decimal));
    
            var interestRateParameter = interestRate.HasValue ?
                new ObjectParameter("InterestRate", interestRate) :
                new ObjectParameter("InterestRate", typeof(decimal));
    
            var eMI_amountParameter = eMI_amount.HasValue ?
                new ObjectParameter("EMI_amount", eMI_amount) :
                new ObjectParameter("EMI_amount", typeof(decimal));
    
            var repaymentPeriodParameter = repaymentPeriod.HasValue ?
                new ObjectParameter("RepaymentPeriod", repaymentPeriod) :
                new ObjectParameter("RepaymentPeriod", typeof(byte));
    
            var dateOfApplicationParameter = dateOfApplication.HasValue ?
                new ObjectParameter("DateOfApplication", dateOfApplication) :
                new ObjectParameter("DateOfApplication", typeof(System.DateTime));
    
            var loanStatusParameter = loanStatus != null ?
                new ObjectParameter("LoanStatus", loanStatus) :
                new ObjectParameter("LoanStatus", typeof(string));
    
            var occupationParameter = occupation != null ?
                new ObjectParameter("Occupation", occupation) :
                new ObjectParameter("Occupation", typeof(string));
    
            var serviceYearsParameter = serviceYears.HasValue ?
                new ObjectParameter("ServiceYears", serviceYears) :
                new ObjectParameter("ServiceYears", typeof(byte));
    
            var grossIncomeParameter = grossIncome.HasValue ?
                new ObjectParameter("GrossIncome", grossIncome) :
                new ObjectParameter("GrossIncome", typeof(decimal));
    
            var salaryDeductionParameter = salaryDeduction.HasValue ?
                new ObjectParameter("SalaryDeduction", salaryDeduction) :
                new ObjectParameter("SalaryDeduction", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("applyHomeLoan", loanIDParameter, customerIDParameter, amountAppliedParameter, interestRateParameter, eMI_amountParameter, repaymentPeriodParameter, dateOfApplicationParameter, loanStatusParameter, occupationParameter, serviceYearsParameter, grossIncomeParameter, salaryDeductionParameter);
        }
    
        public virtual int approveCarLoan(Nullable<System.Guid> loanID, string updatedStatus)
        {
            var loanIDParameter = loanID.HasValue ?
                new ObjectParameter("LoanID", loanID) :
                new ObjectParameter("LoanID", typeof(System.Guid));
    
            var updatedStatusParameter = updatedStatus != null ?
                new ObjectParameter("updatedStatus", updatedStatus) :
                new ObjectParameter("updatedStatus", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("approveCarLoan", loanIDParameter, updatedStatusParameter);
        }
    
        public virtual int approveEduLoan(Nullable<System.Guid> loanID, string updatedStatus)
        {
            var loanIDParameter = loanID.HasValue ?
                new ObjectParameter("LoanID", loanID) :
                new ObjectParameter("LoanID", typeof(System.Guid));
    
            var updatedStatusParameter = updatedStatus != null ?
                new ObjectParameter("updatedStatus", updatedStatus) :
                new ObjectParameter("updatedStatus", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("approveEduLoan", loanIDParameter, updatedStatusParameter);
        }
    
        public virtual int approveHomeLoan(Nullable<System.Guid> loanID, string updatedStatus)
        {
            var loanIDParameter = loanID.HasValue ?
                new ObjectParameter("LoanID", loanID) :
                new ObjectParameter("LoanID", typeof(System.Guid));
    
            var updatedStatusParameter = updatedStatus != null ?
                new ObjectParameter("updatedStatus", updatedStatus) :
                new ObjectParameter("updatedStatus", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("approveHomeLoan", loanIDParameter, updatedStatusParameter);
        }
    
        public virtual int cancelCarLoan(Nullable<System.Guid> loanID)
        {
            var loanIDParameter = loanID.HasValue ?
                new ObjectParameter("loanID", loanID) :
                new ObjectParameter("loanID", typeof(System.Guid));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("cancelCarLoan", loanIDParameter);
        }
    
        public virtual int cancelEduLoan(Nullable<System.Guid> loanID)
        {
            var loanIDParameter = loanID.HasValue ?
                new ObjectParameter("loanID", loanID) :
                new ObjectParameter("loanID", typeof(System.Guid));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("cancelEduLoan", loanIDParameter);
        }
    
        public virtual int cancelHomeLoan(Nullable<System.Guid> loanID)
        {
            var loanIDParameter = loanID.HasValue ?
                new ObjectParameter("loanID", loanID) :
                new ObjectParameter("loanID", typeof(System.Guid));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("cancelHomeLoan", loanIDParameter);
        }
    
        public virtual ObjectResult<getCarLoanByCustomerID_Result> getCarLoanByCustomerID(Nullable<System.Guid> customerID)
        {
            var customerIDParameter = customerID.HasValue ?
                new ObjectParameter("customerID", customerID) :
                new ObjectParameter("customerID", typeof(System.Guid));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getCarLoanByCustomerID_Result>("getCarLoanByCustomerID", customerIDParameter);
        }
    
        public virtual ObjectResult<getCarLoanByLoanID_Result> getCarLoanByLoanID(Nullable<System.Guid> loanID)
        {
            var loanIDParameter = loanID.HasValue ?
                new ObjectParameter("loanID", loanID) :
                new ObjectParameter("loanID", typeof(System.Guid));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getCarLoanByLoanID_Result>("getCarLoanByLoanID", loanIDParameter);
        }
    
        public virtual ObjectResult<string> getCarLoanStatus(Nullable<System.Guid> loanID)
        {
            var loanIDParameter = loanID.HasValue ?
                new ObjectParameter("loanID", loanID) :
                new ObjectParameter("loanID", typeof(System.Guid));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("getCarLoanStatus", loanIDParameter);
        }
    
        public virtual ObjectResult<getEduLoanByCustomerID_Result> getEduLoanByCustomerID(Nullable<System.Guid> customerID)
        {
            var customerIDParameter = customerID.HasValue ?
                new ObjectParameter("customerID", customerID) :
                new ObjectParameter("customerID", typeof(System.Guid));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getEduLoanByCustomerID_Result>("getEduLoanByCustomerID", customerIDParameter);
        }
    
        public virtual ObjectResult<getEduLoanByLoanID_Result> getEduLoanByLoanID(Nullable<System.Guid> loanID)
        {
            var loanIDParameter = loanID.HasValue ?
                new ObjectParameter("loanID", loanID) :
                new ObjectParameter("loanID", typeof(System.Guid));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getEduLoanByLoanID_Result>("getEduLoanByLoanID", loanIDParameter);
        }
    
        public virtual ObjectResult<string> getEduLoanStatus(Nullable<System.Guid> loanID)
        {
            var loanIDParameter = loanID.HasValue ?
                new ObjectParameter("loanID", loanID) :
                new ObjectParameter("loanID", typeof(System.Guid));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("getEduLoanStatus", loanIDParameter);
        }
    
        public virtual ObjectResult<getHomeLoanByCustomerID_Result> getHomeLoanByCustomerID(Nullable<System.Guid> customerID)
        {
            var customerIDParameter = customerID.HasValue ?
                new ObjectParameter("customerID", customerID) :
                new ObjectParameter("customerID", typeof(System.Guid));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getHomeLoanByCustomerID_Result>("getHomeLoanByCustomerID", customerIDParameter);
        }
    
        public virtual ObjectResult<getHomeLoanByLoanID_Result> getHomeLoanByLoanID(Nullable<System.Guid> loanID)
        {
            var loanIDParameter = loanID.HasValue ?
                new ObjectParameter("loanID", loanID) :
                new ObjectParameter("loanID", typeof(System.Guid));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getHomeLoanByLoanID_Result>("getHomeLoanByLoanID", loanIDParameter);
        }
    
        public virtual ObjectResult<string> getHomeLoanStatus(Nullable<System.Guid> loanID)
        {
            var loanIDParameter = loanID.HasValue ?
                new ObjectParameter("loanID", loanID) :
                new ObjectParameter("loanID", typeof(System.Guid));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("getHomeLoanStatus", loanIDParameter);
        }
    }
}
