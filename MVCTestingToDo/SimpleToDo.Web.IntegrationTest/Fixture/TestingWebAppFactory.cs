using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MVCTestingToDo;
using SimpleToDo.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleToDo.Web.IntegrationTest.Fixture
{
    public class TestingWebAppFactory<T> : WebApplicationFactory<Startup>
    {
       // private static ToDoDbContext _dbContext= CreateDatabase();
        public TestingWebAppFactory()
        {
            Configuration = GetConfiguration();
           // DbContext = CreateDatabase();
        }
        private static  IConfiguration GetConfiguration()
    => new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();

        //private static ToDoDbContext CreateDatabase()
        //{
        //    var options = new DbContextOptionsBuilder<ToDoDbContext>()
        //        .UseSqlServer(Configuration["DbConnection"])
        //        .EnableSensitiveDataLogging()
        //        .UseInMemoryDatabase(databaseName: "SimpleToDoList")
        //        .Options;

        //    return new ToDoDbContext(options);//.Database.Migrate();
        //}

        protected static IConfiguration Configuration { get; private set; }
        public  ToDoDbContext DbContext { get ; private set; }
        protected override void ConfigureWebHost(IWebHostBuilder builder)
        {

            builder.ConfigureServices(services =>
            {
                var descriptor = services.SingleOrDefault(
                  d => d.ServiceType ==
                     typeof(DbContextOptions<ToDoDbContext>));
                if (descriptor != null)
                {
                    services.Remove(descriptor);
                }
                var serviceProvider = new ServiceCollection()
                  .AddEntityFrameworkInMemoryDatabase()
                  .BuildServiceProvider();
                services.AddDbContext<ToDoDbContext>(options =>
                {
                options.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=SimpleToDo;Trusted_Connection=True;MultipleActiveResultSets=true");// Configuration["DbConnection"]);
                   // options.UseInMemoryDatabase("SimpleToDoList");
                   // options.UseInternalServiceProvider(serviceProvider);
                });
                var sp = services.BuildServiceProvider();
                using (var scope = sp.CreateScope())
                {
                    using (var appContext = scope.ServiceProvider.GetRequiredService<ToDoDbContext>())
                    {
                        try
                        {
                            appContext.Database.EnsureCreated();
                            
                            DbContext = appContext;
                        }
                        catch (Exception ex)
                        {
                            //Log errors or do anything you think it's needed
                            throw;
                        }
                    }
                }
            });
        }
    }

}
