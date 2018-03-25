namespace ChampionBrowser
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class champion
    {
        [Key]
        [StringLength(20)]
        public string name { get; set; }

        public int basehp { get; set; }

        public int hpregen { get; set; }

        public int basemana { get; set; }

        public int basemanaregen { get; set; }

        public int range { get; set; }

        public int basead { get; set; }

        public double baseattackspeed { get; set; }

        public int basearmour { get; set; }

        public int basemr { get; set; }

        public int basespeed { get; set; }

        public int bluePrice { get; set; }

        public int rpPrice { get; set; }

        [Required]
        [StringLength(50)]
        public string Q { get; set; }

        [Required]
        [StringLength(50)]
        public string W { get; set; }

        [Required]
        [StringLength(50)]
        public string E { get; set; }

        [Required]
        [StringLength(50)]
        public string R { get; set; }

        [Required]
        [StringLength(50)]
        public string passive { get; set; }
        [StringLength(200)]
        public string imageLink { get; set; }
    }
}
