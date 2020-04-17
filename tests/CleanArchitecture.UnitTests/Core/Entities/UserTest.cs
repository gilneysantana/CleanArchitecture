using CleanArchitecture.Core.Entities;
using CleanArchitecture.Core.Events;
using System.Linq;
using Xunit;

namespace CleanArchitecture.UnitTests.Core.Entities
{
    public class UserTest 
    {
        [Fact]
        public void SetsIsDoneToTrue()
        {
            var item = new UserBuilder()
                .WithDefaultValues()
                .Build();

            item.AddMeal(100, new System.DateTime(2020,1,1));

            Assert.True(item.Meals.Any());
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
