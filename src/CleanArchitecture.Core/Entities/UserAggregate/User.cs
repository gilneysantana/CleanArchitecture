using CleanArchitecture.Core.Events;
using CleanArchitecture.SharedKernel;
using System.Collections.Generic;
using System;

namespace CleanArchitecture.Core.Entities.UserAggregate
{
    public class User : BaseEntity
    {
        public string Nome { get; set; } 
        public Email Email { get; set; }
        public Credentials Credentials { get; private set; }
        public IList<Meal> Meals { get; set; }

        public void AddMeal(int calories, DateTime dateTime)
        {
            //pode repetir data/hora?

            Meals.Add(new Meal());
        }

        public void ChangePassword(string currentPassword, string newPassword)
        {
            this.Credentials = this.Credentials.ChangePassword(currentPassword, newPassword);

            //Evento para notificar usuário?
        }
    }
}
