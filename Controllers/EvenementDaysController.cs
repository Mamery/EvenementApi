using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EvenementApi.Data;
using EvenementApi.Models.Entities;
using AutoMapper;

namespace EvenementApi.Controllers
{
    [Route("api/events")]
    [ApiController]
    public class EvenementDaysController : ControllerBase
    {
        private readonly IMapper mapper;
        private readonly EvenementApiContext _context;
        private EvenementRepo evenementRepo;
        public EvenementDaysController(EvenementApiContext context, IMapper mapper)
        {
            evenementRepo = new EvenementRepo(context);
            this.mapper = mapper;
        }

        // GET: api/EvenementDays
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EvenementDay>>> GetAllEvents(bool includLectures=false)
        {
            //när jag pluggar ut evenementday, är jag också interesserad att få lectures med
            //därför skcikar med flaggar i kontollern (bool includLectures)
            ////autommaper er en transport sträkk
            //var result = await evenementRepo.GetAllAsync(includLectures);
            var dto = mapper.Map<EvenementDay>(await evenementRepo.GetAllAsync(includLectures));
            return Ok(dto);          
        }


       
    }

}
