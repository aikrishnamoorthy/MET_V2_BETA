//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MET.BUSINESS.DAL.Repository
{
    using System;
    
    public partial class USP_ASSIGNMENT_GET_HISTORY_Result
    {
        public long ASSIGNMENT_HIST_SEQ { get; set; }
        public long ASSIGNMENT_SEQ { get; set; }
        public Nullable<long> WORK_ITEM_SEQ { get; set; }
        public Nullable<long> USER_SEQ { get; set; }
        public Nullable<long> STATUS_CDE { get; set; }
        public string COMMENTS { get; set; }
        public Nullable<System.DateTime> UPDTD_DTE { get; set; }
        public string UPDTD_BY { get; set; }
        public Nullable<System.DateTime> HIST_UPDTD_DTE { get; set; }
        public string HIST_UPDTD_BY { get; set; }
        public Nullable<System.DateTime> DUE_DATE { get; set; }
    }
}
