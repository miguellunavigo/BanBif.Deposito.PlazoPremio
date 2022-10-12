using BanBif.Deposito.PlazoPremio.BE;
using BanBif.Deposito.PlazoPremio.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BanBif.Deposito.PlazoPremio.Api.Controllers
{
    public class CampaniaApiController : ApiController
    {
        [Route("api/Campania/ObtenerDatosCampania")]
        [HttpPost]
        public IHttpActionResult ObtenerDatosCampania(ReinventaDatosCampaniaRequest request)
        {
            var oBL = new CampaniaBL();
            return Json(oBL.ObtenerDatosCampania(request.UrlCampania));
        }
        [Route("api/Campania/registrarDatosCampania")]
        [HttpPost]
        public IHttpActionResult GuardarDatosCampania(ReinventaDatosCampaniaRegistroRequest request)
        {
            var oBL = new CampaniaBL();
            return Json(oBL.GuardarDatosCampania(request));
        }
      
    }
}
