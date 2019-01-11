using ProjetoDDD.Domain.Entities;
using System.Data.Entity;
using System.Runtime.Remoting.Contexts;

namespace ProjetoModeloDDD1.Infra.Data.Contexto
{
    public class ProjetoModeloContext : DbContext

    {
        public DbSet<Cliente> Clientes { get; set; }
       




        public ProjetoModeloContext() : base("ProjetoModeloDDD")
        {
                
        }
         

        
    }


}


