using System;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Logging;
using SamuraiApp.Data;
using SamuraiApp.Domain;

namespace ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            InsertSamurai();
            InsertMultipleSamurais();
        }

        private static void InsertMultipleSamurais()
        {
            var samurai1 = new Samurai { Name = "Testa" };
            var samurai2 = new Samurai { Name = "Testb" };
            using (var context = new SamuraiContext())
            {
                context.Samurais.AddRange(samurai1, samurai2);
                context.SaveChanges();
            }
        }

        private static void InsertSamurai()
        {
            var samurai = new Samurai { Name = "Test" };
            using (var context = new SamuraiContext())
            {
                //context.GetService<ILoggerFactory>().AddProvider(new MyLoggerProvider());
                context.Samurais.Add(samurai);
                context.SaveChanges();
            }
        }
    }
}
