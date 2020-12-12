using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ApiPrue.Models;

namespace ApiPrue.Controllers
{
    [RoutePrefix("api/operaciones")]
    public class NumerosController : ApiController
    {
        [HttpGet]
        [Route("{number:int}")]
        public Numero Operations(int number)
        {
            Numero model = new Numero();
            model.numero = number;

            if (number < 0)
                model.mensaje = "ERROR";

            if (number == 0)
                model.mensaje = "Realizado por okar";

            if (number > 0)
                model.mensaje = "Usted ingreso el numero " + number.ToString();

            return model;
        }
    }
}