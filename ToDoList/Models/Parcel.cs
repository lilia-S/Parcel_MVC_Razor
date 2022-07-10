using System.Collections.Generic;

namespace ToDoList.Models
{
  public class Parcel
  {
		
    public int Side1 { get; set; }
		public int Side2 { get; set; }
		public int Side3 { get; set; }
		public int Weight { get; set; }

    public Parcel(int side1, int side2, int side3, int weight)
		{
			this.Side1 = side1;
			this.Side2 = side2;
			this.Side3 = side3;
			this.Weight = weight;
		}

    public int Volume()
		{
			return this.Side1 * this.Side2 * this.Side3;
		}
		
  }
}
