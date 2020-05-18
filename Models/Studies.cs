using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace APBD09.Models
{
    public class Studies
    {
        private int idStudy;

        public int GetIdStudy()
        {
            return idStudy;
        }

        public void SetIdStudy(int value)
        {
            idStudy = value;
        }

        private string name;

        public string GetName()
        {
            return name;
        }

        public void SetName(string value)
        {
            name = value;
        }
    }
}
