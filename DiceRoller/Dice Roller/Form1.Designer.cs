using System;

namespace Dice_Roller
{
    partial class Form1
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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnRoll = new System.Windows.Forms.Button();
            this.cbAbility = new System.Windows.Forms.ComboBox();
            this.cbProf = new System.Windows.Forms.ComboBox();
            this.cbBoost = new System.Windows.Forms.ComboBox();
            this.cbDiff = new System.Windows.Forms.ComboBox();
            this.cbChal = new System.Windows.Forms.ComboBox();
            this.cbSetB = new System.Windows.Forms.ComboBox();
            this.lblAbility = new System.Windows.Forms.Label();
            this.lblProf = new System.Windows.Forms.Label();
            this.lblBoost = new System.Windows.Forms.Label();
            this.lblDiff = new System.Windows.Forms.Label();
            this.lblChal = new System.Windows.Forms.Label();
            this.lblSetB = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnProfPlusOne = new System.Windows.Forms.Button();
            this.btnBoostPlusOne = new System.Windows.Forms.Button();
            this.btnDiffPlusOne = new System.Windows.Forms.Button();
            this.btnChalPlusOne = new System.Windows.Forms.Button();
            this.btnSetBackPlusOne = new System.Windows.Forms.Button();
            this.btnAbilityPlusOne = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRoll
            // 
            this.btnRoll.Location = new System.Drawing.Point(86, 185);
            this.btnRoll.Name = "btnRoll";
            this.btnRoll.Size = new System.Drawing.Size(75, 23);
            this.btnRoll.TabIndex = 0;
            this.btnRoll.Text = "Roll!";
            this.btnRoll.UseVisualStyleBackColor = true;
            this.btnRoll.Click += new System.EventHandler(this.Button1_Click);
            // 
            // cbAbility
            // 
            this.cbAbility.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAbility.FormattingEnabled = true;
            this.cbAbility.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cbAbility.Location = new System.Drawing.Point(139, 5);
            this.cbAbility.Name = "cbAbility";
            this.cbAbility.Size = new System.Drawing.Size(38, 21);
            this.cbAbility.TabIndex = 1;
            this.cbAbility.SelectedIndexChanged += new System.EventHandler(this.cbAbility_SelectedIndexChanged);
            // 
            // cbProf
            // 
            this.cbProf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProf.FormattingEnabled = true;
            this.cbProf.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cbProf.Location = new System.Drawing.Point(139, 32);
            this.cbProf.Name = "cbProf";
            this.cbProf.Size = new System.Drawing.Size(38, 21);
            this.cbProf.TabIndex = 1;
            this.cbProf.SelectedIndexChanged += new System.EventHandler(this.cbProf_SelectedIndexChanged);
            // 
            // cbBoost
            // 
            this.cbBoost.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBoost.FormattingEnabled = true;
            this.cbBoost.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cbBoost.Location = new System.Drawing.Point(139, 60);
            this.cbBoost.Name = "cbBoost";
            this.cbBoost.Size = new System.Drawing.Size(38, 21);
            this.cbBoost.TabIndex = 1;
            this.cbBoost.SelectedIndexChanged += new System.EventHandler(this.cbBoost_SelectedIndexChanged);
            // 
            // cbDiff
            // 
            this.cbDiff.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDiff.FormattingEnabled = true;
            this.cbDiff.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cbDiff.Location = new System.Drawing.Point(139, 87);
            this.cbDiff.Name = "cbDiff";
            this.cbDiff.Size = new System.Drawing.Size(38, 21);
            this.cbDiff.TabIndex = 1;
            this.cbDiff.SelectedIndexChanged += new System.EventHandler(this.cbDiff_SelectedIndexChanged);
            // 
            // cbChal
            // 
            this.cbChal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbChal.FormattingEnabled = true;
            this.cbChal.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cbChal.Location = new System.Drawing.Point(139, 114);
            this.cbChal.Name = "cbChal";
            this.cbChal.Size = new System.Drawing.Size(38, 21);
            this.cbChal.TabIndex = 1;
            this.cbChal.SelectedIndexChanged += new System.EventHandler(this.cbChal_SelectedIndexChanged);
            // 
            // cbSetB
            // 
            this.cbSetB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSetB.FormattingEnabled = true;
            this.cbSetB.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cbSetB.Location = new System.Drawing.Point(139, 141);
            this.cbSetB.Name = "cbSetB";
            this.cbSetB.Size = new System.Drawing.Size(38, 21);
            this.cbSetB.TabIndex = 1;
            this.cbSetB.SelectedIndexChanged += new System.EventHandler(this.cbSetB_SelectedIndexChanged);
            // 
            // lblAbility
            // 
            this.lblAbility.AutoSize = true;
            this.lblAbility.Font = new System.Drawing.Font("Cambria", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbility.Location = new System.Drawing.Point(12, 9);
            this.lblAbility.Name = "lblAbility";
            this.lblAbility.Size = new System.Drawing.Size(89, 17);
            this.lblAbility.TabIndex = 2;
            this.lblAbility.Text = "Ability Dice";
            // 
            // lblProf
            // 
            this.lblProf.AutoSize = true;
            this.lblProf.Font = new System.Drawing.Font("Cambria", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProf.Location = new System.Drawing.Point(12, 37);
            this.lblProf.Name = "lblProf";
            this.lblProf.Size = new System.Drawing.Size(121, 17);
            this.lblProf.TabIndex = 2;
            this.lblProf.Text = "Proficiency Dice";
            // 
            // lblBoost
            // 
            this.lblBoost.AutoSize = true;
            this.lblBoost.Font = new System.Drawing.Font("Cambria", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBoost.Location = new System.Drawing.Point(12, 64);
            this.lblBoost.Name = "lblBoost";
            this.lblBoost.Size = new System.Drawing.Size(82, 17);
            this.lblBoost.TabIndex = 2;
            this.lblBoost.Text = "Boost Dice";
            // 
            // lblDiff
            // 
            this.lblDiff.AutoSize = true;
            this.lblDiff.Font = new System.Drawing.Font("Cambria", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiff.Location = new System.Drawing.Point(12, 91);
            this.lblDiff.Name = "lblDiff";
            this.lblDiff.Size = new System.Drawing.Size(107, 17);
            this.lblDiff.TabIndex = 2;
            this.lblDiff.Text = "Difficulty Dice";
            // 
            // lblChal
            // 
            this.lblChal.AutoSize = true;
            this.lblChal.Font = new System.Drawing.Font("Cambria", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChal.Location = new System.Drawing.Point(12, 118);
            this.lblChal.Name = "lblChal";
            this.lblChal.Size = new System.Drawing.Size(111, 17);
            this.lblChal.TabIndex = 2;
            this.lblChal.Text = "Challenge Dice";
            // 
            // lblSetB
            // 
            this.lblSetB.AutoSize = true;
            this.lblSetB.Font = new System.Drawing.Font("Cambria", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSetB.Location = new System.Drawing.Point(12, 145);
            this.lblSetB.Name = "lblSetB";
            this.lblSetB.Size = new System.Drawing.Size(100, 17);
            this.lblSetB.TabIndex = 2;
            this.lblSetB.Text = "Set Back Dice";
            // 
            // txtResult
            // 
            this.txtResult.AcceptsReturn = true;
            this.txtResult.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResult.Location = new System.Drawing.Point(229, 12);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(426, 156);
            this.txtResult.TabIndex = 3;
            // 
            // btnProfPlusOne
            // 
            this.btnProfPlusOne.Location = new System.Drawing.Point(183, 34);
            this.btnProfPlusOne.Name = "btnProfPlusOne";
            this.btnProfPlusOne.Size = new System.Drawing.Size(40, 20);
            this.btnProfPlusOne.TabIndex = 4;
            this.btnProfPlusOne.Text = "+1";
            this.btnProfPlusOne.UseVisualStyleBackColor = true;
            this.btnProfPlusOne.Click += new System.EventHandler(this.btnProfPlusOne_Click);
            // 
            // btnBoostPlusOne
            // 
            this.btnBoostPlusOne.Location = new System.Drawing.Point(183, 61);
            this.btnBoostPlusOne.Name = "btnBoostPlusOne";
            this.btnBoostPlusOne.Size = new System.Drawing.Size(40, 20);
            this.btnBoostPlusOne.TabIndex = 4;
            this.btnBoostPlusOne.Text = "+1";
            this.btnBoostPlusOne.UseVisualStyleBackColor = true;
            this.btnBoostPlusOne.Click += new System.EventHandler(this.btnBoostPlusOne_Click);
            // 
            // btnDiffPlusOne
            // 
            this.btnDiffPlusOne.Location = new System.Drawing.Point(183, 88);
            this.btnDiffPlusOne.Name = "btnDiffPlusOne";
            this.btnDiffPlusOne.Size = new System.Drawing.Size(40, 20);
            this.btnDiffPlusOne.TabIndex = 4;
            this.btnDiffPlusOne.Text = "+1";
            this.btnDiffPlusOne.UseVisualStyleBackColor = true;
            this.btnDiffPlusOne.Click += new System.EventHandler(this.btnDiffPlusOne_Click);
            // 
            // btnChalPlusOne
            // 
            this.btnChalPlusOne.Location = new System.Drawing.Point(183, 115);
            this.btnChalPlusOne.Name = "btnChalPlusOne";
            this.btnChalPlusOne.Size = new System.Drawing.Size(40, 20);
            this.btnChalPlusOne.TabIndex = 4;
            this.btnChalPlusOne.Text = "+1";
            this.btnChalPlusOne.UseVisualStyleBackColor = true;
            this.btnChalPlusOne.Click += new System.EventHandler(this.btnChalPlusOne_Click);
            // 
            // btnSetBackPlusOne
            // 
            this.btnSetBackPlusOne.Location = new System.Drawing.Point(183, 142);
            this.btnSetBackPlusOne.Name = "btnSetBackPlusOne";
            this.btnSetBackPlusOne.Size = new System.Drawing.Size(40, 20);
            this.btnSetBackPlusOne.TabIndex = 4;
            this.btnSetBackPlusOne.Text = "+1";
            this.btnSetBackPlusOne.UseVisualStyleBackColor = true;
            this.btnSetBackPlusOne.Click += new System.EventHandler(this.btnSetBackPlusOne_Click);
            // 
            // btnAbilityPlusOne
            // 
            this.btnAbilityPlusOne.Location = new System.Drawing.Point(183, 6);
            this.btnAbilityPlusOne.Name = "btnAbilityPlusOne";
            this.btnAbilityPlusOne.Size = new System.Drawing.Size(40, 20);
            this.btnAbilityPlusOne.TabIndex = 4;
            this.btnAbilityPlusOne.Text = "+1";
            this.btnAbilityPlusOne.UseVisualStyleBackColor = true;
            this.btnAbilityPlusOne.Click += new System.EventHandler(this.btnAbilityPlusOne_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(671, 221);
            this.Controls.Add(this.btnSetBackPlusOne);
            this.Controls.Add(this.btnChalPlusOne);
            this.Controls.Add(this.btnDiffPlusOne);
            this.Controls.Add(this.btnBoostPlusOne);
            this.Controls.Add(this.btnProfPlusOne);
            this.Controls.Add(this.btnAbilityPlusOne);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.lblSetB);
            this.Controls.Add(this.lblChal);
            this.Controls.Add(this.lblDiff);
            this.Controls.Add(this.lblBoost);
            this.Controls.Add(this.lblProf);
            this.Controls.Add(this.lblAbility);
            this.Controls.Add(this.cbSetB);
            this.Controls.Add(this.cbChal);
            this.Controls.Add(this.cbDiff);
            this.Controls.Add(this.cbBoost);
            this.Controls.Add(this.cbProf);
            this.Controls.Add(this.cbAbility);
            this.Controls.Add(this.btnRoll);
            this.Name = "Form1";
            this.Text = "Dice Roller";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void btnAbilityPlusOne_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnSetBackPlusOne_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnChalPlusOne_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnDiffPlusOne_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnBoostPlusOne_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnProfPlusOne_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void cbSetB_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void cbChal_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void cbDiff_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void cbBoost_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void cbProf_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void cbAbility_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Button btnRoll;
        private System.Windows.Forms.ComboBox cbAbility;
        private System.Windows.Forms.ComboBox cbProf;
        private System.Windows.Forms.ComboBox cbBoost;
        private System.Windows.Forms.ComboBox cbDiff;
        private System.Windows.Forms.ComboBox cbChal;
        private System.Windows.Forms.ComboBox cbSetB;
        private System.Windows.Forms.Label lblAbility;
        private System.Windows.Forms.Label lblProf;
        private System.Windows.Forms.Label lblBoost;
        private System.Windows.Forms.Label lblDiff;
        private System.Windows.Forms.Label lblChal;
        private System.Windows.Forms.Label lblSetB;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnProfPlusOne;
        private System.Windows.Forms.Button btnBoostPlusOne;
        private System.Windows.Forms.Button btnDiffPlusOne;
        private System.Windows.Forms.Button btnChalPlusOne;
        private System.Windows.Forms.Button btnSetBackPlusOne;
        private System.Windows.Forms.Button btnAbilityPlusOne;
    }
}

