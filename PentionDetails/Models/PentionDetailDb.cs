using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PentionDetails.Models
{
    public class PentionDetailDb: DbContext
    {
        public PentionDetailDb()
        {
        }


        public PentionDetailDb(DbContextOptions<PentionDetailDb> options) : base(options)
        {

        }

        public DbSet<PentionDetailModel> PentionDetails { get; set; }


        

    }
}
