using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirstApp.Model
{
    public static class DataSeedClass
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().HasData(
            new Book { Id = 1, Name = "Rafael", Author = "Milanes", Code = 333422 },
            new Book { Id = 2, Name = "Johnny", Author = "Cage", Code = 775647 },
            new Book { Id = 3, Name = "Anna", Author = "Lindgren", Code = 009873 },
            new Book { Id = 4, Name = "Juanete", Author = "Pérez", Code = 112342 },
            new Book { Id = 5, Name = "New", Author = "SuperNew", Code = 7746398 }
            );
        }
    }
}
