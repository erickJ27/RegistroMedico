using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Consulta.Entidades
{
    public class AnalisisDetalle
    {
        [Key]
        public int Id { get; set; }
        public int AnalisisId { get; set; }

        public int TipoId { get; set; }

        public string Resultado { get; set; }

        public AnalisisDetalle()
        {
            Id = 0;
            AnalisisId = 0;
            TipoId = 0;
            Resultado = string.Empty;
        }

        public AnalisisDetalle(int Id, int AnalisisId,int TipoId, string Resultado)
        {
            this.Id = Id;
            this.AnalisisId = AnalisisId;
            this.TipoId = TipoId;
            this.Resultado = Resultado;
        }
    }
}
