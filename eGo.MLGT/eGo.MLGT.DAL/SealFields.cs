//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace eGo.MLGT.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class SealFields
    {
        public System.Guid Id { get; set; }
        public System.Guid SealId { get; set; }
        public System.Guid FieldTypeId { get; set; }
        public string FieldName { get; set; }
        public bool IsRequired { get; set; }
        public bool IsEmail { get; set; }
        public short OrderNumber { get; set; }
    
        public virtual FieldTypes FieldTypes { get; set; }
        public virtual Seals Seals { get; set; }
    }
}
