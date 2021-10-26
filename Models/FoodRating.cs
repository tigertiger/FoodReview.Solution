namespace FoodReview.Models
{
  public class FoodRating
  {
    public int FoodRatingId {get; set;}
    public int FoodId {get; set;}
    public int RatingId {get; set;}
    public virtual Food Food {get; set;}
    public virtual Rating Rating {get; set;}
  }
}