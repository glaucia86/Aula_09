using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DAL.Model
{
    [Table("Endereco")]
    public class Endereco
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("IdEndereco")]
        public int IdEndereco { get; set; }

        [Column("Logradouro")]
        public string Logradouro { get; set; }

        [Column("Cidade")]
        public string Cidade { get; set; }

        [Column("Estado")]
        public string Estado { get; set; }

        [Column("Tipo")]
        public string Tipo { get; set; }

        [Column("IdPessoa")]
        public int IdPessoa { get; set; }

        //Endereco associa com Pessoa -->> Endereço tem 1 Pessoa:
        [ForeignKey("IdPessoa")]
        public virtual Pessoa Pessoa { get; set; }
    }
}
