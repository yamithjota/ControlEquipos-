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
    
    public partial class equipos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public equipos()
        {
            this.equipos_caract = new HashSet<equipos_caract>();
            this.equipos_software = new HashSet<equipos_software>();
            this.solicitud_equipo = new HashSet<solicitud_equipo>();
            this.perifericos = new HashSet<perifericos>();
        }
    
        public string serial_equipo { get; set; }
        public int nro_equippo { get; set; }
        public string tipo_equipo { get; set; }
        public int id_marca { get; set; }
        public int id_sala { get; set; }
    
        public virtual marcas marcas { get; set; }
        public virtual salas salas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<equipos_caract> equipos_caract { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<equipos_software> equipos_software { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<solicitud_equipo> solicitud_equipo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<perifericos> perifericos { get; set; }
    }
}