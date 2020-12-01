using Microsoft.AspNetCore.Mvc.Testing;
using System;
using System.Net.Http;
using SytemUnderTest;
using Xunit;

namespace IntegrationTest
{
    public class UnitTest1
    {
        protected readonly HttpClient _client;

        //protected IntegrationTest()
        //{
        //    var appFactory = new WebApplicationFactory<Startup>()
        //        .WithWebHostBuilder(builder =>
        //        {
        //            builder.ConfigureServices(services =>
        //            {
        //                services.RemoveAll(typeof(DataContext));
        //                services.AddDbContext<DataContext>(options => { options.UseInMemoryDatabase("TestDb"); });
        //            });
        //        });

        //    TestClient = appFactory.CreateClient();
        //}

        public UnitTest1()
        {
            var appFactory = new WebApplicationFactory<Startup>();
            _client = appFactory.CreateClient();
        }

        [Fact]
        public void Test1()
        { 
            _client.GetAsync(ApiRoutes.)
        
        }
    }
}
