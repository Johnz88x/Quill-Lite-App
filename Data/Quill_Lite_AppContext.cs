using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Quill_Lite_App.Models;

namespace Quill_Lite_App.Data
{
    public class Quill_Lite_AppContext : DbContext
    {
        public Quill_Lite_AppContext (DbContextOptions<Quill_Lite_AppContext> options)
            : base(options)
        {
        }

        public DbSet<Quill_Lite_App.Models.Quill> Quill { get; set; } = default!;
    }
}
