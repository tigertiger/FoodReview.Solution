namespace FoodReview.Models
{
  public class Pyramid
  {
    public int PyramidId { get; set; }
    public int FoodId { get; set; }
    public int FoodGroupId { get; set; }
    public virtual FoodGroup FoodGroup { get; set; }
    public virtual Food Food { get; set; }
  }
}