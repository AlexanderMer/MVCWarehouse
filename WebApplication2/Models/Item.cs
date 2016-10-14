using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class Item
    {
        [Required]
        public int ItemID { get; set; }

        [Required]
        [Display(Name = "Item name")]
        public string Title { get; set; }

        [Required]
        public string Organization { get; set; }

        [Required]
        public int Amount { get; set; }
    }
}