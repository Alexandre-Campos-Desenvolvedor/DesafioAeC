using DesafioAeC.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioAeC.Services
{
    public interface IAluraServices
    {
        Task<bool> Save(Courses courses);
        void NavigateDomainAlura()  ;
    }
}
