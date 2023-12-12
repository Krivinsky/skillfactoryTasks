using Moq;

namespace UserRepository.Tests
{
    public class Tests
    {
        [TestFixture]
        public class UserRepositoryTest
        {
            [Test]
            public void FindAll_MustReturnNull()
            {
                var mockIUserRepository = new Mock < IUserRepository > ();

                var list = new List<User> {
                    new User()
                    {
                        Name = "Антон"
                    },
                    new User()
                    {
                        Name = "Иван"
                    },
                    new User()
                    {
                        Name = "Алексей"
                    },
                };

                mockIUserRepository.Setup( v => v.FindAll()).Returns(list);

                Assert.That(mockIUserRepository.Object.FindAll().Any(user => user.Name == "Антон"));
                Assert.That(mockIUserRepository.Object.FindAll().Any(user => user.Name == "Иван"));
                Assert.That(mockIUserRepository.Object.FindAll().Any(user => user.Name == "Алексей"));
            }
        }
    }
}