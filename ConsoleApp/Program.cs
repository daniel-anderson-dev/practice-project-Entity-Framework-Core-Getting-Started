using SamuraiApp.Data;
using SamuraiApp.Domain;
using System;
using System.Linq;

namespace ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            //InsertSamurai();
            //InsertMultipleSamurais();
            SimpleSamuraiQuery();
        }

        private static void SimpleSamuraiQuery()
        {
            using (var context = new SamuraiContext())
            {
                var samurais = context.Samurais.ToList();
                foreach (var item in samurais)
                {
                    Console.WriteLine(item.Name);
                }
            }
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
