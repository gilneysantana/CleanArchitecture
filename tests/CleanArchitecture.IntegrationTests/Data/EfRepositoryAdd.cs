using CleanArchitecture.Core.Entities;
using CleanArchitecture.UnitTests;
using System.Linq;
using Xunit;

namespace CleanArchitecture.IntegrationTests.Data
{
    public class EfRepositoryAdd : BaseEfRepoTestFixture
    {
        [Fact]
        public void AddsItemAndSetsId()
        {
            var repository = GetRepository();
            var item = new ToDoItemBuilder().Build();

            repository.Add(item);

            var newItem = repository.List<ToDoItem>().FirstOrDefault();

            Assert.Equal(item, newItem);
            Assert.True(newItem?.Id > 0);
        }

        [Fact]
        public void AddsUserAndSetsId()
        {
            var repository = GetRepository();
            var user = new UserBuilder()
                .WithDefaultValues()
                .Email("teste@gmail.com")
                .Credentials("gilney", "123456")
                .Build();

            repository.Add(user);

            var newUser = repository.List<User>().FirstOrDefault();

            Assert.Equal(user, newUser);
            Assert.Equal(user.Email.Address, newUser.Email.Address);
            Assert.Equal(user.Credentials.Username, newUser.Credentials.Username);
            Assert.True(newUser?.Id > 0);
        }
    }
}
