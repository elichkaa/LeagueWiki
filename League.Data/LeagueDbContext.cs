namespace League.Data
{
    using System;
    using EntityConfiguration;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Infrastructure;
    using Models;
    using Models.ChampionData;
    using Models.ItemData;
    //using Models.ItemData.Relationships;
    using Pomelo.EntityFrameworkCore.MySql;
    using Models.RuneData;
    using Pomelo.EntityFrameworkCore.MySql.Infrastructure;
    using Pomelo.EntityFrameworkCore.MySql.Internal;
    using Pomelo.EntityFrameworkCore.MySql.Query.Internal;

    public class LeagueDbContext : DbContext
    {
        public LeagueDbContext()
        {
            
        }

        public LeagueDbContext(DbContextOptions options)
            :base(options)
        {

        }

        //dbSets
        public DbSet<Champion> Champions { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Info> ChampionInfo { get; set; }
        public DbSet<Stats> Stats { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<TagsChampions> TagsChampions { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Gold> Gold { get; set; }
        public DbSet<MapsItem> MapsItem { get; set; }
        public DbSet<TagsItems> TagsItems { get; set; }
        public DbSet<RunePath> RunePaths { get; set; }
        public DbSet<Rune> Rune { get; set; }
        public DbSet<Slot> Slots { get; set; }
        public DbSet<Map> Map { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //T-SQL, SqlServer Management Studio
                optionsBuilder.UseSqlServer(Configuration.SqlServerConnectionString);

                //MySQL, MySQLWorkbench
                //optionsBuilder.UseMySql(Configuration.MySQLConnectionString, new MySqlServerVersion(new Version(8, 0, 22)), x => x
                //   .CharSetBehavior(CharSetBehavior.NeverAppend));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //configurations
            modelBuilder.ApplyConfiguration(new TagsChampionsConfiguration());
            modelBuilder.ApplyConfiguration(new TagsItemsConfiguration());
        }
    }
}
