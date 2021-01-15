using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoCalculadora.Properties.controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class CalculadoraController : Controller
    {
        [HttpGet]
        [Route("suma")]
        public int sumaget(int num1, int num2)
        {
            return num1 + num2;
        }
        [HttpPost]
        [Route("suma")]
        public int sumapost([FromHeader] int num1, [FromHeader] int num2)
        {
            return num1 + num2;
        }
        [HttpGet]
        [Route("resta")]
        public int restaget(int num1, int num2)
        {
            return num1 - num2;
        }
        [HttpPost]
        [Route("resta")]
        public int restapost([FromHeader] int num1, [FromHeader] int num2)
        {
            return num1 - num2;
        }
        [HttpGet]
        [Route("multi")]
        public int multiget(int num1, int num2)
        {
            return num1 * num2;
        }
        [HttpPost]
        [Route("multi")]
        public int multipost([FromHeader] int num1, [FromHeader] int num2)
        {
            return num1 * num2;
        }
        [HttpGet]
        [Route("div")]
        public float divget(float num1, float num2)
        {
            return num1 / num2;
        }
        [HttpPost]
        [Route("div")]
        public float divpost([FromHeader] float num1, [FromHeader] float num2)
        {
            return num1 / num2;
        }
    }
}
