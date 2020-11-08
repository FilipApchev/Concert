using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication.Controllers
{
    
    [ApiController]
    public class UpdateConcerts : ControllerBase
    {
 
        [Route("api/[controller]")]
        public void Post([FromBody] TicketsJson json)
        {
            DataHelper.UpdateConcerts(json.concertId, json.seats);

        }
        
        /*
        [Route("api/[controller]/post2")]
        public string Post([FromBody] string json)
        {
            return json;
        }
        */

    }

}
