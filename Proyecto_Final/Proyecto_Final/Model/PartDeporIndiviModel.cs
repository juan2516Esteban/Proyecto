using SQLite;
namespace Proyecto_Final.Model
{
    public class PartDeporIndiviModel
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [MaxLength(50)]
        public string NombrePartic { get; set; }

        [MaxLength(100)]
        public string EmailPartic { get; set; }

        [MaxLength(3)]
        public int EdadPartic { get; set; }

        [MaxLength(10)]
        public string phonePartic { get; set; }

        [MaxLength(20)]

        public int CodigoEvent { get; set; }
    }
}
