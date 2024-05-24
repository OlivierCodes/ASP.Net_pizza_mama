﻿using System.ComponentModel.DataAnnotations;

namespace pizza_mama.Models
{
    // Notre model de pizza
    public class Pizza
    {
        public int PizzaID { get; set; }

        [Display(Name ="Nom")]
        public string Nom {  get; set; }

        [Display(Name ="Prix")]
        public float Prix { get; set; }

        [Display(Name ="Végétarienne")]
        public bool Vegetarienne { get; set; }

        [Display(Name = "Ingrédients")]
        public string Ingredients { get; set; }

    }
}
