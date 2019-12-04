using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MovieRatingApp.Data.Entities
{
    public class Actor
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
