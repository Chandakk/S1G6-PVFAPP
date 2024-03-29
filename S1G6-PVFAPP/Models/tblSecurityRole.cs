//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace S1G6_PVFAPP.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblSecurityRole
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblSecurityRole()
        {
            this.tblSecurityAccessControls = new HashSet<tblSecurityAccessControl>();
            this.tblSecurityRoleAccesses = new HashSet<tblSecurityRoleAccess>();
            this.tblSecurityRoleAccessFunctionals = new HashSet<tblSecurityRoleAccessFunctional>();
            this.tblSecurityRoleAccessMembers = new HashSet<tblSecurityRoleAccessMember>();
        }
    
        public int ID { get; set; }
        public System.Guid MUID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public System.DateTime EnterDTM { get; set; }
        public int EnterUserID { get; set; }
        public System.DateTime LastChgDTM { get; set; }
        public int LastChgUserID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblSecurityAccessControl> tblSecurityAccessControls { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblSecurityRoleAccess> tblSecurityRoleAccesses { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblSecurityRoleAccessFunctional> tblSecurityRoleAccessFunctionals { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblSecurityRoleAccessMember> tblSecurityRoleAccessMembers { get; set; }
    }
}
