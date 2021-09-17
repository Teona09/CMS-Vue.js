using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMS_back.ViewModels
{
    public class EmployeeVM
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public DateTime Birthdate { get; set; }

        public string PhotoSrc { get; set; }
    }
}
