//------------------------------------------------------------------------------
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
    
    public partial class GetAllTransactions_Result
    {
        public System.Guid TransactionID { get; set; }
        public Nullable<System.Guid> AccountID { get; set; }
        public string TypeOfTransaction { get; set; }
        public decimal Amount { get; set; }
        public Nullable<System.DateTime> DateOfTransaction { get; set; }
        public string Mode { get; set; }
        public string ChequeNumber { get; set; }
    }
}
