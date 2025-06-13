using HelloMVC.Models;

namespace HelloMVC.Services
{
    public class UserService
    {
        private List<User> _users;
        private int _nextId = 1;

        public UserService()
        {
            _users = new List<User>
            {
                new User { Id = GetCurrentNextId(), Login = "user1", Password = "pass1" },
                new User { Id = GetCurrentNextId(), Login = "user2", Password = "pass2" }
            };
        }

        private int GetCurrentNextId() => _nextId++;

        public List<User> GetAll() => _users;

        public User GetById(int id) => _users.FirstOrDefault(u => u.Id == id);

        public User Add(User user)
        {
            user.Id = GetCurrentNextId();
            _users.Add(user);

            return user;
        }

        public bool Update(User user)
        {
            var found_user = GetById(user.Id);

            if (found_user == null)
                return false;

            found_user.Login = user.Login;
            found_user.Password = user.Password;

            return true;
        }

        public bool DeleteById(int id)
        {
            var found_user = GetById(id);

            if (found_user == null)
                return false;

            _users.Remove(found_user);
            return true;
        }
    }
}
