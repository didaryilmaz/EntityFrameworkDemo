using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace EntityFrameworkDemo
{
    public class NorthWindContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server");
        }

}
