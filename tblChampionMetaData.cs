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
        
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int basehp { get; set; }
        
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int hpregen { get; set; }
        
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int basemana { get; set; }
        
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int basemanaregen { get; set; }
        
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int range { get; set; }
        
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int basead { get; set; }
        
        [Column(Order = 7)]
        public double baseattackspeed { get; set; }
        
        [Column(Order = 8)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int basearmour { get; set; }
        
        [Column(Order = 9)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int basemr { get; set; }

        [Column(Order = 10)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int basespeed { get; set; }
        
        [Column(Order = 11)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int bluePrice { get; set; }

        [Column(Order = 12)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int rpPrice { get; set; }
        
        [Column(Order = 13)]
        [StringLength(50)]
        public string Q { get; set; }
        
        [Column(Order = 14)]
        [StringLength(50)]
        public string W { get; set; }
        
        [Column(Order = 15)]
        [StringLength(50)]
        public string E { get; set; }
        
        [Column(Order = 16)]
        [StringLength(50)]
        public string R { get; set; }
        
        [Column(Order = 17)]
        [StringLength(50)]
        public string passive { get; set; }

        [StringLength(300)]
        public string imageLink { get; set; }
    }
}
