using EmployeesCh12.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeCh12Main.Models
{
    public class DepartmentLocation
    {
        //Composite primary key and foreign key for department
        public int DepartmentID { get; set; }
        //composite Primary key and foreign key for Location
        public int LocationID { get; set; }

        //navigation properties
        public Department Department { get; set; }
        public Location Location { get; set; }
    }
    }

