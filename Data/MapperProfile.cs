using AutoMapper;
using EvenementApi.Models.DTO;
using EvenementApi.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EvenementApi.Data
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            //v ligger i DTO vad vi är interreseerad att visa upp
            //vi skappar en ny class i DTO
            // create from xxxxx to yyyyy

            CreateMap<EvenementDay, EvenementDayDTO>().ReverseMap();

        }


    }
}
