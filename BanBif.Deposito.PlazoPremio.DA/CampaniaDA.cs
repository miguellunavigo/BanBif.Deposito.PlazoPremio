using BanBif.Deposito.PlazoPremio.BE;
//using BanBif.Deposito.PlazoPremio.BE.Conyugues;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanBif.Deposito.PlazoPremio.DA
{
    public class CampaniaDA
    {
        public ReinventaDatosCampaniaResult ObtenerDatosCampania(string urlCampania)
        {
            using (panelEntities db = new panelEntities())
            {
                ReinventaDatosCampaniaResult result = null;
                var objDatosCampania = db.ReinventaDatosCampania.Where(p => p.Estado == 1 && p.UrlCampania == urlCampania).FirstOrDefault();



                if (objDatosCampania != null)
                {
                    if (!(objDatosCampania.FechaInicio.Value <= DateTime.Now && objDatosCampania.FechaFin.Value >= DateTime.Now))
                    {
                        return null;
                    }
                    result = new ReinventaDatosCampaniaResult();
                    result.IdCampania = objDatosCampania.IdCampania;
                    result.NombreCampania = objDatosCampania.NombreCampania;
                    result.FechaInicio = objDatosCampania.FechaInicio;
                    result.FechaFin = objDatosCampania.FechaFin;
                    result.ColorCabecera = objDatosCampania.ColorCabecera;
                    result.ColorDetalle = objDatosCampania.ColorDetalle;
                    result.TextoPrimario = objDatosCampania.TextoPrimario;
                    result.TextoSecundario = objDatosCampania.TextoSecundario;
                    result.ImagenPrimario = objDatosCampania.ImagenPrimario;
                    result.FlagCarrusel = objDatosCampania.FlagCarrusel;
                    result.ImagenSecundario = objDatosCampania.ImagenSecundario;
                    result.TextoTerciario = objDatosCampania.TextoTerciario;
                    result.UrlCampania = objDatosCampania.UrlCampania;
                    result.TextoFinal1 = objDatosCampania.TextoFinal1;
                    result.TextoFinal2 = objDatosCampania.TextoFinal2;
                    result.TextoFinalUrl = objDatosCampania.TextoFinalUrl;
                    result.ImagenFinal = objDatosCampania.ImagenFinal;
                    result.MasInformacion = objDatosCampania.MasInformacion;

                    result.UsuarioCreacion = objDatosCampania.UsuarioCreacion;
                    result.Estado = objDatosCampania.Estado;
                    if (result.FlagCarrusel.Value)
                    {
                        var objDatosCampaniaCarrusel = db.ReinventaDatosCampaniaCarrusel.Where(p => p.Estado == 1 && p.IdCampania == objDatosCampania.IdCampania).ToList();
                        foreach (var item in objDatosCampaniaCarrusel)
                        {
                            result.ListCarrusel.Add(new DatosCampaniaCarruselResult()
                            {
                                IdCarrusel = item.IdCarrusel,
                                IdCampania = item.IdCampania,
                                Orden = item.Orden,
                                TextoPrimario = item.TextoPrimario
                            });
                        }
                    }
                }

                return result;
            }
        }

        public ReinventaDatosCampaniaRegistroResponse GuardarDatosCampania(ReinventaDatosCampaniaRegistroRequest request)
        {
            using (var db = new panelEntities())
            {

                ReinventaDatosCampaniaRegistroResponse response = new ReinventaDatosCampaniaRegistroResponse(); ;
                try
                {
                    ReinventaDatosCampaniaRegistro registro = new ReinventaDatosCampaniaRegistro();

                    registro.IdRegistro = request.IdRegistro;
                    registro.IdCampania = request.IdCampania;
                    registro.DocumentoIdentidad = request.DocumentoIdentidad;
                    registro.NombresApellidos = request.NombresApellidos;
                    registro.Telefono = request.Telefono;
                    registro.Correo = request.Correo;
                    registro.FechaRegistro = request.FechaRegistro;
                    registro.CheckProteccionDatos = request.CheckProteccionDatos;
                    db.ReinventaDatosCampaniaRegistro.Add(registro);
                    db.SaveChanges();




                    /*TRANSACCION RESULT (ENVIO CORREO)*/
                    var transaccionResult = new ReinventaDatosCampaniaRegistroResult
                    {
                        IdRegistro = request.IdRegistro,
                        IdCampania = request.IdCampania,
                        DocumentoIdentidad = request.DocumentoIdentidad,
                        NombresApellidos = request.NombresApellidos,
                        Telefono = request.Telefono,
                        Correo = request.Correo,
                        FechaRegistro = request.FechaRegistro,
                        CheckProteccionDatos = request.CheckProteccionDatos
                    };

                    response.Data = transaccionResult;
                    return response;
                }
                catch (Exception e)
                {
                    response.Result = false;
                    response.Mensaje = e.InnerException.ToString();
                    return response;
                }
            }
        }

    }
}
