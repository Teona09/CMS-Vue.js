using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMS_back.Models
{
    public class Employee
    {
        private static int idCount = 0;

        /*public Employee(string fname, string lname, string email, DateTime birthdate, string photoSrc)
        {
            this.Id = idCount;
            idCount++;
            this.FirstName = fname;
            this.LastName = lname;
            this.Email = email;
            this.Birthdate = birthdate;
            this.PhotoSrc = photoSrc;
        }*/

        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }
        public int Gender { get; set; }
        /* 0 - Other
         * 1 - Male
         * 2 - Female
         * 3 - Ninja
         * 4 - Robot
         * 5 - Pirate
         */

        public DateTime Birthdate { get; set; }

        public string PhotoSrc { get; set; }
    }
}
