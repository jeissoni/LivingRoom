using LivingRoom.Repositoy.DataContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Npgsql;

namespace LivingRoom.Repositoy
{
    //fabrica de contexto
    // tiempo de diseño, no se crean en tiempo de ejecucion 
    public class LivingRoomContextFactory : 
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

//1.
// add - migration Migration19072022 - p LivingRoom.Repositoy - c LivingRoomContext - o Migrations - s LivingRoom.Repositoy
// Add-Migration [-Name] <String> [-OutputDir <String>] [-Context <String>] [-Project <String>][-StartupProject<String>][<CommonParameters>]
// add-migration Migration19072022 -p LivingRoom.Repositoy -c LivingRoomContext -o Migrations -s LivingRoom.Repositoy


//2. 
//update-database Migration19072022 -p LivingRoom.Repositoy -s LivingRoom.Repositoy