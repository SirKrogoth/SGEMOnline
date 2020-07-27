using Microsoft.EntityFrameworkCore;
using SGEMOnline.Business.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SGEMOnline.Data.Context
{
    public class SGEMOnlineDBContext : DbContext
    {
        public SGEMOnlineDBContext(DbContextOptions options) : base(options) { }

        public DbSet<Item> Itens { get; set; }

    }
}
