namespace UserRepository
{
    public class UserRepository : IUserRepository
    {
        public IEnumerable<User> FindAll()
        {
            return null;
        }

        static void Main(string[] args)
        {

        }
    }

    public interface IUserRepository
    {
        IEnumerable<User> FindAll();
    }

    public class User
    {
        public string Name
        {
            get;
            set;
        }
    }
}