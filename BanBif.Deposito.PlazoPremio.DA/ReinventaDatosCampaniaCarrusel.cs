//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BanBif.Deposito.PlazoPremio.DA
{
    using System;
    using System.Collections.Generic;
    
    public partial class ReinventaDatosCampaniaCarrusel
    {
        public int IdCarrusel { get; set; }
        public Nullable<int> IdCampania { get; set; }
        public Nullable<int> Orden { get; set; }
        public string TextoPrimario { get; set; }
        public Nullable<int> Estado { get; set; }
    
        public virtual ReinventaDatosCampania ReinventaDatosCampania { get; set; }
    }
}
