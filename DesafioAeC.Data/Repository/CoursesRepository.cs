using DesafioAeC.Domain.Entities;
using DesafioAeC.Domain.Iterfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioAeC.Data.Repository
{
    public class CoursesRepository : RepositoryBase<Courses>, ICoursesRepository
    {
        public CoursesRepository(IDbConnection dbConnection) : base(dbConnection)
        {
        }
    }
}
