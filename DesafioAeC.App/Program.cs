using DesafioAeC.App;
using DesafioAeC.Data.Repository;
using DesafioAeC.Domain.Iterfaces;
using DesafioAeC.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System.Data;
using System.Data.SqlClient;





var serviceCollection = new ServiceCollection();



//Data
serviceCollection.AddScoped<IDbConnection>(s => new SqlConnection("Data Source=(localdb)\\mssqllocaldb;Initial Catalog=model;Integrated Security=True"));

serviceCollection.AddSingleton<IAluraServices, AluraServices>();

serviceCollection.AddSingleton<ICoursesRepository, CoursesRepository>();



serviceCollection.AddTransient<Initialize>();

var serviceProvider = serviceCollection.BuildServiceProvider();

var aluraServices = serviceProvider.GetService<Initialize>();
Console.WriteLine("Inicializando bot cursos Alura");
aluraServices!.Run();
Console.WriteLine("Bot cursos Alura finalizado");



