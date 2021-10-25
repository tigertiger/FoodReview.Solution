using System.Collections.Generic;
namespace FoodReview.Models

{
  public class FoodGroup
  {
    public FoodGroup (string name)
    {
      name = Name;
    }
    public int FoodGroupId {get; set;}
    public string Name {get; set;}

    public virtual ICollection<Pyramid> JoinEntities {get; set;}
  }
}