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
    
    public partial class tblAttributeGroupDetail
    {
        public int ID { get; set; }
        public System.Guid MUID { get; set; }
        public int AttributeGroup_ID { get; set; }
        public int Attribute_ID { get; set; }
        public int SortOrder { get; set; }
        public System.DateTime EnterDTM { get; set; }
        public int EnterUserID { get; set; }
        public int EnterVersionID { get; set; }
        public System.DateTime LastChgDTM { get; set; }
        public int LastChgUserID { get; set; }
        public int LastChgVersionID { get; set; }
        public byte[] LastChgTS { get; set; }
    
        public virtual tblAttribute tblAttribute { get; set; }
        public virtual tblAttributeGroup tblAttributeGroup { get; set; }
    }
}
