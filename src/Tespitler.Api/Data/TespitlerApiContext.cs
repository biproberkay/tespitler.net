using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Tespitler.Api.Data
{
    public class TespitlerApiContext : DbContext
    {
        public TespitlerApiContext (DbContextOptions<TespitlerApiContext> options)
            : base(options)
        {
        }

        public DbSet<Tespitler.Api.Data.Statement> Statement { get; set; }
    }
}
