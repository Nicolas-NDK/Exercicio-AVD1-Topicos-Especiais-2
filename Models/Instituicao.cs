using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Apoio.Models
{
    public class Instituicao
    {
        public long Id { get; set; }
        [Required]
        [StringLength(100)]
        
        public string? Name { get; set; }
        [DisplayName("Endereço")]

        public string? Endereco { get; set; }
    };
    
}
