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
    
    public partial class viw_SYSTEM_SCHEMA_ATTRIBUTES
    {
        public int Model_ID { get; set; }
        public System.Guid Model_MUID { get; set; }
        public string Model_Name { get; set; }
        public int Entity_ID { get; set; }
        public System.Guid Entity_MUID { get; set; }
        public string Entity_Name { get; set; }
        public int Attribute_ID { get; set; }
        public System.Guid Attribute_MUID { get; set; }
        public string Attribute_Name { get; set; }
        public string Attribute_Description { get; set; }
        public string Attribute_DisplayName { get; set; }
        public int Attribute_DisplayWidth { get; set; }
        public int Attribute_ChangeTrackingGroup { get; set; }
        public string Attribute_Column { get; set; }
        public bool Attribute_IsSystem { get; set; }
        public bool Attribute_IsReadOnly { get; set; }
        public bool Attribute_IsCode { get; set; }
        public bool Attribute_IsName { get; set; }
        public byte Attribute_MemberType_ID { get; set; }
        public string Attribute_MemberType_Name { get; set; }
        public byte Attribute_Type_ID { get; set; }
        public string Attribute_Type_Name { get; set; }
        public Nullable<int> Attribute_DBAEntity_ID { get; set; }
        public Nullable<System.Guid> Attribute_DBAEntity_MUID { get; set; }
        public string Attribute_DBAEntity_Name { get; set; }
        public int Attribute_DBAEntity_IsHierarchyEnabled { get; set; }
        public Nullable<int> FilterParentAttribute_ID { get; set; }
        public Nullable<System.Guid> FilterParentAttribute_MUID { get; set; }
        public string FilterParentAttribute_Name { get; set; }
        public Nullable<int> FilterParentHierarchy_ID { get; set; }
        public Nullable<System.Guid> FilterParentHierarchy_MUID { get; set; }
        public string FilterParentHierarchy_Name { get; set; }
        public Nullable<int> FilterParentHierarchy_LevelNumber { get; set; }
        public byte Attribute_DataType_ID { get; set; }
        public string Attribute_DataType_Name { get; set; }
        public Nullable<int> Attribute_DataType_Information { get; set; }
        public int Attribute_DataMask_ID { get; set; }
        public string Attribute_DataMask_Name { get; set; }
        public string Entity_PhysicalTableName { get; set; }
        public int Attribute_SortOrder { get; set; }
        public int EnteredUser_ID { get; set; }
        public Nullable<System.Guid> EnteredUser_MUID { get; set; }
        public string EnteredUser_UserName { get; set; }
        public System.DateTime EnteredUser_DTM { get; set; }
        public int LastChgUser_ID { get; set; }
        public Nullable<System.Guid> LastChgUser_MUID { get; set; }
        public string LastChgUser_UserName { get; set; }
        public System.DateTime LastChgUser_DTM { get; set; }
        public string Attribute_FullyQualifiedName { get; set; }
    }
}
