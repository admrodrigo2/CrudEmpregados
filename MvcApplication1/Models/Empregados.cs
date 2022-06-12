using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcApplication1.Models
{
    public class Empregados
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName="nvarchar(250)")]
        [Required(ErrorMessage="Compo obrigatório")]
        public string Nome { get; set; }
        [Column(TypeName = "varchar(250)")]
        [DisplayName("Endereço")]
        public string Endereco { get; set; }
        [Column(TypeName = "varchar(250)")]
        public string Telefone { get; set; }
        [Column(TypeName = "varchar(100)")]
        public string Cargo { get; set; }


    }

}
