using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APBD09.DTOs
{
    public class EnrollRequest
    {
        private string indexNumber;

        public string GetIndexNumber()
        {
            return indexNumber;
        }

        public void SetIndexNumber(string value)
        {
            indexNumber = value;
        }

        private string firstName;

        public string GetFirstName()
        {
            return firstName;
        }

        public void SetFirstName(string value)
        {
            firstName = value;
        }

        private string lastName;

        public string GetLastName()
        {
            return lastName;
        }

        public void SetLastName(string value)
        {
            lastName = value;
        }

        private DateTime birthDate;

        public DateTime GetBirthDate()
        {
            return birthDate;
        }

        public void SetBirthDate(DateTime value)
        {
            birthDate = value;
        }

        public string Studies { get; set; }
    }
}
