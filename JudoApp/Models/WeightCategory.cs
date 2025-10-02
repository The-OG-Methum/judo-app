using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JudoApp.Models
{
    public enum WeightCategory
    {
        Flyweight,          // 66kg
        Lightweight,        // 73kg
        LightMiddleweight,  // 81kg
        Middleweight,       // 90kg
        LightHeavyweight,   // 100kg
        Heavyweight         // 100kg+
    }

    public static class WeightCategoryExtensions
    {
        public static (double Min, double Max) GetWeightRange(this WeightCategory category)
        {
            return category switch
            {
                WeightCategory.Flyweight => (0,66),
                WeightCategory.Lightweight => (66, 73),
                WeightCategory.LightMiddleweight => (73, 81),
                WeightCategory.Middleweight => (81, 90),
                WeightCategory.LightHeavyweight => (90, 100),
                WeightCategory.Heavyweight => (100, double.MaxValue),
                _ => (0, 0)
            };
        }

        public static string GetWeightStatus(double currentWeight, WeightCategory category)
        {
            var (min, max) = category.GetWeightRange();
            
            if (currentWeight < min)
                return "Underweight for category";
            else if (currentWeight > max)
                return "Overweight for category";
            else
                return "Weight matches category";
        }
    }
}
