using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MvcPillow.Models; //add MvcPillow.Models using statement
using System;
using System.Collections.Generic;
using System.Text;

namespace MvcPillow.Data
{
    public class MvcPillowContext : IdentityDbContext
    {
        public MvcPillowContext(DbContextOptions<MvcPillowContext> options)
            : base(options)
        {
        }

        public DbSet<Pillow> Pillow { get; set; }
    }
}
