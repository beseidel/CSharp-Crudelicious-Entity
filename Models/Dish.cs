using System;
using System.ComponentModel.DataAnnotations;

namespace CrudDelicious.Models
{
    public class Dish
    {
        [Key]
       public int Id { get; set; }
      
       public string ChefName{get; set;}
       
       public string DishName{get; set;}
      
       public int Calories{get; set;}
   
       public int Tastiness{get; set;}
   
       public string Descriptions{get; set;}
       public DateTime CreatedAt {get;set;}
       public DateTime UpdatedAt {get;set;}
    }
}