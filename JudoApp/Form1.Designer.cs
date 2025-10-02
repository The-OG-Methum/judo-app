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
            lblAthleteName.Location = new Point(30, 69);
            lblAthleteName.Name = "lblAthleteName";
            lblAthleteName.Size = new Size(129, 19);
            lblAthleteName.TabIndex = 0;
            lblAthleteName.Text = "\U0001f94b Athlete Name:";
            // 
            // txtAthleteName
            // 
            txtAthleteName.BackColor = Color.FromArgb(60, 60, 65);
            txtAthleteName.BorderStyle = BorderStyle.FixedSingle;
            txtAthleteName.Font = new Font("Segoe UI", 9F);
            txtAthleteName.ForeColor = Color.White;
            txtAthleteName.Location = new Point(263, 69);
            txtAthleteName.Name = "txtAthleteName";
            txtAthleteName.Size = new Size(250, 23);
            txtAthleteName.TabIndex = 1;
            txtAthleteName.TextChanged += txtAthleteName_TextChanged;
            // 
            // lblTrainingPlan
            // 
            lblTrainingPlan.AutoSize = true;
            lblTrainingPlan.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTrainingPlan.ForeColor = Color.White;
            lblTrainingPlan.Location = new Point(30, 139);
            lblTrainingPlan.Name = "lblTrainingPlan";
            lblTrainingPlan.Size = new Size(124, 19);
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
            cmbTrainingPlan.Location = new Point(263, 135);
            cmbTrainingPlan.Name = "cmbTrainingPlan";
            cmbTrainingPlan.Size = new Size(250, 23);
            cmbTrainingPlan.TabIndex = 3;
            // 
            // lblCurrentWeight
            // 
            lblCurrentWeight.AutoSize = true;
            lblCurrentWeight.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblCurrentWeight.ForeColor = Color.White;
            lblCurrentWeight.Location = new Point(30, 174);
            lblCurrentWeight.Name = "lblCurrentWeight";
            lblCurrentWeight.Size = new Size(170, 19);
            lblCurrentWeight.TabIndex = 4;
            lblCurrentWeight.Text = "⚖️ Current Weight (kg):";
            // 
            // txtCurrentWeight
            // 
            txtCurrentWeight.BackColor = Color.FromArgb(60, 60, 65);
            txtCurrentWeight.BorderStyle = BorderStyle.FixedSingle;
            txtCurrentWeight.Font = new Font("Segoe UI", 9F);
            txtCurrentWeight.ForeColor = Color.White;
            txtCurrentWeight.Location = new Point(263, 174);
            txtCurrentWeight.Name = "txtCurrentWeight";
            txtCurrentWeight.Size = new Size(250, 23);
            txtCurrentWeight.TabIndex = 5;
            // 
            // lblCompetitionCategory
            // 
            lblCompetitionCategory.AutoSize = true;
            lblCompetitionCategory.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblCompetitionCategory.ForeColor = Color.White;
            lblCompetitionCategory.Location = new Point(30, 217);
            lblCompetitionCategory.Name = "lblCompetitionCategory";
            lblCompetitionCategory.Size = new Size(187, 19);
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
            cmbCompetitionCategory.Items.AddRange(new object[] { "\U0001f94a Flyweight (≤60kg)", "\U0001f94a Lightweight (60-66kg)", "\U0001f94a Light Middleweight (66-73kg)", "\U0001f94a Middleweight (73-81kg)", "\U0001f94a Light Heavyweight (81-90kg)", "\U0001f94a Heavyweight (≥90kg)" });
            cmbCompetitionCategory.Location = new Point(263, 217);
            cmbCompetitionCategory.Name = "cmbCompetitionCategory";
            cmbCompetitionCategory.Size = new Size(250, 23);
            cmbCompetitionCategory.TabIndex = 7;
            // 
            // lblCompetitions
            // 
            lblCompetitions.AutoSize = true;
            lblCompetitions.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblCompetitions.ForeColor = Color.White;
            lblCompetitions.Location = new Point(30, 257);
            lblCompetitions.Name = "lblCompetitions";
            lblCompetitions.Size = new Size(200, 19);
            lblCompetitions.TabIndex = 8;
            lblCompetitions.Text = "🏅 Competitions this month:";
            // 
            // txtCompetitions
            // 
            txtCompetitions.BackColor = Color.FromArgb(60, 60, 65);
            txtCompetitions.BorderStyle = BorderStyle.FixedSingle;
            txtCompetitions.Font = new Font("Segoe UI", 9F);
            txtCompetitions.ForeColor = Color.White;
            txtCompetitions.Location = new Point(263, 257);
            txtCompetitions.Name = "txtCompetitions";
            txtCompetitions.Size = new Size(250, 23);
            txtCompetitions.TabIndex = 9;
            // 
            // lblPrivateHours
            // 
            lblPrivateHours.AutoSize = true;
            lblPrivateHours.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblPrivateHours.ForeColor = Color.White;
            lblPrivateHours.Location = new Point(30, 295);
            lblPrivateHours.Name = "lblPrivateHours";
            lblPrivateHours.Size = new Size(195, 19);
            lblPrivateHours.TabIndex = 10;
            lblPrivateHours.Text = "👨‍🏫 Private Coaching Hours:";
            // 
            // txtPrivateHours
            // 
            txtPrivateHours.BackColor = Color.FromArgb(60, 60, 65);
            txtPrivateHours.BorderStyle = BorderStyle.FixedSingle;
            txtPrivateHours.Font = new Font("Segoe UI", 9F);
            txtPrivateHours.ForeColor = Color.White;
            txtPrivateHours.Location = new Point(263, 295);
            txtPrivateHours.Name = "txtPrivateHours";
            txtPrivateHours.Size = new Size(250, 23);
            txtPrivateHours.TabIndex = 11;
            txtPrivateHours.TextChanged += txtPrivateHours_TextChanged;
            // 
            // lblPrivateCoachingInfo
            // 
            lblPrivateCoachingInfo.AutoSize = true;
            lblPrivateCoachingInfo.Font = new Font("Segoe UI", 8F, FontStyle.Italic);
            lblPrivateCoachingInfo.ForeColor = Color.FromArgb(100, 200, 255);
            lblPrivateCoachingInfo.Location = new Point(544, 301);
            lblPrivateCoachingInfo.Name = "lblPrivateCoachingInfo";
            lblPrivateCoachingInfo.Size = new Size(253, 13);
            lblPrivateCoachingInfo.TabIndex = 13;
            lblPrivateCoachingInfo.Text = "⚠️ Maximum 5 hours per week (20 hours per month)";
            // 
            
            // 
            // lblCompetitionInfo
            // 
            lblCompetitionInfo.AutoSize = true;
            lblCompetitionInfo.Font = new Font("Segoe UI", 8F, FontStyle.Italic);
            lblCompetitionInfo.ForeColor = Color.FromArgb(100, 255, 100);
            lblCompetitionInfo.Location = new Point(544, 245);
            lblCompetitionInfo.Name = "lblCompetitionInfo";
            lblCompetitionInfo.Size = new Size(302, 13);
            lblCompetitionInfo.TabIndex = 12;
            lblCompetitionInfo.Text = "ℹ️ Only Intermediate and Elite athletes can enter competitions";
            // 
            // lblWeightInfo
            // 
            lblWeightInfo.AutoSize = true;
            lblWeightInfo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblWeightInfo.ForeColor = Color.FromArgb(255, 200, 100);
            lblWeightInfo.Location = new Point(30, 340);
            lblWeightInfo.Name = "lblWeightInfo";
            lblWeightInfo.Size = new Size(310, 15);
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
            btnCalculate.Location = new Point(380, 369);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(180, 51);
            btnCalculate.TabIndex = 15;
            btnCalculate.Text = "\U0001f9ee Calculate Fees";
            btnCalculate.UseVisualStyleBackColor = false;
            btnCalculate.Click += BtnCalculate_Click;
            // 
            
            // 
            // lblOutput
            // 
            lblOutput.BackColor = Color.FromArgb(30, 30, 35);
            lblOutput.BorderStyle = BorderStyle.FixedSingle;
            lblOutput.Font = new Font("Consolas", 10F);
            lblOutput.ForeColor = Color.FromArgb(200, 200, 200);
            lblOutput.Location = new Point(30, 438);
            lblOutput.Name = "lblOutput";
            lblOutput.Padding = new Padding(15);
            lblOutput.Size = new Size(1000, 305);
            lblOutput.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(365, 9);
            label1.Name = "label1";
            label1.Size = new Size(481, 37);
            label1.TabIndex = 25;
            label1.Text = "KickBlast Judo Tranning Fees Calculator";
            label1.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(45, 45, 48);
            ClientSize = new Size(1100, 750);
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
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "\U0001f94b Kickblast Judo Fees Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label1;
    }
}
