using CleanArc.Domain.Interfaces;
using CleanArc.Domain.Model;
using CleanArch.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Infra.Data.Repository
{
    public class CouresRepository : ICourseRepository
    {
        private readonly UniversityDbContext _cts;
        public CouresRepository(UniversityDbContext cts)
        {
            _cts = cts;   
        }
        public IEnumerable<Course> GetCourses()
        {
            return _cts.Courses;
        }
    }
}
