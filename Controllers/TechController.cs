using ApiDynamonDb.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiDynamonDb.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TechController : ControllerBase
    {
  
        [HttpGet]
        public IActionResult GetSales()
        {
            throw new NotImplementedException();
        }

        [HttpGet("{id}")]
        public IActionResult GetSaleById(int id)
        {
            throw new NotImplementedException();
        }

        [HttpPost] 
        public IActionResult AddSale([FromBody] TechVenda sale)
        {
            throw new NotImplementedException();
        }

        [HttpPut("{id}")]
        public IActionResult Attsale(int id)
        {
            throw new NotImplementedException();
        }

        [HttpDelete("{id}")]
        public IActionResult DelSale(int id)
        {
            throw new NotImplementedException();
        }

    }
}
