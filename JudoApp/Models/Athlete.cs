using System;
using System.Collections.Generic;
using System.Text;

namespace JudoApp.Models
{
    public class Athlete
    {
        // Auto-incremented primary key
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public TrainingPlan TrainingPlan { get; set; } = TrainingPlan.Beginner;
        public double CurrentWeight { get; set; }
        public WeightCategory CompetitionCategory { get; set; } = WeightCategory.Flyweight;
        public int CompetitionsThisMonth { get; set; }
        public double PrivateCoachingHours { get; set; }

        // Constants
        private const double COMPETITION_FEE = 220.0;
        private const double PRIVATE_COACHING_FEE_PER_HOUR = 90.50;
        private const double MAX_PRIVATE_HOURS_PER_WEEK = 5.0;
        private const double MAX_PRIVATE_HOURS_PER_MONTH = MAX_PRIVATE_HOURS_PER_WEEK * 4;

        // Validation
        public List<string> ValidateInput()
        {
            var errors = new List<string>();

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

        // Cost calculation
        public double GetTrainingCost() => TrainingPlan.GetMonthlyFee();
        public double GetCompetitionCost() => TrainingPlan.CanEnterCompetitions() ? CompetitionsThisMonth * COMPETITION_FEE : 0;
        public double GetPrivateCoachingCost() => Math.Min(PrivateCoachingHours, MAX_PRIVATE_HOURS_PER_MONTH) * PRIVATE_COACHING_FEE_PER_HOUR;
        public double GetTotalMonthlyCost() => GetTrainingCost() + GetCompetitionCost() + GetPrivateCoachingCost();

        // Weight status
        public string GetWeightStatus() => WeightCategoryExtensions.GetWeightStatus(CurrentWeight, CompetitionCategory);

        // Reports
        public string GenerateItemizedReport()
        {
            var report = new StringBuilder();
            report.AppendLine("=== ATHLETE COST REPORT ===");
            report.AppendLine($"Id: {Id}");
            report.AppendLine($"Athlete: {Name}");
            report.AppendLine($"Training Plan: {TrainingPlan}");
            report.AppendLine($"Current Weight: {CurrentWeight:F1} kg");
            report.AppendLine($"Competition Category: {CompetitionCategory} {GetWeightCategoryRange()}");
            report.AppendLine($"Weight Status: {GetWeightStatus()}");
            report.AppendLine();
            report.AppendLine("=== MONTHLY COSTS ===");
            report.AppendLine($"Training Cost: Rs. {GetTrainingCost():F2}");

            if (TrainingPlan.CanEnterCompetitions())
                report.AppendLine($"Competition Cost: Rs. {GetCompetitionCost():F2} ({CompetitionsThisMonth} competitions)");
            else
                report.AppendLine("Competition Cost: Rs. 0.00 (Not applicable for Beginner)");

            report.AppendLine($"Private Coaching: Rs. {GetPrivateCoachingCost():F2} ({PrivateCoachingHours:F1} hours)");
            report.AppendLine(new string('-', 50));
            report.AppendLine($"TOTAL MONTHLY COST: Rs. {GetTotalMonthlyCost():F2}");
            return report.ToString();
        }

        private string GetWeightCategoryRange()
        {
            var (min, max) = CompetitionCategory.GetWeightRange();
            return max == double.MaxValue ? $"(≥{min}kg)" : $"({min}-{max}kg)";
        }

        public string GenerateSummaryReport() => $"{Name} - {TrainingPlan} - Rs. {GetTotalMonthlyCost():F2}";
    }
}
