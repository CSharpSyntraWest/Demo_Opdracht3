using FluentAssertions;
using Microsoft.EntityFrameworkCore;
using MVCTestingToDo;
using SimpleToDo.Model.Entities;
using SimpleToDo.Web.IntegrationTest.Factory;
using SimpleToDo.Web.IntegrationTest.Fixture;
using SimpleToDo.Web.IntegrationTest.Helper;
using SimpleToDo.Web.IntegrationTest.Stub;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace SimpleToDo.Web.IntegrationTest
{
    public class ToDoListControllerTests : IClassFixture<TestingWebAppFactory<Startup>>
    {
        private readonly HttpClient _client;
        private readonly TestingWebAppFactory<Startup> _factory;
        //private readonly ToDoDbContext _dbContext;
        public ToDoListControllerTests(TestingWebAppFactory<Startup> factory)
        {
            _factory = factory;
            //_dbContext = (ToDoDbContext)factory.Services.GetService(typeof(ToDoDbContext));
            _client = factory.CreateClient();
        }
        //: IClassFixture<WebFixture<StartupStub>>
        //{
        //    private readonly WebFixture<StartupStub> _fixture;

        //    public ToDoListControllerTests(WebFixture<StartupStub> fixture)
        //    {
        //        _fixture = fixture;
        //    }

          [Fact]
        public async System.Threading.Tasks.Task Index_GetAsyncCall_ResponseReturnsSuccessStatusCode()
        {
            //Act
            var response = await _client.GetAsync("/");

            //Assert
            response.EnsureSuccessStatusCode();
        }

        [Fact]
        public async System.Threading.Tasks.Task Index_GetAsyncCall_ReturnNewToDoListToView()
        {
            //Arrange
            var toDoList = ToDoListFactory.Create().Single();
            await _factory.DbContext.ToDoList.AddAsync(toDoList);
            await _factory.DbContext.SaveChangesAsync();

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

        [Fact]
        public async System.Threading.Tasks.Task Create_GetAsyncCall_RetunOkStatusCode()
        {
            //Arrange            

            //Act
            var response = await _client.GetAsync("/ToDoList/Create");

            //Assert 
            response
                .StatusCode
                .Should()
                .Be(HttpStatusCode.OK);
        }

        [Fact]
        public async System.Threading.Tasks.Task Create_PostAsyncCallWithValidToDoList_RedirectToIndexAction_Error()
        {
            //Arrange            
            var formData = new Dictionary<string, string>
            {
                { nameof(ToDoList.Name), "To Do List 1" }
            };

            //Act
            var response = await _client.PostAsync(
                "/ToDoList/Create",
                new FormUrlEncodedContent(formData));

            //Assert                        
            response.Headers.Location.ToString().Should().Be("/");
        }

        [Fact]
        public async System.Threading.Tasks.Task Create_PostAsyncCallWithValidToDoList_RedirectToIndexAction()
        {
            //Arrange            
            var formData = new Dictionary<string, string>
            {
                {
                    "__RequestVerificationToken",
                    await AntiForgeryHelper.EnsureAntiForgeryTokenAsync(_client)
                },
                { nameof(ToDoList.Name), "To Do List 1" }
            };

            //Act
            var response = await _client.PostAsync(
                "/ToDoList/Create",
                new FormUrlEncodedContent(formData));

            //Assert            
            response.Headers.Location.ToString().Should().Be("/");
        }

        //[Fact]
        //public async System.Threading.Tasks.Task Edit_GetAsyncCallWithNewToDoListId_ReturnToDoListToView()
        //{
        //    //Arrange
        //    var toDoList = ToDoListFactory.Create().Single();
        //    await _fixture.DbContext.ToDoList.AddAsync(toDoList);
        //    await _fixture.DbContext.SaveChangesAsync();

        //    //Act
        //    var response = await _fixture.Client.GetAsync($"/ToDoList/Edit/{toDoList.Id}");

        //    //Assert            
        //    response
        //        .Content
        //        .ReadAsStringAsync()
        //        .Result
        //        //.Should()
        //        .Contains(toDoList.Id.ToString());
        //}

        [Fact]
        public async System.Threading.Tasks.Task Edit_GetAsyncCallWithNullId_ReturnNotFoundStatusCode()
        {
            //Act
            var response = await _client.GetAsync("/ToDoList/Edit/");

            //Assert        
            response.StatusCode.Should().Be(HttpStatusCode.NotFound);
        }

        //[Fact]
        //public async System.Threading.Tasks.Task Edit_PostAsyncCallWithValidIdAndToDoList_RedirectToIndexView()
        //{
        //    //Arrange
        //    var toDoList = ToDoListFactory.Create().Single();
        //    await _fixture.DbContext.ToDoList.AddAsync(toDoList);
        //    await _fixture.DbContext.SaveChangesAsync();

        //    var formData = new Dictionary<string, string>
        //    {
        //        {
        //            "__RequestVerificationToken",
        //            await AntiForgeryHelper.EnsureAntiForgeryTokenAsync(_fixture.Client)
        //        },
        //        { "id", toDoList.Id.ToString() },
        //        { "Id", toDoList.Id.ToString() },
        //        { "Name", "ToDoList Test 1" }
        //    };

        //    //Act
        //    var response = await _fixture.Client
        //        .PostAsync(
        //            "/ToDoList/Edit/",
        //            new FormUrlEncodedContent(formData));

        //    //Assert                     
        //    response.Headers.Location.ToString().Should().Be("/");
        //}

        //[Fact]
        //public async System.Threading.Tasks.Task Edit_PostAsyncCallWithModelStateInvalid_ShowErrorMessageOnEditView()
        //{
        //    //Arrange
        //    var toDoList = ToDoListFactory.Create().Single();
        //    await _fixture.DbContext.ToDoList.AddAsync(toDoList);
        //    await _fixture.DbContext.SaveChangesAsync();

        //    var formData = new Dictionary<string, string>
        //    {
        //        {
        //            "__RequestVerificationToken",
        //            await AntiForgeryHelper.EnsureAntiForgeryTokenAsync(_fixture.Client)
        //        },
        //        { "id", toDoList.Id.ToString() },
        //        { "Id", toDoList.Id.ToString() }
        //    };

        //    //Act
        //    var response = await _fixture.Client
        //        .PostAsync(
        //            "/ToDoList/Edit/",
        //            new FormUrlEncodedContent(formData));

        //    //Assert                  
        //    response
        //        .Content
        //        .ReadAsStringAsync()
        //        .Result
        //        .Should()
        //        .Contain("The Name field is required.");
        //}

        //[Fact]
        //public async System.Threading.Tasks.Task Edit_PostAsyncCallWithConcurrency_ThrowDbConcurrencyException()
        //{
        //    //Arrange
        //    var toDoList = ToDoListFactory.Create().Single();
        //    await _fixture.DbContext.ToDoList.AddAsync(toDoList);
        //    await _fixture.DbContext.SaveChangesAsync();

        //    var toDoListDb = await _fixture.DbContext.ToDoList.FirstOrDefaultAsync(x => x.Id == toDoList.Id);
        //    toDoListDb.Name = "Concurrency";

        //    var formData = new Dictionary<string, string>
        //    {
        //        {
        //            "__RequestVerificationToken",
        //            await AntiForgeryHelper.EnsureAntiForgeryTokenAsync(_fixture.Client)
        //        },
        //        { "id", toDoList.Id.ToString() },
        //        { "Id", toDoList.Id.ToString() },
        //        { "Name", "ToDoList Test 1" }
        //    };

        //    //Act
        //    Func<Task<HttpResponseMessage>> action = () => _fixture.Client
        //        .PostAsync(
        //            "/ToDoList/Edit/",
        //            new FormUrlEncodedContent(formData));

        //    //Assert        
        //    action
        //        .Should()
        //        .Throw<DbUpdateConcurrencyException>();
        //}

        //[Fact]
        //public async System.Threading.Tasks.Task DeleteConfirmed_PostAsyncCallWithValidIdAndToDoList_RedirectToIndexView()
        //{
        //    //Arrange
        //    var toDoList = ToDoListFactory.Create().Single();
        //    await _fixture.DbContext.ToDoList.AddAsync(toDoList);
        //    await _fixture.DbContext.SaveChangesAsync();

        //    var formData = new Dictionary<string, string>
        //    {
        //        {
        //            "__RequestVerificationToken",
        //            await AntiForgeryHelper.EnsureAntiForgeryTokenAsync(_fixture.Client)
        //        },
        //        { "id", toDoList.Id.ToString() }
        //    };

        //    //Act
        //    var response = await _fixture.Client
        //        .PostAsync(
        //            $"/ToDoList/Delete/",
        //            new FormUrlEncodedContent(formData));

        //    //Assert            
        //    response.Headers.Location.ToString().Should().Be("/");
        //}
    }
}
