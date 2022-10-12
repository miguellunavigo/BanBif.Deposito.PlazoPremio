using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanBif.Deposito.PlazoPremio.BE
{
    public class DatosCampaniaCarruselResult
    {
        public int IdCarrusel { get; set; }
        public Nullable<int> IdCampania { get; set; }
        public Nullable<int> Orden { get; set; }
        public string TextoPrimario { get; set; }
        public Nullable<int> Estado { get; set; }

    }
}
