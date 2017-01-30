using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using WebStore.Data;

namespace WebStore.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider provider)
        {
            using (var context = new ApplicationDbContext(provider.GetRequiredService<DbContextOptions<ApplicationDbContext>>()))
            {
                // Sjekk om produkt-/ og kundedatabasetabeller inneholder data.
                if (context.Product.Any() && context.Customer.Any())
                {
                    return; 
                }

                // Fyll tabeller med data dersom de ikke inneholder data fra før.
                context.Product.AddRange(
                    new Product { Category = "Analog synth", Manifacturer = "Korg", Description = "Analog mono-synth med sequencer og effekter.", Name = "Monologue", Price = 2995 },
                    new Product { Category = "Drum machine", Manifacturer = "Korg", Description = "Analog trommemaskin med sequencer og delay.", Name = "Volca Beats", Price = 4649 },
                    new Product { Category = "Drum machine", Manifacturer = "Roland", Description = "Autentisk reproduksjon av TR-909.", Name = "TR-09", Price = 4649 },
                    new Product { Category = "Digital synth", Manifacturer = "Yamaha", Description = "Ekte FM-synthesis med touchskjerm.", Name = "Reface DX", Price = 3695 });

                context.Customer.AddRange(
                    new Customer { FirstName = "Marius", LastName = "Riis Haugan", Email = "riishaug@marius.no", Birthday = DateTime.Parse("03.05.1984") },
                    new Customer { FirstName = "Fauna", LastName = "Riis Skjelbred", Email = "riisbred@fauna.no", Birthday = DateTime.Parse("03.02.2017") },
                    new Customer { FirstName = "Julia", LastName = "Skjelbred", Email = "skjelbred@julia.no", Birthday = DateTime.Parse("10.12.1984") });

                // Skriv endringer.
                context.SaveChanges();
            }
        }
    }
}
