using CadastroDeCliente.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroDeCliente.Contextos
{
    //Classe responsável por criar a tabela de dados baseado na Classe passada que neste caso é a de Contato e alimentá-la
    public class AgendaContexto : DbContext
    {
        public AgendaContexto() : base(nameOrConnectionString: "agenda")
        {
            Database.SetInitializer<AgendaContexto>(new AgendaContextoInitializer());
        }
        public DbSet<Contato> Client { get; set; }
    }


    public class AgendaContextoInitializer : DropCreateDatabaseIfModelChanges<AgendaContexto>
    {

    }
}
