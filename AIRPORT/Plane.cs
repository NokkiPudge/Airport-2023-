//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AIRPORT
{
    using System;
    using System.Collections.Generic;
    
    public partial class Plane
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Plane()
        {
            this.Flight = new HashSet<Flight>();
        }
    
        public int PlaneID { get; set; }
        public string Model { get; set; }
        public int CommanderID { get; set; }
        public string ReadyToFlyOrNot { get; set; }
        public Nullable<System.DateTime> ServiceeLife { get; set; }
    
        public virtual Commander Commander { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Flight> Flight { get; set; }
    }
}
