using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blood_Sugars.Models
{
    public class BloodSugar
    {

        public int BloodSugarId { get; set; }
        public User UserName { get; set; }
        public int BloodSugars { get; set; }
        public string Protein { get; set; }
        public string Veggie { get; set; }
        public string Fruit { get; set; }
        public string Drink { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public BeforeAfter BsMealEatin { get; set; }


        public enum User { Scott, Kolleen }

        public enum BeforeAfter { Before_Meal, After_Meal }
    }
}
