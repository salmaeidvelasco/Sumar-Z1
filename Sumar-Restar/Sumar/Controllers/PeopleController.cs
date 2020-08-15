using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sumar.Models;

namespace Sumar.Controllers
{
    [Route("api/[controller]")]//ctrl r se puede cambiar nombre de la clase o controlador para crear esto pusimos agregagr controlador
    [ApiController]
    public class PeopleController : ControllerBase //Mi ruta es People
    {
        [HttpGet]
        public Person Listar() //Creamos el objeto person 
        {
            Person person = new Person()// Obejto person de Person
            {
                PersonId = 1,
                Name = "Salma Eid"
            };
            return person;
        }
    }
}
