using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume.Models
{
    class PersonalDetails
    {
        public class Personal
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string FullName { get; set; }
            public string Address { get; set; }
            public string CpNumber { get; set; }
            public string LlNumber { get; set; }
            public string EmailAddress { get; set; }
            public List<string> Skills { get; set; }
            public string Summary { get; set; }
            public List<string> HighSchool { get; set; }
            public List<string> College { get; set; }
            public List<string> JobTitle { get; set; }
            public List<string> CompanyName { get; set; }
            public List<string> YearDuration { get; set; }

        }
    }
}
