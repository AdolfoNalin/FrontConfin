using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;

namespace FrontConfin.Model
{
    public class Persona
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string NumberPhone { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public decimal Wage { get; set; }
        public string Gender { get; set; }
        public City City { get; set; }
    }
}
