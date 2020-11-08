using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConcertsController : ControllerBase
    {
        
        public List<Koncerti> Get()
        {
            //string str = "";
            List<Koncerti> concerts = DataHelper.GetConcerts();  
            return concerts;

        }
    }
}
