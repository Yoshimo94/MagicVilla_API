﻿using System.ComponentModel.DataAnnotations;

namespace MagicVilla_Web.Model.Dto
{
    public class VillaNumberDTO
    {
        [Required]
        public int VillaNo { get; set; }
        public int VillaID { get; set; }
        public string SpecialDetails { get; set; }
        public VillaDTO Villa { get; set; }
    }
}
