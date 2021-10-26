using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace FoodReview.Models
{

  public class Rating
  {
    public Rating()
    {
      this.JoinEntities = new HashSet<FoodRating>();
    }

    public int RatingId { get; set; }
    public int Stars { get; set; }
    
    public virtual ICollection<FoodRating> JoinEntities { get; set; }

  }

}