using EvenementApi.Models.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EvenementApi.Models.DTO
{
    public class EvenementDayDTO
    {

        //kom i håg att lada ned nugetpacket, entityframework, sql

        //public int Id { get; set; } vill inte exponera primäre nyckel

        [Required]
        [StringLength(10)]
        public string Name { get; set; } //mycket enklare att använda detta i stelet for ID or GUI (sår att komma i håg
        public DateTime EvenementDate { get; set; }
        public int MyProperty { get; set; }
        public int Length { get; set; }

     
        public ICollection<Lecture> Lectures { get; set; }

        //konventioner att autommaper kunna flatta ut dem objekter automatisk???
        //Klass name first och sen properties     
        public string LocationAddress { get; set; } //varje location can holda en specifik address
        public string LocationCityTown { get; set; }
        public string LocationStateProvince { get; set; }
        public string LocationPostalCode { get; set; }
        public string LocationCountry { get; set; }



    }
}
