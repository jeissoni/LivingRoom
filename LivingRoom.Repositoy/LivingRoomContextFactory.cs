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
    //fabrica de contexto
    class LivingRoomContextFactory : 
        IDesignTimeDbContextFactory<LivingRoomContext>
    {
        public LivingRoomContext CreateDbContext(string[] args)
        {
            var OptionBuilder = 
                new DbContextOptionsBuilder<LivingRoomContext>();

            OptionBuilder.UseNpgsql
                ("Host=tuffi.db.elephantsql.com;Database=bdtosahd;Username=bdtosahd;Password=exF7SDHWA1Km8NVFWUGzhV0FM4X1Di72");

            return new LivingRoomContext(OptionBuilder.Options);    
        }
    }
}
