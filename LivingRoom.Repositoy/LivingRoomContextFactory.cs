using LivingRoom.Repositoy.DataContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivingRoom.Repositoy
{
    internal class LivingRoomContextFactory : IDesignTimeDbContextFactory<LivingRoomContext>
    {
        public LivingRoomContext CreateDbContext(string[] args)
        {
            var OptionBuilder = new DbContextOptionsBuilder<LivingRoomContext>();

            OptionBuilder.UseNpgsql("Host=localhost;Database=pruebas;Username=UsuSistema;Password=Welcome101!");

            return new LivingRoomContext(OptionBuilder.Options);    
        }
    }
}
