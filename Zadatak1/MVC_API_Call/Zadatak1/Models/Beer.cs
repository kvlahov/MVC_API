using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Web;

namespace Zadatak1.Models
{
    public class Beer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [Display(Name="Image")]
        public string Image_Url { get; set; }
        public string Description { get; set; }

        [JsonProperty("first_brewed")]
        [Display(Name = "First Brewed")]
        public string First_Brewed { get; set; }

        [Display(Name = "Alcohol per Volume")]
        [DisplayFormat(DataFormatString = "{0:#,##0.0#}")]
        public double Abv { get; set; }

        [Display(Name = "Food Pairing")]
        public List<string> Food_Pairing { get; set; }

    }
}