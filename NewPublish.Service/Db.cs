using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using NewPublish.Model.Entity;

namespace NewPublish.Service
{
    /// <summary>
    /// 访问数据库上下文
    /// </summary>
    class Db:DbContext
    {
        public Db() { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=10.177.5.111;Initial Catalog=NewsPublish;User ID=sa;Password=sa123-",b=>b.UseRowNumberForPaging());
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        public virtual DbSet<Banner> Banner { get; set; }
        public virtual DbSet<NewsClassify> NewsClassifies { get; set; }
        public virtual DbSet<News> News { get; set; }
        public virtual DbSet<NewsComment> NewsComments { get; set; }

    }
}
