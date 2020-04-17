using CleanArchitecture.Core.Entities;
using CleanArchitecture.Core.Events;
using System.Linq;
using System;
using Xunit;

namespace CleanArchitecture.UnitTests.Core.Entities
{
    public class UserTest 
    {
        [Fact]
        public void SetsIsDoneToTrue()
        {
            var user = new UserBuilder()
                .WithDefaultValues()
                .Build();

            user.AddMeal(100, new DateTime(2020,1,1));

            Assert.Equal(1, user.Meals.Count);
        }

        [Fact]
        public void ChangeCredentials()
        {
            string newPassword = "newPassword";

            var user = new UserBuilder()
                .WithDefaultValues()
                .Credentials("login", "password")
                .Build();

            user.ChangePassword("password", newPassword);

            Assert.Equal(Credentials.EncriptPassword(newPassword), user.Credentials.Password);

        }

        //[Fact]
        //public void RaisesToDoItemCompletedEvent()
        //{
        //    var item = new ToDoItemBuilder().Build();

        //    item.MarkComplete();

        //    Assert.Single(item.Events);
        //    Assert.IsType<ToDoItemCompletedEvent>(item.Events.First());
        //}
    }
}
