using System;
using Microsoft.EntityFrameworkCore;
using MVCRevision.Models;

namespace MVCRevision.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options) : base(options)
    {
        
    }
    public DbSet<Post>Posts { get; set; }

}
