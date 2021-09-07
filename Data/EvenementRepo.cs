using EvenementApi.Data;
using EvenementApi.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EvenementApi.Controllers
{
    public class EvenementRepo
    {
        private EvenementApiContext db;

        //ctor double click on back slash


        public EvenementRepo(EvenementApiContext db)
        {

            this.db = db;


        }

        public async Task <IEnumerable<EvenementDay>> GetAllAsync(bool includLectures)
        {
            //om vi ska ta includlectures, det tar vi då location,
            //ctr + . --> Include
            return includLectures ? await db.EvenementDays
                                    .Include(e => e.Location)
                                    .Include(e => e.Lectures)
                                    .ThenInclude(e => e.Speaker)
                                    .ToListAsync() :
                                    await db.EvenementDays
                                    .Include(e => e.Location)
                                    .ToListAsync();
        }
    }
}