using Microsoft.EntityFrameworkCore;
using WebAngular.API.Models;

namespace WebAngular.API.Data
{
    public class DataContext: DbContext
    {       
    
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {


        }
        public DbSet <Evento> Eventos { get; set; }
    }
}
