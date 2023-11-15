using Web_Tuturu_1.Data;
using Web_Tuturu_1.Models;
using Web_Tuturu_1.Services.Interfaces;

namespace Web_Tuturu_1.Services
{
    public class UsersService : IGetServices
    {
        private MyDataContext _DataContext;

        public UsersService(MyDataContext DataContext)
        {
            _DataContext = DataContext;
        }

        public User Create(User user)
        {
            var lastUser = _DataContext.Users.LastOrDefault();
            int newId =  lastUser is null ? 1 : lastUser.Id + 1;

            user.Id = newId;
            _DataContext.Users.Add(user);
            return user;
        }
        public User Update(User user)
        {
            var userToUpdate = _DataContext.Users.FirstOrDefault(x => x.Id == user.Id);
            userToUpdate.Login = user.Login;
            userToUpdate.Password = user.Password;
            userToUpdate.Email = user.Email;
            userToUpdate.Phone = user.Phone;
            _DataContext.Users.Add(userToUpdate);
            return userToUpdate;
        }

        public User Get(int id)
        {
            var userToGet = _DataContext.Users.FirstOrDefault(x => x.Id <= id);
            return userToGet;
        }

        public List<User> GetAll()
        {
            return _DataContext.Users;
        }
        public void Delete(int id)
        {
            var userToDelete = _DataContext.Users.FirstOrDefault(x => x.Id == id);
            _DataContext.Users.Remove(userToDelete);    
        }
    }
}
