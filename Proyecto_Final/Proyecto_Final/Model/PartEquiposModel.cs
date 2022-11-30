using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Proyecto_Final.Model
{
    public class PartEquiposModel
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [MaxLength(50)]
        public string NombrePartic { get; set; }

        [MaxLength(50)]
        public string Nombrepart1 { get; set; }

        [MaxLength(50)]
        public string Nombrepart2 { get; set; }

        [MaxLength(50)]
        public string Nombrepart3 { get; set; }

        [MaxLength(50)]
        public string Nombrepart4 { get; set; }

        [MaxLength(50)]
        public string Nombrepart5 { get; set; }


        [MaxLength(50)]
        public string Nombrepart6 { get; set; }


        [MaxLength(50)]
        public string Nombrepart7 { get; set; }

        [MaxLength(100)]
        public string EmailSudo { get; set; }

        [MaxLength(3)]
        public int EdadSudo { get; set; }

        [MaxLength(10)]
        public string phoneSudo { get; set; }

        [MaxLength(20)]

        public int CodigoEvent { get; set; }
    }

}
