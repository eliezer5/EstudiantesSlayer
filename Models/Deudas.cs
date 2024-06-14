using System.ComponentModel.DataAnnotations;

namespace facEstudiante.Models
{
    public class Deudas
    {
        [Key]
        int DeudaID { get; set; }

        string Cuota {  get; set; } = string.Empty;

        string Estado {  get; set; } = string.Empty;
    }
}
