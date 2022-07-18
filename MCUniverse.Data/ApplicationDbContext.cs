using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MCUniverse.Data.Entities;
using Microsoft.EntityFrameworkCore;
using MCUniverse.Data;

namespace MCUniverse.Data;

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions <ApplicationDbContext> options) 
        : base(options)
        {
        }
        public DbSet<StudentEntity> Students { get; set; }
    }


