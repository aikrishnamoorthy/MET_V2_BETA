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
    
    public partial class T_SYSTEM
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public T_SYSTEM()
        {
            this.T_CONFIG = new HashSet<T_CONFIG>();
            this.T_RELEASE = new HashSet<T_RELEASE>();
            this.T_WORK_ITEM = new HashSet<T_WORK_ITEM>();
        }
    
        public long SYSTEM_SEQ { get; set; }
        public string SYSTEM_NAME { get; set; }
        public string TFS_GUID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_CONFIG> T_CONFIG { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_RELEASE> T_RELEASE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_WORK_ITEM> T_WORK_ITEM { get; set; }
    }
}
