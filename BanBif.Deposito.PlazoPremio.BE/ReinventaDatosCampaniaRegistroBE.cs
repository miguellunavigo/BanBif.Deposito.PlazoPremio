using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanBif.Deposito.PlazoPremio.BE
{
    public class ReinventaDatosCampaniaRegistroResult
    {
        public int IdRegistro { get; set; }
        public Nullable<int> IdCampania { get; set; }
        public string DocumentoIdentidad { get; set; }
        public string NombresApellidos { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public Nullable<System.DateTime> FechaRegistro { get; set; }
        public Nullable<bool> CheckProteccionDatos { get; set; }
    }
    public class ReinventaDatosCampaniaRegistroResponse
    {
        public bool Result { get; set; }
        public string Mensaje { get; set; }
        public ReinventaDatosCampaniaRegistroResult Data { get; set; }
    }
    public class ReinventaDatosCampaniaRegistroRequest
    {
        public int IdRegistro { get; set; }
        public Nullable<int> IdCampania { get; set; }
        public string DocumentoIdentidad { get; set; }
        public string NombresApellidos { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public Nullable<System.DateTime> FechaRegistro { get; set; }
        public Nullable<bool> CheckProteccionDatos { get; set; }
    }
}
