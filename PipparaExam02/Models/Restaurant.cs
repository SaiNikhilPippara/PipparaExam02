using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace PipparaExam02.Models
{
    public class Restaurant
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RestaurantID { get; set; }
        public string Title { get; set; }
        public int CostRange     { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}