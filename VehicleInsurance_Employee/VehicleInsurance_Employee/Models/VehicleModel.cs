//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VehicleInsurance_Employee.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class VehicleModel
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public VehicleModel()
        {
            this.Vehicles = new HashSet<Vehicle>();
        }

        [Display(Name = "Model ID")]
        public int VehicleModelID { get; set; }

        [Display(Name = "Brand ID")]
        public int VehicleBrandID { get; set; }

        [Display(Name = "Model")]
        public string VehicleModelName { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Vehicle> Vehicles { get; set; }
        public virtual VehicleBrand VehicleBrand { get; set; }
    }
}
