﻿using System;
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
    public class PeopleController : ControllerBase //Mi ruta es People porque está después de People
    {
        [HttpGet]
        public Person Listar() //Creamos el objeto person 
        {
            Person person = new Person()// Obejto person de Person, lo declara como apuntador
            {
                PersonId = 1, //No ponemos punto y coma porque sino deberíamos poner PersonId.Get()
                Name = "Salma Eid"//Ambos declarados en la clase con get y set
            };
            return person;//retornamos PersonId y Name
        }
    }
}
/*Lista de acceso rápido
 ctrl+r --> para cambiar el nombre de un modelo o clase
prop tab tab --> para crear directamente el get y set
ctrl+. (punto) --> es para cuando alguna palabra me sale en rojo, esto me va a decir que librería debo incluir 
*/

