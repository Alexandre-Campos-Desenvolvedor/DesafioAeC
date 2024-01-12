using System;
using Dapper.Contrib.Extensions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioAeC.Domain.Entities
{
    [Table("Courses")]
    public class Courses
    {

        public int Id { get; set; }
        public string Title { get; set; }
        public string Teacher { get; set; }
        public string WorkLoad { get; set; }
        public string Description { get; set; }

    }

}
