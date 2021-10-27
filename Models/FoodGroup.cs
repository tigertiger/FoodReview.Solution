using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace FoodReview.Models
{

  public class FoodGroup
  {
    public FoodGroup()
    {
      this.JoinEntities2 = new HashSet<Pyramid>();
    }

    public int FoodGroupId { get; set; }
    public string FgName { get; set; }
    
    public virtual ICollection<Pyramid> JoinEntities2 { get; set; }

  }

}