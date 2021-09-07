using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EvenementApi.Models.Entities
{
    public class EvenementDay
    {
        //kom i håg att lada ned nugetpacket, entityframework, sql

        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime EvenementDate { get; set; }
        public int MyProperty { get; set; }
        public int Length { get; set; }

        public int LocationId { get; set; }
        //varje event har en location
        public Location Location { get; set; }

        public ICollection<Lecture> Lectures { get; set; }


    }
}
