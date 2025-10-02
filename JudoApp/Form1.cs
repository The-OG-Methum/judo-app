using JudoApp.Models;
using JudoApp.Data;
using System.Text;

namespace JudoApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeForm();
        }

        private void InitializeForm()
        {
            // Set default values
            cmbTrainingPlan.SelectedIndex = 0; // Beginner
            cmbCompetitionCategory.SelectedIndex = 0; // Flyweight

            // Add event handlers for real-time validation
            cmbTrainingPlan.SelectedIndexChanged += CmbTrainingPlan_SelectedIndexChanged;
            txtCurrentWeight.TextChanged += TxtCurrentWeight_TextChanged;
            cmbCompetitionCategory.SelectedIndexChanged += CmbCompetitionCategory_SelectedIndexChanged;
            txtCompetitions.TextChanged += TxtCompetitions_TextChanged;
        }

        private void CmbTrainingPlan_SelectedIndexChanged(object? sender, EventArgs e)
        {
            // Disable competitions for Beginner athletes
            if (cmbTrainingPlan.SelectedIndex == 0) // Beginner
            {
                txtCompetitions.Enabled = false;
                txtCompetitions.Text = "0";
                lblCompetitions.Text = "Competitions this month: (Not applicable for Beginner)";
                lblCompetitionInfo.Text = "Only Intermediate and Elite athletes can enter competitions";
                lblCompetitionInfo.ForeColor = System.Drawing.Color.Gray;
            }
            else
            {
                txtCompetitions.Enabled = true;
                lblCompetitions.Text = "Competitions this month:";
                lblCompetitionInfo.Text = "Only Intermediate and Elite athletes can enter competitions\nCompetitions held on 2nd Saturday of each month";
                lblCompetitionInfo.ForeColor = System.Drawing.Color.DarkGreen;
            }
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                // Clear previous output
                lblOutput.Text = "";

                // Parse and validate input
                var athlete = CreateAthleteFromInput();
                var validationErrors = athlete.ValidateInput();

                if (validationErrors.Any())
                {
                    DisplayValidationErrors(validationErrors);
                    return;
                }

                // Upsert by Name (or other simple key) and calculate
                using (var db = new JudoContext())
                {
                    var existing = db.Athletes.FirstOrDefault(a => a.Name.ToLower() == athlete.Name.ToLower());
                    if (existing is null)
                    {
                        db.Athletes.Add(athlete);
                    }
                    else
                    {
                        existing.TrainingPlan = athlete.TrainingPlan;
                        existing.CurrentWeight = athlete.CurrentWeight;
                        existing.CompetitionCategory = athlete.CompetitionCategory;
                        existing.CompetitionsThisMonth = athlete.CompetitionsThisMonth;
                        existing.PrivateCoachingHours = athlete.PrivateCoachingHours;
                    }
                    db.SaveChanges();
                }

                var report = athlete.GenerateItemizedReport();
                lblOutput.Text = report;
            }
            catch (Exception ex)
            {
                lblOutput.Text = $"Error: {ex.Message}";
            }
        }

        

        private async void BtnSave_Click(object? sender, EventArgs e)
        {
            try
            {
                var athlete = CreateAthleteFromInput();
                var validationErrors = athlete.ValidateInput();
                if (validationErrors.Any())
                {
                    DisplayValidationErrors(validationErrors);
                    return;
                }

                using var db = new JudoContext();
                db.Athletes.Add(athlete);
                await db.SaveChangesAsync();

                lblOutput.Text = $"Athlete saved successfully with Id: {athlete.Id}\n" + athlete.GenerateItemizedReport();
                MessageBox.Show("Athlete saved successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to save athlete: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Athlete CreateAthleteFromInput()
        {
            var athlete = new Athlete();

            // Parse athlete name
            athlete.Name = txtAthleteName.Text.Trim();

            

            // Parse training plan (remove emoji from text)
            var trainingText = cmbTrainingPlan.Text;
            if (trainingText.Contains("Beginner"))
                athlete.TrainingPlan = TrainingPlan.Beginner;
            else if (trainingText.Contains("Intermediate"))
                athlete.TrainingPlan = TrainingPlan.Intermediate;
            else if (trainingText.Contains("Elite"))
                athlete.TrainingPlan = TrainingPlan.Elite;

            // Parse current weight
            if (double.TryParse(txtCurrentWeight.Text, out var weight))
            {
                athlete.CurrentWeight = weight;
            }

            // Parse competition category (extract category name from display text with emojis)
            var categoryText = cmbCompetitionCategory.Text;
            if (categoryText.Contains("Flyweight"))
                athlete.CompetitionCategory = WeightCategory.Flyweight;
            else if (categoryText.Contains("Lightweight"))
                athlete.CompetitionCategory = WeightCategory.Lightweight;
            else if (categoryText.Contains("Light Middleweight"))
                athlete.CompetitionCategory = WeightCategory.LightMiddleweight;
            else if (categoryText.Contains("Middleweight"))
                athlete.CompetitionCategory = WeightCategory.Middleweight;
            else if (categoryText.Contains("Light Heavyweight"))
                athlete.CompetitionCategory = WeightCategory.LightHeavyweight;
            else if (categoryText.Contains("Heavyweight"))
                athlete.CompetitionCategory = WeightCategory.Heavyweight;

            // Parse competitions (only for Intermediate and Elite)
            if (int.TryParse(txtCompetitions.Text, out var competitions))
            {
                athlete.CompetitionsThisMonth = competitions;
            }

            // Parse private coaching hours
            if (double.TryParse(txtPrivateHours.Text, out var privateHours))
            {
                athlete.PrivateCoachingHours = privateHours;
            }

            return athlete;
        }

        private void TxtCurrentWeight_TextChanged(object? sender, EventArgs e)
        {
            UpdateWeightComparison();
        }

        private void CmbCompetitionCategory_SelectedIndexChanged(object? sender, EventArgs e)
        {
            UpdateWeightComparison();
        }

        private void UpdateWeightComparison()
        {
            if (double.TryParse(txtCurrentWeight.Text, out var weight) && cmbCompetitionCategory.SelectedIndex >= 0)
            {
                var categoryText = cmbCompetitionCategory.Text;
                WeightCategory category = WeightCategory.Flyweight;

                if (categoryText.Contains("Flyweight"))
                    category = WeightCategory.Flyweight;
                else if (categoryText.Contains("Lightweight"))
                    category = WeightCategory.Lightweight;
                else if (categoryText.Contains("Light Middleweight"))
                    category = WeightCategory.LightMiddleweight;
                else if (categoryText.Contains("Middleweight"))
                    category = WeightCategory.Middleweight;
                else if (categoryText.Contains("Light Heavyweight"))
                    category = WeightCategory.LightHeavyweight;
                else if (categoryText.Contains("Heavyweight"))
                    category = WeightCategory.Heavyweight;

                var status = WeightCategoryExtensions.GetWeightStatus(weight, category);
                var (min, max) = category.GetWeightRange();
                var rangeText = max == double.MaxValue ? $"≥{min}kg" : $"{min}-{max}kg";

                lblWeightInfo.Text = $"⚖️ Weight: {weight:F1}kg | 🏆 Category: {category} ({rangeText}) | 📊 Status: {status}";
            }
            else
            {
                lblWeightInfo.Text = "📊 Enter weight and select category to see comparison";
            }
        }

        private void DisplayValidationErrors(List<string> errors)
        {
            var errorMessage = new StringBuilder();
            errorMessage.AppendLine("Please fix the following errors:");
            errorMessage.AppendLine();

            foreach (var error in errors)
            {
                errorMessage.AppendLine($"• {error}");
            }

            lblOutput.Text = errorMessage.ToString();
        }

        private void txtAthleteName_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtCompetitions_TextChanged(object? sender, EventArgs e)
        {
            // Real-time validation for competitions
            if (int.TryParse(txtCompetitions.Text, out var competitions))
            {
                if (competitions < 0)
                {
                    txtCompetitions.Text = "0";
                    txtCompetitions.SelectionStart = txtCompetitions.Text.Length;
                }
            }
        }

        private void txtPrivateHours_TextChanged(object sender, EventArgs e)
        {
            // Real-time validation for private coaching hours
            if (double.TryParse(txtPrivateHours.Text, out var hours))
            {
                if (hours > 20) // 5 hours per week * 4 weeks = 20 hours per month
                {
                    txtPrivateHours.Text = "20";
                    txtPrivateHours.SelectionStart = txtPrivateHours.Text.Length;
                    MessageBox.Show("Maximum 5 hours per week (20 hours per month) allowed!", "Input Restriction", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (hours < 0)
                {
                    txtPrivateHours.Text = "0";
                    txtPrivateHours.SelectionStart = txtPrivateHours.Text.Length;
                }
            }
        }

        private void lblCompetitionInfo_Click(object sender, EventArgs e)
        {

        }

        private void txtCompetitions_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
