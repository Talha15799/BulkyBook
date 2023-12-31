﻿using BulkyBook.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace BulkyBook.DataAccess;

public class ApplicationDbContext :IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
    {
            
    }
    public DbSet<Category> categories { get; set; }
    public DbSet<CoverType> covertypes { get; set; }
    public DbSet<Product> products { get; set; }
}
