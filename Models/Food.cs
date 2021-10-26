using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
namespace FoodReview.Models
{
  public class Food
  {

    public int FoodId {get; set;}
    [Required]
    public string Name {get; set;}
    [Required]
    public string FoodGroup {get; set;}
    [Required]
    [Range(1,5, ErrorMessage = "This is a 5-Star system. Please rate between 1 and 5.")]
    public int Rating {get; set;}
    [StringLength(10000)]
    public string Review {get; set;}
    public string ImageName {get; set;}
    public string ImageLocation {get; set;}
  }
}