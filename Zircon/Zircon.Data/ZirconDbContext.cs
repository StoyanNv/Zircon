using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Zircon.Data
{
    public class ZirconDbContext : IdentityDbContext
    {
        public ZirconDbContext(DbContextOptions<ZirconDbContext> options)
            : base(options)
        {
        }
    }
}
