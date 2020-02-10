using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Model.Domain;

namespace Model
{
    public class AlbumDbContext : DbContext
    {
        public AlbumDbContext(DbContextOptions<AlbumDbContext> options) 
            : base(options)
        {

        }

        public DbSet<Album> Albums { get; set; }
    }
}
