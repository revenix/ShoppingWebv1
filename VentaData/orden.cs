//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VentaData
{
    using System;
    using System.Collections.Generic;
    
    public partial class orden
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public orden()
        {
            this.detalleorden = new HashSet<detalleorden>();
        }
    
        public string num_orden { get; set; }
        public System.DateTime fecha_emi { get; set; }
        public string id_cliente { get; set; }
        public decimal monto { get; set; }
        public decimal descuento { get; set; }
        public System.DateTime shipping_date { get; set; }
        public string shipping_lugar { get; set; }
        public string id_orden { get; set; }
    
        public virtual cliente cliente { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<detalleorden> detalleorden { get; set; }
        public virtual estado_orden estado_orden { get; set; }
    }
}
