using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Sumar.Controllers
{
    [Route("api/[controller]")] // para controlar nuestro servidor
    [ApiController]
    public class SumaController : ControllerBase
    {
        [HttpGet]
        public int Add(int a, int b) //Creamos este método público donde también creamos los elementos
        {
            return a + b; //Una vez éstos sumados, enviamos la suma 
        }

        [HttpPost]
        public int Add2([FromHeader] int a, [FromHeader] int b) //Creamos este método público donde también creamos los elementos
        {
            return a + b;
        }
    }
}

