namespace ChampionBrowser
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblChampionMetaData")]
    public partial class tblChampionMetaData
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string name { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int basehp { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int hpregen { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int basemana { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int basemanaregen { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int range { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int basead { get; set; }

        [Key]
        [Column(Order = 7)]
        public double baseattackspeed { get; set; }

        [Key]
        [Column(Order = 8)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int basearmour { get; set; }

        [Key]
        [Column(Order = 9)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int basemr { get; set; }

        [Key]
        [Column(Order = 10)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int basespeed { get; set; }

        [Key]
        [Column(Order = 11)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int bluePrice { get; set; }

        [Key]
        [Column(Order = 12)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int rpPrice { get; set; }

        [Key]
        [Column(Order = 13)]
        [StringLength(50)]
        public string Q { get; set; }

        [Key]
        [Column(Order = 14)]
        [StringLength(50)]
        public string W { get; set; }

        [Key]
        [Column(Order = 15)]
        [StringLength(50)]
        public string E { get; set; }

        [Key]
        [Column(Order = 16)]
        [StringLength(50)]
        public string R { get; set; }

        [Key]
        [Column(Order = 17)]
        [StringLength(50)]
        public string passive { get; set; }

        [StringLength(300)]
        public string imageLink { get; set; }
    }
}
