using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class DBContext
    {
        public students GetStudentDetails()
        {
            students stud = new students();
            stud.id = 1;
            stud.name = "Sachin";
            stud.standard = "MCA";
            stud.city = "Pune";
            return stud;
        }
    }
}