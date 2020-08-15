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
    public class SumaController : ControllerBase //El nombre con que guardamos antes de Controller ese va después de /api/ sin mayuscula
    {
        [HttpGet]
        [Route("Add")] //Para saber cual get vamos a correr, le aumentamos una ruta
        public int Add(int a, int b) //Creamos este método público donde también creamos los elementos
        {
            return a + b; //Una vez éstos sumados, enviamos la suma 
            
        }

        [HttpPost]
        [Route("Add")]
        public int Add2([FromHeader] int a, [FromHeader] int b) 
            // Fromheader es porque el valor no va a ser como parámetro,el Post no se ve lo que hace en el url osea el a y b
        {
            return a + b;
        }
        [HttpGet]
        [Route("Multiply")]
        public int Mul(int a, int b)
        {
            return a * b;
        }
        [HttpPost]
        [Route("Multiply")]//Es la tercera ruta para que diferenciemos al momento de hacerlo correr 
        public int Mul2([FromHeader] int a, [FromHeader] int b)
        {
            return a * b;
        }


    }
}

