using System.Collections.Generic;

namespace BestRestaurant.Models
{
  public class Cuisine
  {
    public Cuisine()
    {
        this.Restuarants = new HashSet<Restaurant>();
    }

    public int CuisineId { get; set; }
    public string Name { get; set; }
    public virtual ICollection<Restaurant> Restaurants { get; set; }  // lazy loading
  }
}