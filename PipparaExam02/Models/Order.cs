using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PipparaExam02.Models
{

    public enum Feedback
    {
        FIVESTAR, FOURSTAR, THREESTAR, TWOSTAR, ONESTAR
    }
    public class Order { 
      public int OrderID { get; set; }
      public int RestaurantID { get; set; }
      public int CustomerID { get; set; }
      public Feedback? Feedback { get; set; }

      public virtual Restaurant Restaurant { get; set; }
      public virtual Customer Customer { get; set; }
    }
}