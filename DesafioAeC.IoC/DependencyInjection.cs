using DesafioAeC.Data;
using DesafioAeC.Data.Repository;
using DesafioAeC.Domain.Interfaces;
using DesafioAeC.Domain.Iterfaces;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.DependencyInjection;
using System.Data;

namespace DesafioAeC.IoC
{
    //public static class DependencyInjection
    //{
    //    public static void RegisterServices(this ServiceCollection serviceCollection) {
    //        //Data
    //        serviceCollection.AddScoped<IDbConnection>(s => new SqlConnection("Data Source=localhost\\SQLSERVER;Initial Catalog=LAPTOP-3HN1R186\\alexa;Integrated Security=True;"));


    //        serviceCollection.AddSingleton<IAluraServices, AluraServices>();
    //        serviceCollection.AddSingleton<ICoursesRepository, CoursesRepository>();
    //        //serviceCollection.AddSingleton<IRepositoryBase<>, RepositoryBase<>>();
    //    }
    //}
}