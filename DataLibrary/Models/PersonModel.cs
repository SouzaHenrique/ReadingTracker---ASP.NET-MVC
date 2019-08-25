using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Models
{
    public class PersonModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDayDate { get; set; }
        public string EmailAddress { get; set; }
        public string Password { get; set; }
        public Guid Api_ID { get; set; }
        public bool isActive { get; set; }

    }
}
