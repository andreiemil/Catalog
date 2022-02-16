﻿#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Catalog.Models;

namespace Catalog.Data
{
    public class CatalogContext : DbContext
    {
        public CatalogContext (DbContextOptions<CatalogContext> options)
            : base(options)
        {
        }

        public DbSet<Catalog.Models.Course> Course { get; set; }

        public DbSet<Catalog.Models.Student> Student { get; set; }

        public DbSet<Catalog.Models.Teacher> Teacher { get; set; }
    }
}
