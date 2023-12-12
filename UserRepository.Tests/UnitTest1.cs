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
                        Name = "�����"
                    },
                    new User()
                    {
                        Name = "����"
                    },
                    new User()
                    {
                        Name = "�������"
                    },
                };

                mockIUserRepository.Setup( v => v.FindAll()).Returns(list);

                Assert.That(mockIUserRepository.Object.FindAll().Any(user => user.Name == "�����"));
                Assert.That(mockIUserRepository.Object.FindAll().Any(user => user.Name == "����"));
                Assert.That(mockIUserRepository.Object.FindAll().Any(user => user.Name == "�������"));
            }
        }
    }
}