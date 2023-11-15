using Web_Tuturu_1.Models;

namespace Web_Tuturu_1.Data
{
    public class MyDataContext
    {
        public List<User> Users { get; set; }
        public MyDataContext() 
        {
            Users = new List<User>();
        }
    }
}
