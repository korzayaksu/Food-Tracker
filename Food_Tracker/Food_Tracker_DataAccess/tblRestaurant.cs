//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Food_Tracker_DataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblRestaurant
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblRestaurant()
        {
            this.tblUsersComments = new HashSet<tblUsersComments>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }
        public long PhoneNumber { get; set; }
        public string Bio { get; set; }
        public int CategoryId { get; set; }
        public int Since { get; set; }
        public string City { get; set; }
        public string District { get; set; }
    
        public virtual tblCategory tblCategory { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblUsersComments> tblUsersComments { get; set; }
    }
}
