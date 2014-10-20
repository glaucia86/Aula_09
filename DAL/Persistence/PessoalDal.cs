using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Model;
using DAL.DataSource;

namespace DAL.Persistence
{
    public class PessoalDal
    {
        //Método Insert:
        public void Insert(Pessoa p, Endereco e)
        {
            try
            {
                using (var Con = new Conexao())
                {
                    Con.Pessoa.Add(p);
                    Con.Endereco.Add(e);
                    Con.SaveChanges(); //gravando ....
                }
            }
            catch (Exception ex)
            {
                throw new Exception("\tErro ao inserir dados! " + ex.Message);
            }
        }
    }
}
