using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DAL.Model
{
    [Table("Pessoa")]
    public class Pessoa
    {
        [Key] //Chave Primária
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("IdPessoa")]
        public int IdPessoa { get; set; }

        [Column("Nome")]
        public string Nome { get; set; }

        [Column("Email")]
        public string Email { get; set; }

        [Column("DataCadastro")]
        public DateTime DataCadastro { get; set; }

        //Pessoa se associa com Endereços -->> Pessoa possui 'n' Endereços:
        //virtual para que o EF possa sobrescrever a propriedade (override)
        public virtual List<Endereco> Enderecos { get; set; }
    }
}
