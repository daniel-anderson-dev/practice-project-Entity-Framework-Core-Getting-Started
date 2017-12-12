﻿using Microsoft.EntityFrameworkCore.Infrastructure;
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
