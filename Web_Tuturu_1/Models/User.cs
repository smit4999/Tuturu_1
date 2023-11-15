namespace Web_Tuturu_1.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; } //добавить потом шифрование хотя бы по кэш-функции
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }
}
