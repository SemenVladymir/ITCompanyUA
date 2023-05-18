using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITCompanyUA
{
    public class ITCompanies
    {
        public string Name { get; set; }
        public int Employees { get; set; }
        public string Cities { get; set; }
        public string Lider { get; set; }

        public ITCompanies()
        {
            Name = string.Empty;
            Employees = 0;
            Cities = string.Empty;
            Lider = string.Empty;
        }

        public ITCompanies(string name, int employees, string cities, string lider)
        {
            Name = name;
            Employees = employees;
            Cities = cities;
            Lider = lider;
        }
    }

}
