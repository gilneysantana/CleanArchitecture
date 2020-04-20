using CleanArchitecture.Core.Entities;
using CleanArchitecture.Web;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CleanArchitecture.FunctionalTests.Api
{
    public class ApiUsersControllerList : IClassFixture<CustomWebApplicationFactory<Startup>>
    {
        private readonly HttpClient _client;

        public ApiUsersControllerList(CustomWebApplicationFactory<Startup> factory)
        {
            _client = factory.CreateClient();
        }

        [Fact]
        public async Task Returns3User()
        {
            var response = await _client.GetAsync("/api/user");
            response.EnsureSuccessStatusCode();
            var stringResponse = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<IEnumerable<User>>(stringResponse).ToList();

            Assert.Equal(3, result.Count());
            Assert.Contains(result, i => i.Name == SeedData.user1.Name);
            Assert.Contains(result, i => i.Name == SeedData.user2.Name);
            Assert.Contains(result, i => i.Name == SeedData.user3.Name);
        }

        [Fact]
        public async Task ReturnsUserId1()
        {
            var response = await _client.GetAsync("/api/user/1");
            response.EnsureSuccessStatusCode();
            var stringResponse = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<User>(stringResponse);

            Assert.Equal(result.Name, SeedData.user1.Name);
        }

        //[Fact]
        //public async Task AddUser()
        //{
        //    var response = await _client.PostAsync("/api/user");
        //    response.EnsureSuccessStatusCode();
        //    var stringResponse = await response.Content.ReadAsStringAsync();
        //    var result = JsonConvert.DeserializeObject<User>(stringResponse);

        //    Assert.Equal(result.Name, SeedData.user1.Name);
        //}

        [Fact]
        public async Task AddUser()
        {
            //var client = await _factory.GetAuthenticatedClientAsync();

            dynamic command = new 
            {
                Name = "ABCDE",
                Email = "abcde@gmail.com"
            };

            //var content = Utilities.GetRequestContent(command);
            var content = new StringContent(JsonConvert.SerializeObject(command), 
                Encoding.UTF8, "application/json");


            var response = await _client.PostAsync("/api/user", content);

            response.EnsureSuccessStatusCode();
        }

    }
}
