using CleanArchitecture.Core.Events;
using CleanArchitecture.SharedKernel;
using System.Collections.Generic;
using System;
using CleanArchitecture.Core.Exceptions;

namespace CleanArchitecture.Core.Entities
{
    public class User : BaseEntity
    {
        public string Name { get; set; } 
        public Email Email { get; set; }
        public Credentials Credentials { get; set; }

        private readonly List<Meal> _meals = new List<Meal>();
        public IReadOnlyCollection<Meal> Meals => _meals.AsReadOnly();

        public User() { }

        public User(string name, string email)
        {
            Name = name;
            Email = new Email(email);
        }


        public void AddMeal(int calories, DateTime dateTime)
        {
            //pode repetir data/hora?

            _meals.Add(new Meal());
        }

        public void ChangePassword(string currentPassword, string newPassword)
        {
            if (Credentials.Password != Credentials.EncriptPassword(currentPassword))
                throw new AppException("Wrong password");

            this.Credentials = this.Credentials.ChangePassword(currentPassword, newPassword);

            //Evento para notificar usuário?
        }
    }
}
