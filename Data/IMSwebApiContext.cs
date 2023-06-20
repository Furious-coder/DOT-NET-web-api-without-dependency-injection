using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using IMSwebApi.Models;

namespace IMSwebApi.Data
{
    public class IMSwebApiContext : DbContext
    {
        public IMSwebApiContext (DbContextOptions<IMSwebApiContext> options)
            : base(options)
        {
        }

        public DbSet<IMSwebApi.Models.BookModel> BookModel { get; set; } = default!;
    }
}
