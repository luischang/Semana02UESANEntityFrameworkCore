using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana02UESANEntityFrameworkCore.CodeFirst.Models
{
    public class MundialQatar2022DbContext: DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var cnx = "";
            optionsBuilder
                .UseSqlServer(cnx)
                .LogTo(Console.WriteLine, LogLevel.Information);        
        }

        public virtual DbSet<Player> Player { get; set; }


    }
}
