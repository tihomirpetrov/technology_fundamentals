﻿namespace ToDoList.Data
{
    using Microsoft.EntityFrameworkCore;
    using ToDoList.Models;
    public class ToDoDbContext : DbContext
    {
        public DbSet<Task> Tasks { get; set; }

        private const string ConnectionString = @"Server=.\SQLEXPRESS;Database=ToDoListDb;Integrated Security=True;";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);
        }
    }
}