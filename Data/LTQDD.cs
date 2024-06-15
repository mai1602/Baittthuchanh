using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using baithuchanh.Models;

    public class LTQDD : DbContext
    {
        public LTQDD (DbContextOptions<LTQDD> options)
            : base(options)
        {
        }

        public DbSet<baithuchanh.Models.LopHoc> LopHoc { get; set; } = default!;
    }
