using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JudoApp.Models
{
    public enum TrainingPlan
    {
        Beginner,      // Rs. 250/week
        Intermediate,  // Rs. 300/week
        Elite          // Rs. 350/week
    }

    public static class TrainingPlanExtensions
    {
        public static double GetWeeklyFee(this TrainingPlan plan)
        {
            return plan switch
            {
                TrainingPlan.Beginner => 250.0,
                TrainingPlan.Intermediate => 300.0,
                TrainingPlan.Elite => 350.0,
                _ => 0.0
            };
        }

        public static double GetMonthlyFee(this TrainingPlan plan)
        {
            return plan.GetWeeklyFee() * 4; // 4 weeks per month
        }

        public static bool CanEnterCompetitions(this TrainingPlan plan)
        {
            return plan == TrainingPlan.Intermediate || plan == TrainingPlan.Elite;
        }
    }
}
