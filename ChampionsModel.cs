namespace ChampionBrowser
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ChampionsModel : DbContext
    {
        public ChampionsModel()
            : base("name=ChampionsEntities")
        {
        }

        public virtual DbSet<tblTest> tblTests { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<tblTest>()
                .Property(e => e.passive)
                .IsFixedLength();
        }
    }
}
