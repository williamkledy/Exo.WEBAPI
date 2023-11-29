using Exo.WebApi.Models;
using Microsoft.EntityFrameworkCore;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace Exo.WebApi.Contexts
{
    public class ExoContext : DbContext
{
    public ExoContext()
        {
        }
public ExoContext(DbContextOptions <ExoContext> options) :
base(options)
{
}
protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
    {
// Essa string de conexão depende da SUA máquina.
optionsBuilder.UseSqlServer ("server=localhost\\SQLEXPRESS;" + "Database=ExoApi;Trusted_Connection=True");
// Exemplo 1 de string de conexão:
//User ID= sa;Password=12345;Server=localhost;Database=ExoApi + Trusted_Connection =false;
// Exemplo 2 de string de conexão:
//
  //Server='localhost\NOTEACER\SQLEXPRESS\ ;Database=ExoApi;Trusted_Connection=True;'
}
}
public DbSet<Projeto> Projetos { get ; set ;}
}
}