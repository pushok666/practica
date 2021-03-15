using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace BaseEFCore
{
    //Взаимодействие с БД
    class AplicationContext : DbContext// класс определяющий контекст данных
    {
        public DbSet<User> Users { get; set; }//набор объектов в БД

        public AplicationContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)//установка параметров подключения
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\\mssqllocaldb;Database=helloappdb;Trusted_Connection=True;");
        }
    }
}
