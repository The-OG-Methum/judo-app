namespace JudoApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        // GUI controls
        private System.Windows.Forms.Label lblAthleteName;
        private System.Windows.Forms.TextBox txtAthleteName;

        private System.Windows.Forms.Label lblTrainingPlan;
        private System.Windows.Forms.ComboBox cmbTrainingPlan;

        private System.Windows.Forms.Label lblCurrentWeight;
        private System.Windows.Forms.TextBox txtCurrentWeight;

        private System.Windows.Forms.Label lblCompetitionCategory;
        private System.Windows.Forms.ComboBox cmbCompetitionCategory;

        private System.Windows.Forms.Label lblCompetitions;
        private System.Windows.Forms.TextBox txtCompetitions;

        private System.Windows.Forms.Label lblPrivateHours;
        private System.Windows.Forms.TextBox txtPrivateHours;

        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Label lblWeightInfo;
        private System.Windows.Forms.Label lblCompetitionInfo;
        private System.Windows.Forms.Label lblPrivateCoachingInfo;
        

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblAthleteName = new Label();
            txtAthleteName = new TextBox();
            lblTrainingPlan = new Label();
            cmbTrainingPlan = new ComboBox();
            lblCurrentWeight = new Label();
            txtCurrentWeight = new TextBox();
            lblCompetitionCategory = new Label();
            cmbCompetitionCategory = new ComboBox();
            lblCompetitions = new Label();
            txtCompetitions = new TextBox();
            lblPrivateHours = new Label();
            txtPrivateHours = new TextBox();
            lblPrivateCoachingInfo = new Label();
            lblCompetitionInfo = new Label();
            lblWeightInfo = new Label();
            btnCalculate = new Button();
            lblOutput = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblAthleteName
            // 
            lblAthleteName.AutoSize = true;
            lblAthleteName.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblAthleteName.ForeColor = Color.White;
            lblAthleteName.Location = new Point(34, 92);
            lblAthleteName.Name = "lblAthleteName";
            lblAthleteName.Size = new Size(155, 23);
            lblAthleteName.TabIndex = 0;
            lblAthleteName.Text = "\U0001f94b Athlete Name:";
            // 
            // txtAthleteName
            // 
            txtAthleteName.BackColor = Color.FromArgb(60, 60, 65);
            txtAthleteName.BorderStyle = BorderStyle.FixedSingle;
            txtAthleteName.Font = new Font("Segoe UI", 9F);
            txtAthleteName.ForeColor = Color.White;
            txtAthleteName.Location = new Point(301, 92);
            txtAthleteName.Margin = new Padding(3, 4, 3, 4);
            txtAthleteName.Name = "txtAthleteName";
            txtAthleteName.Size = new Size(285, 27);
            txtAthleteName.TabIndex = 1;
            txtAthleteName.TextChanged += txtAthleteName_TextChanged;
            // 
            // lblTrainingPlan
            // 
            lblTrainingPlan.AutoSize = true;
            lblTrainingPlan.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTrainingPlan.ForeColor = Color.White;
            lblTrainingPlan.Location = new Point(34, 157);
            lblTrainingPlan.Name = "lblTrainingPlan";
            lblTrainingPlan.Size = new Size(149, 23);
            lblTrainingPlan.TabIndex = 2;
            lblTrainingPlan.Text = "📋 Training Plan:";
            // 
            // cmbTrainingPlan
            // 
            cmbTrainingPlan.BackColor = Color.FromArgb(60, 60, 65);
            cmbTrainingPlan.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTrainingPlan.FlatStyle = FlatStyle.Flat;
            cmbTrainingPlan.Font = new Font("Segoe UI", 9F);
            cmbTrainingPlan.ForeColor = Color.White;
            cmbTrainingPlan.Items.AddRange(new object[] { "\U0001f949 Beginner", "\U0001f948 Intermediate", "\U0001f947 Elite" });
            cmbTrainingPlan.Location = new Point(301, 156);
            cmbTrainingPlan.Margin = new Padding(3, 4, 3, 4);
            cmbTrainingPlan.Name = "cmbTrainingPlan";
            cmbTrainingPlan.Size = new Size(285, 28);
            cmbTrainingPlan.TabIndex = 3;
            // 
            // lblCurrentWeight
            // 
            lblCurrentWeight.AutoSize = true;
            lblCurrentWeight.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblCurrentWeight.ForeColor = Color.White;
            lblCurrentWeight.Location = new Point(34, 223);
            lblCurrentWeight.Name = "lblCurrentWeight";
            lblCurrentWeight.Size = new Size(207, 23);
            lblCurrentWeight.TabIndex = 4;
            lblCurrentWeight.Text = "⚖️ Current Weight (kg):";
            // 
            // txtCurrentWeight
            // 
            txtCurrentWeight.BackColor = Color.FromArgb(60, 60, 65);
            txtCurrentWeight.BorderStyle = BorderStyle.FixedSingle;
            txtCurrentWeight.Font = new Font("Segoe UI", 9F);
            txtCurrentWeight.ForeColor = Color.White;
            txtCurrentWeight.Location = new Point(301, 223);
            txtCurrentWeight.Margin = new Padding(3, 4, 3, 4);
            txtCurrentWeight.Name = "txtCurrentWeight";
            txtCurrentWeight.Size = new Size(285, 27);
            txtCurrentWeight.TabIndex = 5;
            // 
            // lblCompetitionCategory
            // 
            lblCompetitionCategory.AutoSize = true;
            lblCompetitionCategory.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblCompetitionCategory.ForeColor = Color.White;
            lblCompetitionCategory.Location = new Point(34, 289);
            lblCompetitionCategory.Name = "lblCompetitionCategory";
            lblCompetitionCategory.Size = new Size(224, 23);
            lblCompetitionCategory.TabIndex = 6;
            lblCompetitionCategory.Text = "🏆 Competition Category:";
            // 
            // cmbCompetitionCategory
            // 
            cmbCompetitionCategory.BackColor = Color.FromArgb(60, 60, 65);
            cmbCompetitionCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCompetitionCategory.FlatStyle = FlatStyle.Flat;
            cmbCompetitionCategory.Font = new Font("Segoe UI", 9F);
            cmbCompetitionCategory.ForeColor = Color.White;
            cmbCompetitionCategory.Items.AddRange(new object[] { "\U0001f94a Flyweight (66kg)", "\U0001f94a Lightweight (73kg)", "\U0001f94a Light Middleweight (81kg)", "\U0001f94a Middleweight (90kg)", "\U0001f94a Light Heavyweight (100kg)", "\U0001f94a Heavyweight (Unlimited over 100kg)" });
            cmbCompetitionCategory.Location = new Point(301, 289);
            cmbCompetitionCategory.Margin = new Padding(3, 4, 3, 4);
            cmbCompetitionCategory.Name = "cmbCompetitionCategory";
            cmbCompetitionCategory.Size = new Size(285, 28);
            cmbCompetitionCategory.TabIndex = 7;
            cmbCompetitionCategory.SelectedIndexChanged += cmbCompetitionCategory_SelectedIndexChanged_1;
            // 
            // lblCompetitions
            // 
            lblCompetitions.AutoSize = true;
            lblCompetitions.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblCompetitions.ForeColor = Color.White;
            lblCompetitions.Location = new Point(34, 343);
            lblCompetitions.Name = "lblCompetitions";
            lblCompetitions.Size = new Size(244, 23);
            lblCompetitions.TabIndex = 8;
            lblCompetitions.Text = "🏅 Competitions this month:";
            // 
            // txtCompetitions
            // 
            txtCompetitions.BackColor = Color.FromArgb(60, 60, 65);
            txtCompetitions.BorderStyle = BorderStyle.FixedSingle;
            txtCompetitions.Font = new Font("Segoe UI", 9F);
            txtCompetitions.ForeColor = Color.White;
            txtCompetitions.Location = new Point(301, 343);
            txtCompetitions.Margin = new Padding(3, 4, 3, 4);
            txtCompetitions.Name = "txtCompetitions";
            txtCompetitions.Size = new Size(285, 27);
            txtCompetitions.TabIndex = 9;
            // 
            // lblPrivateHours
            // 
            lblPrivateHours.AutoSize = true;
            lblPrivateHours.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblPrivateHours.ForeColor = Color.White;
            lblPrivateHours.Location = new Point(34, 393);
            lblPrivateHours.Name = "lblPrivateHours";
            lblPrivateHours.Size = new Size(231, 23);
            lblPrivateHours.TabIndex = 10;
            lblPrivateHours.Text = "👨‍🏫 Private Coaching Hours:";
            // 
            // txtPrivateHours
            // 
            txtPrivateHours.BackColor = Color.FromArgb(60, 60, 65);
            txtPrivateHours.BorderStyle = BorderStyle.FixedSingle;
            txtPrivateHours.Font = new Font("Segoe UI", 9F);
            txtPrivateHours.ForeColor = Color.White;
            txtPrivateHours.Location = new Point(301, 393);
            txtPrivateHours.Margin = new Padding(3, 4, 3, 4);
            txtPrivateHours.Name = "txtPrivateHours";
            txtPrivateHours.Size = new Size(285, 27);
            txtPrivateHours.TabIndex = 11;
            txtPrivateHours.TextChanged += txtPrivateHours_TextChanged;
            // 
            // lblPrivateCoachingInfo
            // 
            lblPrivateCoachingInfo.AutoSize = true;
            lblPrivateCoachingInfo.Font = new Font("Segoe UI", 8F, FontStyle.Italic);
            lblPrivateCoachingInfo.ForeColor = Color.FromArgb(100, 200, 255);
            lblPrivateCoachingInfo.Location = new Point(622, 401);
            lblPrivateCoachingInfo.Name = "lblPrivateCoachingInfo";
            lblPrivateCoachingInfo.Size = new Size(339, 19);
            lblPrivateCoachingInfo.TabIndex = 13;
            lblPrivateCoachingInfo.Text = "⚠️ Maximum 5 hours per week (20 hours per month)";
            // 
            // lblCompetitionInfo
            // 
            lblCompetitionInfo.AutoSize = true;
            lblCompetitionInfo.Font = new Font("Segoe UI", 8F, FontStyle.Italic);
            lblCompetitionInfo.ForeColor = Color.FromArgb(100, 255, 100);
            lblCompetitionInfo.Location = new Point(622, 327);
            lblCompetitionInfo.Name = "lblCompetitionInfo";
            lblCompetitionInfo.Size = new Size(406, 19);
            lblCompetitionInfo.TabIndex = 12;
            lblCompetitionInfo.Text = "ℹ️ Only Intermediate and Elite athletes can enter competitions";
            // 
            // lblWeightInfo
            // 
            lblWeightInfo.AutoSize = true;
            lblWeightInfo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblWeightInfo.ForeColor = Color.FromArgb(255, 200, 100);
            lblWeightInfo.Location = new Point(34, 453);
            lblWeightInfo.Name = "lblWeightInfo";
            lblWeightInfo.Size = new Size(396, 20);
            lblWeightInfo.TabIndex = 14;
            lblWeightInfo.Text = "📊 Enter weight and select category to see comparison";
            // 
            // btnCalculate
            // 
            btnCalculate.BackColor = Color.FromArgb(0, 150, 255);
            btnCalculate.FlatAppearance.BorderSize = 0;
            btnCalculate.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 120, 200);
            btnCalculate.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 170, 255);
            btnCalculate.FlatStyle = FlatStyle.Flat;
            btnCalculate.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnCalculate.ForeColor = Color.White;
            btnCalculate.Location = new Point(434, 492);
            btnCalculate.Margin = new Padding(3, 4, 3, 4);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(206, 68);
            btnCalculate.TabIndex = 15;
            btnCalculate.Text = "\U0001f9ee Calculate Fees";
            btnCalculate.UseVisualStyleBackColor = false;
            btnCalculate.Click += BtnCalculate_Click;
            // 
            // lblOutput
            // 
            lblOutput.BackColor = Color.FromArgb(30, 30, 35);
            lblOutput.BorderStyle = BorderStyle.FixedSingle;
            lblOutput.Font = new Font("Consolas", 10F);
            lblOutput.ForeColor = Color.FromArgb(200, 200, 200);
            lblOutput.Location = new Point(34, 584);
            lblOutput.Name = "lblOutput";
            lblOutput.Padding = new Padding(17, 20, 17, 20);
            lblOutput.Size = new Size(1143, 406);
            lblOutput.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(417, 12);
            label1.Name = "label1";
            label1.Size = new Size(604, 46);
            label1.TabIndex = 25;
            label1.Text = "KickBlast Judo Tranning Fees Calculator";
            label1.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(45, 45, 48);
            ClientSize = new Size(1299, 1019);
            Controls.Add(label1);
            Controls.Add(lblAthleteName);
            Controls.Add(txtAthleteName);
            Controls.Add(lblTrainingPlan);
            Controls.Add(cmbTrainingPlan);
            Controls.Add(lblCurrentWeight);
            Controls.Add(txtCurrentWeight);
            Controls.Add(lblCompetitionCategory);
            Controls.Add(cmbCompetitionCategory);
            Controls.Add(lblCompetitions);
            Controls.Add(txtCompetitions);
            Controls.Add(lblPrivateHours);
            Controls.Add(txtPrivateHours);
            Controls.Add(lblCompetitionInfo);
            Controls.Add(lblPrivateCoachingInfo);
            Controls.Add(lblWeightInfo);
            Controls.Add(btnCalculate);
            Controls.Add(lblOutput);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "\U0001f94b Kickblast Judo Fees Calculator";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label1;
    }
}
