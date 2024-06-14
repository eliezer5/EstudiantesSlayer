using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace facEstudiante.Models
{
    public class Deudas_Detalle
    {
        [Key]
        public int DetalleId { get; set; }

        [ForeignKey("DeudaId")]
        public int DeudaId { get; set; }

        DateTime Fecha { get; set; }

        public string Periodo { get; set; }= string.Empty;

        public int Monto { get; set; }


    }
}
