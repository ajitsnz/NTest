namespace BMIForms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code


        private void InitializeComponent()
        {
            this.lblYourName = new System.Windows.Forms.Label();
            this.txtYourNameInput = new System.Windows.Forms.TextBox();
            this.lblHeight = new System.Windows.Forms.Label();
            this.txtHeightInput = new System.Windows.Forms.TextBox();
            this.lblWeight = new System.Windows.Forms.Label();
            this.txtWeightInput = new System.Windows.Forms.TextBox();
            this.grpUnit = new System.Windows.Forms.GroupBox();
            this.rdbUSUnitInput = new System.Windows.Forms.RadioButton();
            this.rdbMetricUnitInput = new System.Windows.Forms.RadioButton();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.grpResults = new System.Windows.Forms.GroupBox();
            this.lblNormalWeightDisplay = new System.Windows.Forms.Label();
            this.lblBMIMessageOutput = new System.Windows.Forms.Label();
            this.lblWeightCategoryOutput = new System.Windows.Forms.Label();
            this.lblWeightCategory = new System.Windows.Forms.Label();
            this.lblBMIOutput = new System.Windows.Forms.Label();
            this.lblYourBMI = new System.Windows.Forms.Label();
            this.lblHeightFt = new System.Windows.Forms.Label();
            this.txtHeightInches = new System.Windows.Forms.TextBox();
            this.lblHeightIn = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.grpUnit.SuspendLayout();
            this.grpResults.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblYourName
            // 
            this.lblYourName.AutoSize = true;
            this.lblYourName.Location = new System.Drawing.Point(12, 24);
            this.lblYourName.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblYourName.Name = "lblYourName";
            this.lblYourName.Size = new System.Drawing.Size(45, 15);
            this.lblYourName.TabIndex = 0;
            this.lblYourName.Text = "Name :";
            // 
            // txtYourNameInput
            // 
            this.txtYourNameInput.Location = new System.Drawing.Point(83, 24);
            this.txtYourNameInput.Margin = new System.Windows.Forms.Padding(1);
            this.txtYourNameInput.Name = "txtYourNameInput";
            this.txtYourNameInput.Size = new System.Drawing.Size(263, 23);
            this.txtYourNameInput.TabIndex = 1;
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(11, 81);
            this.lblHeight.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(46, 15);
            this.lblHeight.TabIndex = 2;
            this.lblHeight.Text = "Height:";
            // 
            // txtHeightInput
            // 
            this.txtHeightInput.Location = new System.Drawing.Point(87, 78);
            this.txtHeightInput.Margin = new System.Windows.Forms.Padding(1);
            this.txtHeightInput.Name = "txtHeightInput";
            this.txtHeightInput.Size = new System.Drawing.Size(32, 23);
            this.txtHeightInput.TabIndex = 4;
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Location = new System.Drawing.Point(11, 113);
            this.lblWeight.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(48, 15);
            this.lblWeight.TabIndex = 4;
            this.lblWeight.Text = "Weight:";
            // 
            // txtWeightInput
            // 
            this.txtWeightInput.Location = new System.Drawing.Point(87, 110);
            this.txtWeightInput.Margin = new System.Windows.Forms.Padding(1);
            this.txtWeightInput.Name = "txtWeightInput";
            this.txtWeightInput.Size = new System.Drawing.Size(81, 23);
            this.txtWeightInput.TabIndex = 6;
            // 
            // grpUnit
            // 
            this.grpUnit.Controls.Add(this.rdbUSUnitInput);
            this.grpUnit.Controls.Add(this.rdbMetricUnitInput);
            this.grpUnit.Location = new System.Drawing.Point(196, 66);
            this.grpUnit.Margin = new System.Windows.Forms.Padding(1);
            this.grpUnit.Name = "grpUnit";
            this.grpUnit.Padding = new System.Windows.Forms.Padding(1);
            this.grpUnit.Size = new System.Drawing.Size(150, 77);
            this.grpUnit.TabIndex = 2;
            this.grpUnit.TabStop = false;
            this.grpUnit.Text = "Unit";
            // 
            // rdbUSUnitInput
            // 
            this.rdbUSUnitInput.AutoSize = true;
            this.rdbUSUnitInput.Checked = true;
            this.rdbUSUnitInput.Location = new System.Drawing.Point(9, 52);
            this.rdbUSUnitInput.Margin = new System.Windows.Forms.Padding(1);
            this.rdbUSUnitInput.Name = "rdbUSUnitInput";
            this.rdbUSUnitInput.Size = new System.Drawing.Size(118, 19);
            this.rdbUSUnitInput.TabIndex = 3;
            this.rdbUSUnitInput.TabStop = true;
            this.rdbUSUnitInput.Text = "US Unit (foot, lbs)";
            this.rdbUSUnitInput.UseVisualStyleBackColor = true;
            this.rdbUSUnitInput.CheckedChanged += new System.EventHandler(this.rdbUSUnitInput_CheckedChanged);
            // 
            // rdbMetricUnitInput
            // 
            this.rdbMetricUnitInput.AutoSize = true;
            this.rdbMetricUnitInput.Location = new System.Drawing.Point(9, 22);
            this.rdbMetricUnitInput.Margin = new System.Windows.Forms.Padding(1);
            this.rdbMetricUnitInput.Name = "rdbMetricUnitInput";
            this.rdbMetricUnitInput.Size = new System.Drawing.Size(128, 19);
            this.rdbMetricUnitInput.TabIndex = 2;
            this.rdbMetricUnitInput.TabStop = true;
            this.rdbMetricUnitInput.Text = "Metric Unit (kg cm)";
            this.rdbMetricUnitInput.UseVisualStyleBackColor = true;
            this.rdbMetricUnitInput.CheckedChanged += new System.EventHandler(this.rdbMetricUnitInput_CheckedChanged);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(83, 154);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(1);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(98, 35);
            this.btnCalculate.TabIndex = 7;
            this.btnCalculate.Text = "Calculate BMI";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // grpResults
            // 
            this.grpResults.Controls.Add(this.lblNormalWeightDisplay);
            this.grpResults.Controls.Add(this.lblBMIMessageOutput);
            this.grpResults.Controls.Add(this.lblWeightCategoryOutput);
            this.grpResults.Controls.Add(this.lblWeightCategory);
            this.grpResults.Controls.Add(this.lblBMIOutput);
            this.grpResults.Controls.Add(this.lblYourBMI);
            this.grpResults.Location = new System.Drawing.Point(21, 218);
            this.grpResults.Margin = new System.Windows.Forms.Padding(1);
            this.grpResults.Name = "grpResults";
            this.grpResults.Padding = new System.Windows.Forms.Padding(1);
            this.grpResults.Size = new System.Drawing.Size(445, 223);
            this.grpResults.TabIndex = 8;
            this.grpResults.TabStop = false;
            this.grpResults.Text = "Results for";
            // 
            // lblNormalWeightDisplay
            // 
            this.lblNormalWeightDisplay.AutoSize = true;
            this.lblNormalWeightDisplay.ForeColor = System.Drawing.Color.Green;
            this.lblNormalWeightDisplay.Location = new System.Drawing.Point(10, 125);
            this.lblNormalWeightDisplay.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblNormalWeightDisplay.Name = "lblNormalWeightDisplay";
            this.lblNormalWeightDisplay.Size = new System.Drawing.Size(150, 15);
            this.lblNormalWeightDisplay.TabIndex = 5;
            this.lblNormalWeightDisplay.Text = "Your Ideal Weight Range is:";
            // 
            // lblBMIMessageOutput
            // 
            this.lblBMIMessageOutput.AutoSize = true;
            this.lblBMIMessageOutput.Location = new System.Drawing.Point(8, 96);
            this.lblBMIMessageOutput.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblBMIMessageOutput.Name = "lblBMIMessageOutput";
            this.lblBMIMessageOutput.Size = new System.Drawing.Size(207, 15);
            this.lblBMIMessageOutput.TabIndex = 4;
            this.lblBMIMessageOutput.Text = "Normal BMI is between 18.50 and 24.9";
            // 
            // lblWeightCategoryOutput
            // 
            this.lblWeightCategoryOutput.AutoSize = true;
            this.lblWeightCategoryOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblWeightCategoryOutput.Location = new System.Drawing.Point(108, 67);
            this.lblWeightCategoryOutput.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblWeightCategoryOutput.Name = "lblWeightCategoryOutput";
            this.lblWeightCategoryOutput.Size = new System.Drawing.Size(139, 17);
            this.lblWeightCategoryOutput.TabIndex = 3;
            this.lblWeightCategoryOutput.Text = "Your Weight Category Is:";
            // 
            // lblWeightCategory
            // 
            this.lblWeightCategory.AutoSize = true;
            this.lblWeightCategory.Location = new System.Drawing.Point(7, 66);
            this.lblWeightCategory.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblWeightCategory.Name = "lblWeightCategory";
            this.lblWeightCategory.Size = new System.Drawing.Size(99, 15);
            this.lblWeightCategory.TabIndex = 2;
            this.lblWeightCategory.Text = "Weight Category:";
            // 
            // lblBMIOutput
            // 
            this.lblBMIOutput.AutoSize = true;
            this.lblBMIOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBMIOutput.Location = new System.Drawing.Point(108, 37);
            this.lblBMIOutput.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblBMIOutput.Name = "lblBMIOutput";
            this.lblBMIOutput.Size = new System.Drawing.Size(74, 24);
            this.lblBMIOutput.TabIndex = 1;
            this.lblBMIOutput.Text = "BMI Output ";
            this.lblBMIOutput.UseCompatibleTextRendering = true;
            // 
            // lblYourBMI
            // 
            this.lblYourBMI.AutoSize = true;
            this.lblYourBMI.Location = new System.Drawing.Point(36, 39);
            this.lblYourBMI.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblYourBMI.Name = "lblYourBMI";
            this.lblYourBMI.Size = new System.Drawing.Size(69, 15);
            this.lblYourBMI.TabIndex = 0;
            this.lblYourBMI.Text = "Your BMI is ";
            // 
            // lblHeightFt
            // 
            this.lblHeightFt.AutoSize = true;
            this.lblHeightFt.Location = new System.Drawing.Point(122, 81);
            this.lblHeightFt.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblHeightFt.Name = "lblHeightFt";
            this.lblHeightFt.Size = new System.Drawing.Size(15, 15);
            this.lblHeightFt.TabIndex = 9;
            this.lblHeightFt.Text = "ft";
            // 
            // txtHeightInches
            // 
            this.txtHeightInches.Location = new System.Drawing.Point(137, 78);
            this.txtHeightInches.Margin = new System.Windows.Forms.Padding(1);
            this.txtHeightInches.Name = "txtHeightInches";
            this.txtHeightInches.Size = new System.Drawing.Size(31, 23);
            this.txtHeightInches.TabIndex = 5;
            // 
            // lblHeightIn
            // 
            this.lblHeightIn.AutoSize = true;
            this.lblHeightIn.Location = new System.Drawing.Point(172, 80);
            this.lblHeightIn.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblHeightIn.Name = "lblHeightIn";
            this.lblHeightIn.Size = new System.Drawing.Size(17, 15);
            this.lblHeightIn.TabIndex = 11;
            this.lblHeightIn.Text = "in";
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(201, 154);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(94, 35);
            this.clearButton.TabIndex = 12;
            this.clearButton.Text = "Reset";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(492, 466);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.lblHeightIn);
            this.Controls.Add(this.txtHeightInches);
            this.Controls.Add(this.lblHeightFt);
            this.Controls.Add(this.grpResults);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.grpUnit);
            this.Controls.Add(this.txtWeightInput);
            this.Controls.Add(this.lblWeight);
            this.Controls.Add(this.txtHeightInput);
            this.Controls.Add(this.lblHeight);
            this.Controls.Add(this.txtYourNameInput);
            this.Controls.Add(this.lblYourName);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "MainForm";
            this.Text = "Nuance Test - BMI";
            this.grpUnit.ResumeLayout(false);
            this.grpUnit.PerformLayout();
            this.grpResults.ResumeLayout(false);
            this.grpResults.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblYourName;
        private System.Windows.Forms.TextBox txtYourNameInput;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.TextBox txtHeightInput;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.TextBox txtWeightInput;
        private System.Windows.Forms.GroupBox grpUnit;
        private System.Windows.Forms.RadioButton rdbUSUnitInput;
        private System.Windows.Forms.RadioButton rdbMetricUnitInput;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.GroupBox grpResults;
        private System.Windows.Forms.Label lblWeightCategoryOutput;
        private System.Windows.Forms.Label lblWeightCategory;
        private System.Windows.Forms.Label lblBMIOutput;
        private System.Windows.Forms.Label lblYourBMI;
        private System.Windows.Forms.Label lblHeightFt;
        private System.Windows.Forms.TextBox txtHeightInches;
        private System.Windows.Forms.Label lblHeightIn;
        private System.Windows.Forms.Label lblNormalWeightDisplay;
        private System.Windows.Forms.Label lblBMIMessageOutput;
        private System.Windows.Forms.Button clearButton;
    }
}

