using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursosRegistros.Models
{
    public class Estudiante
    {
        
            [Key]
            public int Id { get; set; }

            [Required]
            public  required string Nombres { get; set; } = string.Empty;

            [Required]
            public required string ApellidoPaterno { get; set; } = string.Empty;

            [Required]
            public required string ApellidoMaterno { get; set; } = string.Empty;

            [Required]
            public required long Rut { get; set; } 

            [Required]
            public required int NumeroMatricula { get; set; } 

            [Required]
            public required string Curso { get; set; } = string.Empty;

    }
}
