using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System;

namespace FoodReview.Models
{
  public class Food
  {

    public Food()
    {
      this.JoinEntities = new HashSet<FoodRating>();
      this.JoinEntities2 = new HashSet<Pyramid>();
    }

    public int FoodId {get; set;}
    [Required]
    public string Name {get; set;}
    
    public virtual ICollection<FoodRating> JoinEntities {get; set;}
    public virtual ICollection<Pyramid> JoinEntities2 {get; set;}
    public virtual ICollection<Review> Reviews {get; set;}
    public virtual ICollection<Image> Images {get; set;}
  }
}