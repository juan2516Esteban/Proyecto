using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Proyecto_Final.Model
{
    public class SubirEventModel
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [MaxLength (50)]
        public string NombreEvent { get; set; }

        [MaxLength (30)]
        public string MunicipioEvent { get; set; }

        [MaxLength (70)]
        public string UbicaciónEvent { get; set; }

        [MaxLength (22)]
        public string DeporteEvent { get; set; }

        [MaxLength (5)]

        public int NumeroParticiEvent { get; set; }

        [MaxLength(10)]

        public string ValorPolizaEvent { get; set; }

        [MaxLength (10)]

        public string ValorGananciaEvent { get; set;}

        [MaxLength (10)]

        public string ValorAdicionales { get; set; }

        [MaxLength (10)]
        public int ValorYTotalEvent { get; set;}

        [MaxLength (5000)]
        public string Descripción { get; set; }




    }
}
