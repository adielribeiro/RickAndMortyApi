using System;
using System.Collections.Generic;   
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Rm.API.Models;

namespace Rm.API.Context
{
    public class AppDBContext : DbContext
    { 
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options){}
        public DbSet<Models.Char> Char2 { get; set; }    
    }
}