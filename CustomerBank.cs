//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace E1
{
    using System;
    using System.Collections.Generic;
    
    public partial class CustomerBank
    {
        public int CustomerBankId { get; set; }
        public string BankName { get; set; }
        public string BranchName { get; set; }
        public string AccountNumber { get; set; }
        public string IFSCCode { get; set; }
        public Nullable<int> CustomerId { get; set; }
    
        public virtual Customer Customer { get; set; }
    }
}
