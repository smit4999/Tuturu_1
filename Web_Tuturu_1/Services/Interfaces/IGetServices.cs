using Web_Tuturu_1.Models;

namespace Web_Tuturu_1.Services.Interfaces
{
    public interface IGetServices
    {
        User Create(User user);
        User Update(User user);
        User Get(int id);
        List<User> GetAll();
        void Delete(int id);
    }
}
