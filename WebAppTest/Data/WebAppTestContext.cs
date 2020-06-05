using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebAppTest.Models;

namespace WebAppTest.Data
{
    public class WebAppTestContext : DbContext
    {
        public WebAppTestContext (DbContextOptions<WebAppTestContext> options)
            : base(options)
        {
        }

        public DbSet<WebAppTest.Models.Movie> Movie { get; set; }
    }
}
