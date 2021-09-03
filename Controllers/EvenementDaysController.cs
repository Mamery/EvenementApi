using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EvenementApi.Data;
using EvenementApi.Models.Entities;

namespace EvenementApi.Controllers
{
    [Route("api/events")]
    [ApiController]
    public class EvenementDaysController : ControllerBase
    {
        private readonly EvenementApiContext _context;

        public EvenementDaysController(EvenementApiContext context)
        {
            _context = context;
        }

        // GET: api/EvenementDays
        /*[HttpGet]
        public async Task<ActionResult<IEnumerable<EvenementDay>>> GetEvenementDay()
        {
            return await _context.EvenementDay.ToListAsync();
        }*/


       
    }
}
