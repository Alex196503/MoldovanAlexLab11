using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Moldovan_Alex_Lab11.Models;

namespace Moldovan_Alex_Lab11.Data
{
    public class Moldovan_Alex_Lab11Context : DbContext
    {
        public Moldovan_Alex_Lab11Context (DbContextOptions<Moldovan_Alex_Lab11Context> options)
            : base(options)
        {
        }

        public DbSet<Moldovan_Alex_Lab11.Models.ShopList> ShopList { get; set; } = default!;
    }
}
