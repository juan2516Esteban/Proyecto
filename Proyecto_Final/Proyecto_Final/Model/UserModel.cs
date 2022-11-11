using SQLite;

namespace Proyecto_Final.Model
{
    public class UserModel
    {
        [PrimaryKey, AutoIncrement]
        public int UserId { get; set; }

        [MaxLength(40)]
        public string Name { get; set; }

        [MaxLength(40)]
        public string LastName { get; set; }

        [MaxLength(100)]
        public string Email { get; set; }

        [MaxLength(20)]
        public string Password { get; set; }

        [MaxLength(3)]
        public int Edadades { get; set; }

        [MaxLength(10)]
        public string phone { get; set; }

    }
}
