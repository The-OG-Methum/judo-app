using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JudoApp.Models
{
    public enum WeightCategory
    {
        Flyweight,          // Up to 60kg
        Lightweight,        // 60-66kg
        LightMiddleweight,  // 66-73kg
        Middleweight,       // 73-81kg
        LightHeavyweight,   // 81-90kg
        Heavyweight         // 90kg+
    }

    public static class WeightCategoryExtensions
    {
        public static (double Min, double Max) GetWeightRange(this WeightCategory category)
        {
            return category switch
            {
                WeightCategory.Flyweight => (0, 60),
                WeightCategory.Lightweight => (60, 66),
                WeightCategory.LightMiddleweight => (66, 73),
                WeightCategory.Middleweight => (73, 81),
                WeightCategory.LightHeavyweight => (81, 90),
                WeightCategory.Heavyweight => (90, double.MaxValue),
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
