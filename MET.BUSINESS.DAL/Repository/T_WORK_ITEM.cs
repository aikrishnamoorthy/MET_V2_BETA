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
    using System.Collections.Generic;
    
    public partial class T_WORK_ITEM
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public T_WORK_ITEM()
        {
            this.T_ASSIGNMENTS = new HashSet<T_ASSIGNMENTS>();
            this.T_COMPONENT = new HashSet<T_COMPONENT>();
        }
    
        public long WORK_ITEM_SEQ { get; set; }
        public Nullable<long> RELEASE_SEQ { get; set; }
        public string TYPE { get; set; }
        public string TITLE { get; set; }
        public Nullable<double> TOTAL_HOURS { get; set; }
        public Nullable<double> TOTAL_DEV_HOURS { get; set; }
        public Nullable<double> TOTAL_DES_HOURS { get; set; }
        public Nullable<int> TFS_WI_ID { get; set; }
        public string TFS_WI_SEVERITY { get; set; }
        public Nullable<long> SYSTEM_SEQ { get; set; }
        public Nullable<long> SPRINT_SEQ { get; set; }
        public Nullable<System.DateTime> UPDTD_DTE { get; set; }
        public string UPDTD_BY { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_ASSIGNMENTS> T_ASSIGNMENTS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_COMPONENT> T_COMPONENT { get; set; }
        public virtual T_SPRINT T_SPRINT { get; set; }
        public virtual T_RELEASE T_RELEASE { get; set; }
        public virtual T_SYSTEM T_SYSTEM { get; set; }
    }
}