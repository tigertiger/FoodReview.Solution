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
    [Required]
    [Range(1,5, ErrorMessage = "This is a 5-Star system. Please rate between 1 and 5.")]
    public int Stars { get; set; }
    
    public virtual ICollection<FoodRating> JoinEntities { get; set; }

  }

}