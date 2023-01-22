using Microsoft.EntityFrameworkCore;
using NZWalks.API.Models.Domain;

namespace NZWalks.API.Data
{
    public class NZWalksDbContext:DbContext
    {
        //constructor
        public NZWalksDbContext(DbContextOptions<NZWalksDbContext> options): base(options) //passing options to base class 
        {
            
        }
        //properties
        public DbSet<Region> Regions { get; set; }// please create a regions table if it doesn't exist in the db.
        public DbSet<Walk> Walks { get; set; }
        public DbSet<WalkDifficulty> WalkDifficulty { get; set; } //lookup table

    }
}
