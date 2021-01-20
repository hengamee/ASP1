using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WordsDoc.Models
{
    public class WordsContext : DbContext
    {
        public WordsContext(DbContextOptions<WordsContext> options)
            : base(options)

        {
        }

        public DbSet<Words> Words { get; set; }
    }


    public class WordsContextDesignTime : IDesignTimeDbContextFactory<WordsContext>
    {
        public WordsContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<WordsContext>();
            optionsBuilder.UseSqlServer("Data Source=POURASKARI-PC\\SQL2019;Initial Catalog=WordEf; Integrated Security=True;");

            return new WordsContext(optionsBuilder.Options);
        }
    }
}
 