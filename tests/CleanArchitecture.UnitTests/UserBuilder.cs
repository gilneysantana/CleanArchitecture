using CleanArchitecture.Core.Entities.UserAggregate;

namespace CleanArchitecture.UnitTests
{
    // Learn more about test builders:
    // https://ardalis.com/improve-tests-with-the-builder-pattern-for-test-data
    public class UserBuilder
    {
        private User _todo = new User();

        public UserBuilder Id(int id)
        {
            _todo.Id = id;
            return this;
        }

        public UserBuilder Name(string name)
        {
            _todo.Name = name;
            return this;
        }

        public UserBuilder Email(string email)
        {
            _todo.Email = new Email(email);
            return this;
        }

        public UserBuilder WithDefaultValues()
        {
            _todo = new User() { Id = 1, Name = "Name Who", Email = new Email("fulano@mail.com")};

            return this;
        }

        public User Build() => _todo;
    }
}
