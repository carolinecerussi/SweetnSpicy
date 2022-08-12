using System.Collections.Generic;

namespace Shop.Models
{
  public class Treat
  {
    public Treat()
    {
      this.JoinEntities = new HashSet<TreatFlavor>();
    }

    public int TreatId { get; set; }
    public string TreatName { get; set; }
    public virtual ICollection<TreatFlavor> JoinEntities { get;}
    public virtual ApplicationUser User { get; set; }
  }
}