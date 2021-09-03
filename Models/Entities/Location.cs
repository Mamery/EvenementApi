using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EvenementApi.Models.Entities
{
    public class Location
    {

        public int Id { get; set; }
        public string Address { get; set; } //varje location can holda en specifik address
        public string CityTown { get; set; }
        public string StateProvince { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }

        //solution 1
        // public int LectureId { get; set; }
        // public ICollection<Lecture> Lectures { get; set; }
    }
}
