using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VentasAPINet.Models;

namespace VentasAPINet.Data
{
    public class VentasAPINetContext : DbContext
    {
        public VentasAPINetContext (DbContextOptions<VentasAPINetContext> options)
            : base(options)
        {
        }

        public DbSet<VentasAPINet.Models.Producto> Producto { get; set; } = default!;
    }
}
