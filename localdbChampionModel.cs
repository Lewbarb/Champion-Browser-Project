namespace ChampionBrowser
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class localdbChampionModel : DbContext
    {
        public localdbChampionModel()
            : base("name=localdbChampionModel")
        {
        }

        public virtual DbSet<tblChampionMetaData> tblChampionMetaDatas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<tblChampionMetaData>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<tblChampionMetaData>()
                .Property(e => e.Q)
                .IsUnicode(false);

            modelBuilder.Entity<tblChampionMetaData>()
                .Property(e => e.W)
                .IsUnicode(false);

            modelBuilder.Entity<tblChampionMetaData>()
                .Property(e => e.E)
                .IsUnicode(false);

            modelBuilder.Entity<tblChampionMetaData>()
                .Property(e => e.R)
                .IsUnicode(false);

            modelBuilder.Entity<tblChampionMetaData>()
                .Property(e => e.passive)
                .IsUnicode(false);

            modelBuilder.Entity<tblChampionMetaData>()
                .Property(e => e.imageLink)
                .IsUnicode(false);
        }
    }
}
