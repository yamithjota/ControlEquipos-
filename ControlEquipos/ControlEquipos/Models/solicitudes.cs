//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ControlEquipos.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class solicitudes
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public solicitudes()
        {
            this.solicitud_equipo = new HashSet<solicitud_equipo>();
        }
    
        public int nro_solicitud { get; set; }
        public System.DateTime fecha_solicitud { get; set; }
        public Nullable<System.DateTime> fecha_atencion { get; set; }
        public Nullable<System.DateTime> fecha_cierre { get; set; }
        public string obs_solicitud { get; set; }
        public string tipo_solicitud { get; set; }
        public decimal id_persona_sol { get; set; }
        public Nullable<decimal> id_persona_ati { get; set; }
    
        public virtual personas personas { get; set; }
        public virtual personas personas1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<solicitud_equipo> solicitud_equipo { get; set; }
    }
}
