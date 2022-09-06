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
            //Windows Authentications
            var cnx = "Server=DESKTOP-S1DROK0\\SQLEXPRESS;Database=MundialQatar2022;Integrated Security=true";
            //SQL Authentication
            //var cnx = "Server=DESKTOP-S1DROK0\\SQLEXPRESS;Database=MundialQatar2022;User=AQUI_VA_MI_USUARIO;Password=AQUI_VA_MI_PASSWORD";

            optionsBuilder
                .UseSqlServer(cnx)
                .LogTo(Console.WriteLine, LogLevel.Information);        
        }

        public virtual DbSet<Player> Player { get; set; }


    }
}
