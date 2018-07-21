//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DatabaseEntity.Database
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    [DataContract]
    public partial class StateProvince
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]

        public StateProvince()
        {
            this.Addresses = new HashSet<Address>();
        }

        [DataMember]
        public int StateProvinceID { get; set; }
        [DataMember]
        public string StateProvinceCode { get; set; }
        [DataMember]
        public string CountryRegionCode { get; set; }
        [DataMember]
        public bool IsOnlyStateProvinceFlag { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public int TerritoryID { get; set; }
        [DataMember]
        public System.Guid rowguid { get; set; }
        [DataMember]
        public System.DateTime ModifiedDate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

        public virtual ICollection<Address> Addresses { get; set; }

        public virtual CountryRegion CountryRegion { get; set; }
    }
}
