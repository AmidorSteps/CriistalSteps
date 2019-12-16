using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Criistal.Models;

namespace Criistal.Data
{
    public class CriistalContext : DbContext
    {
        public CriistalContext (DbContextOptions<CriistalContext> options)
            : base(options)
        {
        }

        public DbSet<Criistal.Models.User> User { get; set; }

        public DbSet<Criistal.Models.Role> Role { get; set; }

        public DbSet<Criistal.Models.UserRole> UserRole { get; set; }

        public DbSet<Criistal.Models.Permission> Permission { get; set; }

        public DbSet<Criistal.Models.UserPermission> UserPermission { get; set; }

        public DbSet<Criistal.Models.Country> Country { get; set; }

        public DbSet<Criistal.Models.Client> Client { get; set; }
    }
}
