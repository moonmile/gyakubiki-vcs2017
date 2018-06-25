using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace web453.Models
{
    public partial class Product
    {
        [Required(ErrorMessage = "{0}は必須項目です")]
        public int Id { get; set; }
        [Required(ErrorMessage = "{0}は必須項目です")]
        public string Name { get; set; }
        public int Price { get; set; }
    }
}
