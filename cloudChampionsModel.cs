namespace ChampionBrowser
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class cloudChampionsModel : DbContext
    {
        public cloudChampionsModel()
            : base("name=cloudChampionsModel")
        {
        }

        public virtual DbSet<champion> champions { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<champion>()
                .Property(e => e.name)
                .IsFixedLength();

            modelBuilder.Entity<champion>()
                .Property(e => e.Q)
                .IsFixedLength();

            modelBuilder.Entity<champion>()
                .Property(e => e.W)
                .IsFixedLength();

            modelBuilder.Entity<champion>()
                .Property(e => e.E)
                .IsFixedLength();

            modelBuilder.Entity<champion>()
                .Property(e => e.R)
                .IsFixedLength();

            modelBuilder.Entity<champion>()
                .Property(e => e.passive)
                .IsFixedLength();
        }
    }
}
