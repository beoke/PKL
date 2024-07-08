﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Latih10_KoneksiDatabase
{
    public class SekolahkuDbContext : DbContext
    {
        public DbSet<SiswaModel> Siswa { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Server=dev.smart-ics.com;Database=DbKerjaPraktek;User Id=KpLogin;Password=K3rjaPraktekLogin;TrustServerCertificate=True");
        }
    }
}
