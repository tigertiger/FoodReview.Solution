using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FoodReview.Models
{
  public class Review
  {
    public int ReviewId {get; set;}
    [Required]
    [StringLength(10000)]
    public string ReviewText {get; set;}
    public int FoodId {get; set;}
    public virtual Food Food {get; set;}
  }
}