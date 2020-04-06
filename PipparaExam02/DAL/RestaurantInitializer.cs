using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using PipparaExam02.Models;

namespace PipparaExam02.DAL
{
    public class RestaurantInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<RestaurantContext>
    {
        protected override void Seed(RestaurantContext context)
        {
            var students = new List<Customer>
            {
            new Customer{FirstMidName="Carson",LastName="Alexander",OrderDate=DateTime.Parse("2005-09-01")},
            new Customer{FirstMidName="Meredith",LastName="Alonso",OrderDate=DateTime.Parse("2002-09-01")},
             };

            students.ForEach(s => context.Customers.Add(s));
            context.SaveChanges();
            var courses = new List<Restaurant>
            {
            new Restaurant{RestaurantID=1050,Title="Chemistry",CostRange=3,},
            new Restaurant{RestaurantID=4022,Title="Microeconomics",CostRange=3,},
            };
            courses.ForEach(s => context.Restaurants.Add(s));
            context.SaveChanges();
            var enrollments = new List<Order>
            {
            new Order{CustomerID=1,RestaurantID=1050,Feedback=Feedback.FIVESTAR},
            new Order{CustomerID=1,RestaurantID=4022,Feedback=Feedback.FOURSTAR},
           };
            enrollments.ForEach(s => context.Orders.Add(s));
            context.SaveChanges();

        }
    }
}
