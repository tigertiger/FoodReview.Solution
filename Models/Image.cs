using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FoodReview.Models
{
  public class Image
  {
    public int ImageId { get; set; }
    [Required]
    public string ImageName { get; set; }
    [Required]
    public string ImageLocation { get; set; }
    public int FoodId { get; set; }
    public virtual Food Food { get; set; }
  }
}