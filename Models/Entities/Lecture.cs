using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EvenementApi.Models.Entities
{
    public class Lecture
    {
        //varje speaker ska ha en speaker
        public int Id { get; set; }
        public string Title { get; set; }
        public int Level { get; set; }
        //public int LocationId { get; set; }
        //public Location Location { get; set; }
        
        
        //primary nyckel as foreign key
        public int EvenementDayId { get; set; }

        //navigation property
        public EvenementDay EvenementDay { get; set; }
        public int SpeakerId { get; set; }
        public Speaker Speaker { get; set; }


    }
}
