//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyWCFServices.LINQBookHubDAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class stock_detail
    {
        public int doc_no { get; set; }
        public decimal sr_no { get; set; }
        public Nullable<int> code_value { get; set; }
        public Nullable<decimal> qty_in { get; set; }
        public Nullable<decimal> qty_out { get; set; }
    
        public virtual stock_master stock_master { get; set; }
        public virtual tr_header tr_header { get; set; }
    }
}