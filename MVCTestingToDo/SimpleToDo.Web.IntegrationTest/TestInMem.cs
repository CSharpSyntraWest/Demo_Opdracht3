using Microsoft.Extensions.DependencyInjection;
using MVCTestingToDo;
using SimpleToDo.Model.Entities;
using SimpleToDo.Web.IntegrationTest.Factory;
using SimpleToDo.Web.IntegrationTest.Fixture;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using Xunit;

namespace SimpleToDo.Web.IntegrationTest
{
    public class TestInMem : IClassFixture<InMemDbWebApplicationFactory<Startup>>
    {
        private readonly HttpClient _client;
        private readonly InMemDbWebApplicationFactory<Startup> _factory;
        //private readonly ToDoDbContext _dbContext;
        private readonly ServiceProvider _serviceProvider;
        public TestInMem(InMemDbWebApplicationFactory<Startup> factory)
        {
            _serviceProvider = factory.ServiceProvider;
            _factory = factory;
            //_dbContext = (ToDoDbContext)factory.Services.GetService(typeof(ToDoDbContext));
            _client = factory.CreateClient();
        }




        [Fact]
        public async System.Threading.Tasks.Task Index_GetAsyncCall_ReturnNewToDoListToView()
        {
            var toDoList = ToDoListFactory.Create().Single();
            using (var scope = _serviceProvider.CreateScope())
            {
                ToDoDbContext context = scope.ServiceProvider.GetRequiredService<ToDoDbContext>();
                //var book1 = new Book { Name = "Book1" };
                //var book2 = new Book { Name = "Book2" };
                //context.Books.AddRange(book1, book2);
                //context.SaveChanges();
          
                //Arrange

                await context.ToDoList.AddAsync(toDoList);
                await context.SaveChangesAsync();
            }
            //Act
            var response = await _client.GetAsync("/");

            //Assert 
            response
                .Content
                .ReadAsStringAsync()
                .Result
                // .Should()
                .Contains(toDoList.Name);
        }



        //    [Fact]
        //public async void TestPutBook()
        //    {
        //            using (var scope = _serviceProvider.CreateScope())
        //            {
        //                var context = scope.ServiceProvider.GetRequiredService<TestDbContext>();
        //                var book1 = new Book { Name = "Book1" };
        //                var book2 = new Book { Name = "Book2" };
        //                context.Books.AddRange(book1, book2);
        //                context.SaveChanges();

        //    book1 = context.Books.Find(book1.Id);
        //                context.Entry(book1).Reload(); // refresh to make sure we can get the newest book1 
        //                Assert.NotNull(book1);
        //                Assert.Equal("Book1Update", book1.Name);
        //            }
        //    using (var scope = _serviceProvider.CreateScope())
        //using (var context = scope.ServiceProvider.GetRequiredService<TestDbContext>())
        //{
        //    var book1 = new Book { Name = "Book1" };
        //    var book2 = new Book { Name = "Book2" };
        //    context.Books.AddRange(book1, book2);
        //    context.SaveChanges();

        //    var updateResp = await _httpClient.PutAsJsonAsync($"/api/books/{book1.Id}", "Book1Update");
        //    updateResp.EnsureSuccessStatusCode();

        //    var getResp = await _httpClient.GetAsync($"/api/books/{book1.Id}");
        //    getResp.EnsureSuccessStatusCode();
        //    var stringResponse = await getResp.Content.ReadAsStringAsync();
        //    book1 = JsonConvert.DeserializeObject<Book>(stringResponse);
        //    Assert.NotNull(book1);
        //    //this works
        //    Assert.Equal("Book1Update", book1.Name);

        //    book1 = context.Books.Find(book1.Id);
        //    Assert.NotNull(book1);
        //    //this fails book1.Name is still equal to "Book1"
        //    Assert.Equal("Book1Update", book1.Name);
        //}
    }
}

