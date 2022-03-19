using Core;
using DatabaseContext;
using DatabaseModels;
using Extractor1;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Main
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var connectionString = "User ID=postgres; Password=123; Server=localhost; Port=5432; Database = Culture ";
            var optionsBuilder = new DbContextOptionsBuilder<DatabaseContexts>();
            optionsBuilder.UseNpgsql(connectionString);
            DatabaseContexts context = new DatabaseContexts(optionsBuilder.Options);

            Facade response = new Facade(context, "Vneparlamentskie Partii", "bash_mag");
            try
            {
                await response.GetParty();
                await response.GetAllUserInfo();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }



        }
    }
}
