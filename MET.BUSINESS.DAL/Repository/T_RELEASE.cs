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
    
    public partial class T_RELEASE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public T_RELEASE()
        {
            this.T_RELEASE_USER_ACCESS = new HashSet<T_RELEASE_USER_ACCESS>();
            this.T_SPRINT = new HashSet<T_SPRINT>();
            this.T_WORK_ITEM = new HashSet<T_WORK_ITEM>();
        }
    
        public long RELEASE_SEQ { get; set; }
        public string RELEASE_NBR { get; set; }
        public Nullable<long> SYSTEM_SEQ { get; set; }
        public Nullable<int> UAT_KICK_OFF { get; set; }
        public Nullable<int> NBR_PLAYBOOK { get; set; }
        public Nullable<int> NBR_ENVIRONMENT { get; set; }
        public Nullable<int> NBR_BUILDS { get; set; }
        public Nullable<int> NBR_DEPLOYMENTS { get; set; }
        public Nullable<int> NBR_PLAYBOOK_MEETING { get; set; }
        public Nullable<int> NBR_DB_REFRESH { get; set; }
        public Nullable<int> NBR_SECURITY_SUPPORT_HOUR { get; set; }
        public Nullable<int> NBR_LOAD_TEST { get; set; }
        public Nullable<int> NBR_BATCH_VOLUME_TEST { get; set; }
        public Nullable<int> NBR_SECURITY_TEST { get; set; }
        public Nullable<int> NBR_DESIGN_SESSION { get; set; }
        public Nullable<int> NBR_ARCHITECTURE_REVIEW { get; set; }
        public Nullable<int> TFS_RELEASE_ID { get; set; }
        public string UPDTD_BY { get; set; }
        public Nullable<System.DateTime> UPDTD_DTE { get; set; }
    
        public virtual T_SYSTEM T_SYSTEM { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_RELEASE_USER_ACCESS> T_RELEASE_USER_ACCESS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_SPRINT> T_SPRINT { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_WORK_ITEM> T_WORK_ITEM { get; set; }
    }
}
