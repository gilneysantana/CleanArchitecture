using CleanArchitecture.Core.Events;
using CleanArchitecture.SharedKernel;
using System;

namespace CleanArchitecture.Core.Entities.UserAggregate
{
    public class Meal : BaseEntity
    {
        public int MealId { get; set; }
        public DateTime Date { get; set; } 
        public decimal Calories { get; set; }
        public string Description { get; set; }
        public User User { get; set; }
    }
}
