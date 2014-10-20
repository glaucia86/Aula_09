using DAL.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DataSource
{
    //Classe 'DbContext' que herda da API do EF:
    public class Conexao : DbContext
    {
        //Passando a connectionstring através da DbContext pelo construtor:
        public Conexao()
            : base(ConfigurationManager.ConnectionStrings["Banco"].ConnectionString)
        {
            //Default
        }

        //Declarando cada classe mapeada na Tabela
        //DbSet é uma classe no EF que que vincula as entidades à Conexão:
        public DbSet<Endereco> Endereco { get; set; }
        public DbSet<Pessoa> Pessoa { get; set; }
    }
}
