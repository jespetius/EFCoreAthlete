using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AthleteEntity.Data.Models
{
    internal class Athlete
    {
        public int Id { get; set; }

        public string FullName { get; set;}
        public string Sport { get; set; }

        public int CoachId { get; set; }
    }
}
