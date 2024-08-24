using CleanArc.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Application.ViewModel
{
    public class CourseViewModel
    {
        public IEnumerable<Course> Courses { get; set; }
    }
}
