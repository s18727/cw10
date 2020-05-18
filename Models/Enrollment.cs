using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace APBD09.Models
{
    public class Enrollment
    {
        private int idEnrollment;

        public int GetIdEnrollment()
        {
            return idEnrollment;
        }

        public void SetIdEnrollment(int value)
        {
            idEnrollment = value;
        }

        private int semester;

        public int GetSemester()
        {
            return semester;
        }

        public void SetSemester(int value)
        {
            semester = value;
        }

        private int idStudy;

        public int GetIdStudy()
        {
            return idStudy;
        }

        public void SetIdStudy(int value)
        {
            idStudy = value;
        }

        private DateTime startDate;

        public DateTime GetStartDate()
        {
            return startDate;
        }

        public void SetStartDate(DateTime value)
        {
            startDate = value;
        }
    }
}
