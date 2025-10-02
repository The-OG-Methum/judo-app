using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JudoApp.Modles
{
    public class Athlete
    {
        public int Id { get; set; }
    public string NIC { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public TrainingPlan TrainingPlan { get; set; }
        public double CurrentWeight { get; set; }
        public WeightCategory CompetitionCategory { get; set; }
        public int CompetitionsThisMonth { get; set; }
        public double PrivateCoachingHours { get; set; }

        // Constants
        private const double COMPETITION_FEE = 220.0;
        private const double PRIVATE_COACHING_FEE_PER_HOUR = 90.50;
        private const double MAX_PRIVATE_HOURS_PER_WEEK = 5.0;
        private const double MAX_PRIVATE_HOURS_PER_MONTH = MAX_PRIVATE_HOURS_PER_WEEK * 4;

        public Athlete()
        {
            TrainingPlan = TrainingPlan.Beginner;
            CompetitionCategory = WeightCategory.Flyweight;
        }

        public Athlete(string name, TrainingPlan trainingPlan, double currentWeight, 
                      WeightCategory competitionCategory, int competitions = 0, double privateHours = 0)
        {
            Name = name;
            TrainingPlan = trainingPlan;
            CurrentWeight = currentWeight;
            CompetitionCategory = competitionCategory;
            CompetitionsThisMonth = competitions;
            PrivateCoachingHours = privateHours;
        }

        // Validation methods
        public List<string> ValidateInput(bool requireNic = false)
        {
            var errors = new List<string>();

            if (requireNic && string.IsNullOrWhiteSpace(NIC))
                errors.Add("NIC is required.");

            if (string.IsNullOrWhiteSpace(Name))
                errors.Add("Athlete name is required.");

            if (CurrentWeight <= 0)
                errors.Add("Current weight must be greater than 0.");

            if (CurrentWeight > 200)
                errors.Add("Current weight seems unrealistic (over 200kg).");

            if (CompetitionsThisMonth < 0)
                errors.Add("Number of competitions cannot be negative.");

            if (PrivateCoachingHours < 0)
                errors.Add("Private coaching hours cannot be negative.");

            if (PrivateCoachingHours > MAX_PRIVATE_HOURS_PER_MONTH)
                errors.Add($"Private coaching hours cannot exceed {MAX_PRIVATE_HOURS_PER_WEEK} hours per week ({MAX_PRIVATE_HOURS_PER_MONTH} hours per month).");

            if (!TrainingPlan.CanEnterCompetitions() && CompetitionsThisMonth > 0)
                errors.Add("Beginner athletes cannot enter competitions.");

            return errors;
        }

        // Cost calculation methods
        public double GetTrainingCost()
        {
            return TrainingPlan.GetMonthlyFee();
        }

        public double GetCompetitionCost()
        {
            if (!TrainingPlan.CanEnterCompetitions())
                return 0;

            return CompetitionsThisMonth * COMPETITION_FEE;
        }

        public double GetPrivateCoachingCost()
        {
            // Cap at maximum allowed hours per month
            double cappedHours = Math.Min(PrivateCoachingHours, MAX_PRIVATE_HOURS_PER_MONTH);
            return cappedHours * PRIVATE_COACHING_FEE_PER_HOUR;
        }

        public double GetTotalMonthlyCost()
        {
            return GetTrainingCost() + GetCompetitionCost() + GetPrivateCoachingCost();
        }

        public string GetWeightStatus()
        {
            return WeightCategoryExtensions.GetWeightStatus(CurrentWeight, CompetitionCategory);
        }

        // Report generation
        public string GenerateItemizedReport()
        {
            var report = new StringBuilder();
            report.AppendLine("=== ATHLETE COST REPORT ===");
            report.AppendLine($"Athlete: {Name}");
            report.AppendLine($"Training Plan: {TrainingPlan}");
            report.AppendLine($"Current Weight: {CurrentWeight:F1} kg");
            report.AppendLine($"Competition Category: {CompetitionCategory} {GetWeightCategoryRange()}");
            report.AppendLine($"Weight Status: {GetWeightStatus()}");
            report.AppendLine();
            report.AppendLine("=== MONTHLY COSTS ===");
            report.AppendLine($"Training Cost: Rs. {GetTrainingCost():F2}");
            
            if (TrainingPlan.CanEnterCompetitions())
            {
                report.AppendLine($"Competition Cost: Rs. {GetCompetitionCost():F2} ({CompetitionsThisMonth} competitions)");
                report.AppendLine("  * Competitions held on 2nd Saturday of each month");
            }
            else
            {
                report.AppendLine("Competition Cost: Rs. 0.00 (Not applicable for Beginner)");
            }
            
            report.AppendLine($"Private Coaching: Rs. {GetPrivateCoachingCost():F2} ({PrivateCoachingHours:F1} hours)");
            report.AppendLine($"  * Maximum 5 hours per week allowed");
            report.AppendLine(new string('-', 50));
            report.AppendLine($"TOTAL MONTHLY COST: Rs. {GetTotalMonthlyCost():F2}");
            report.AppendLine();

            return report.ToString();
        }

        private string GetWeightCategoryRange()
        {
            var (min, max) = CompetitionCategory.GetWeightRange();
            if (max == double.MaxValue)
                return $"(≥{min}kg)";
            else
                return $"({min}-{max}kg)";
        }

        public string GenerateSummaryReport()
        {
            return $"{Name} - {TrainingPlan} - Rs. {GetTotalMonthlyCost():F2}";
        }
    }
}
