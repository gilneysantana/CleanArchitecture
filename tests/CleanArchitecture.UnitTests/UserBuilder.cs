using CleanArchitecture.Core.Entities;

namespace CleanArchitecture.UnitTests
{
    // Learn more about test builders:
    // https://ardalis.com/improve-tests-with-the-builder-pattern-for-test-data
    public class UserBuilder
    {
        private User _user = new User();

        public UserBuilder Id(int id)
        {
            _user.Id = id;
            return this;
        }

        public UserBuilder Name(string name)
        {
            _user.Name = name;
            return this;
        }

        public UserBuilder Email(string email)
        {
            _user.Email = new Email(email);
            return this;
        }

        public UserBuilder Credentials(string login, string password)
        {
            _user.Credentials = new Credentials(login, password);
            return this;
        }

        public UserBuilder WithDefaultValues()
        {
            _user = new User() { Id = 1, Name = "Name Who", Email = new Email("fulano@mail.com")};

            return this;
        }

        public User Build() => _user;
    }
}
