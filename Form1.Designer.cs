namespace Prac1._6_MakingDecisions_45312222
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
            this.lblHeading = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.chkCSharp = new System.Windows.Forms.CheckBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkCpp = new System.Windows.Forms.CheckBox();
            this.chkVB = new System.Windows.Forms.CheckBox();
            this.chkJava = new System.Windows.Forms.CheckBox();
            this.chkDatabase = new System.Windows.Forms.CheckBox();
            this.lblLevelofstudy = new System.Windows.Forms.Label();
            this.rbFirstYear = new System.Windows.Forms.RadioButton();
            this.rbSecondYear = new System.Windows.Forms.RadioButton();
            this.rbThirdYear = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.Location = new System.Drawing.Point(526, 9);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(368, 32);
            this.lblHeading.TabIndex = 0;
            this.lblHeading.Text = "Computer Science Course";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(629, 73);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(169, 22);
            this.txtFirstName.TabIndex = 1;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(629, 127);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(169, 22);
            this.txtLastName.TabIndex = 2;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(497, 79);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(69, 16);
            this.lblFirstName.TabIndex = 3;
            this.lblFirstName.Text = "FirstName";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(497, 133);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(69, 16);
            this.lblLastName.TabIndex = 4;
            this.lblLastName.Text = "LastName";
            // 
            // chkCSharp
            // 
            this.chkCSharp.AutoSize = true;
            this.chkCSharp.Location = new System.Drawing.Point(29, 31);
            this.chkCSharp.Name = "chkCSharp";
            this.chkCSharp.Size = new System.Drawing.Size(45, 20);
            this.chkCSharp.TabIndex = 6;
            this.chkCSharp.Text = "C#";
            this.chkCSharp.UseVisualStyleBackColor = true;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(448, 442);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(104, 23);
            this.btnCalculate.TabIndex = 7;
            this.btnCalculate.Text = "Total Cost";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(649, 442);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(847, 442);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkDatabase);
            this.groupBox1.Controls.Add(this.chkJava);
            this.groupBox1.Controls.Add(this.chkVB);
            this.groupBox1.Controls.Add(this.chkCpp);
            this.groupBox1.Controls.Add(this.chkCSharp);
            this.groupBox1.Location = new System.Drawing.Point(544, 236);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(302, 172);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Modules";
            // 
            // chkCpp
            // 
            this.chkCpp.AutoSize = true;
            this.chkCpp.Location = new System.Drawing.Point(29, 57);
            this.chkCpp.Name = "chkCpp";
            this.chkCpp.Size = new System.Drawing.Size(52, 20);
            this.chkCpp.TabIndex = 7;
            this.chkCpp.Text = "C++";
            this.chkCpp.UseVisualStyleBackColor = true;
            // 
            // chkVB
            // 
            this.chkVB.AutoSize = true;
            this.chkVB.Location = new System.Drawing.Point(29, 83);
            this.chkVB.Name = "chkVB";
            this.chkVB.Size = new System.Drawing.Size(103, 20);
            this.chkVB.TabIndex = 8;
            this.chkVB.Text = "Visual Basic";
            this.chkVB.UseVisualStyleBackColor = true;
            // 
            // chkJava
            // 
            this.chkJava.AutoSize = true;
            this.chkJava.Location = new System.Drawing.Point(29, 110);
            this.chkJava.Name = "chkJava";
            this.chkJava.Size = new System.Drawing.Size(59, 20);
            this.chkJava.TabIndex = 9;
            this.chkJava.Text = "Java";
            this.chkJava.UseVisualStyleBackColor = true;
            // 
            // chkDatabase
            // 
            this.chkDatabase.AutoSize = true;
            this.chkDatabase.Location = new System.Drawing.Point(29, 137);
            this.chkDatabase.Name = "chkDatabase";
            this.chkDatabase.Size = new System.Drawing.Size(89, 20);
            this.chkDatabase.TabIndex = 10;
            this.chkDatabase.Text = "Database";
            this.chkDatabase.UseVisualStyleBackColor = true;
            // 
            // lblLevelofstudy
            // 
            this.lblLevelofstudy.AutoSize = true;
            this.lblLevelofstudy.Location = new System.Drawing.Point(383, 191);
            this.lblLevelofstudy.Name = "lblLevelofstudy";
            this.lblLevelofstudy.Size = new System.Drawing.Size(89, 16);
            this.lblLevelofstudy.TabIndex = 11;
            this.lblLevelofstudy.Text = "Level of study";
            // 
            // rbFirstYear
            // 
            this.rbFirstYear.AutoSize = true;
            this.rbFirstYear.Location = new System.Drawing.Point(532, 191);
            this.rbFirstYear.Name = "rbFirstYear";
            this.rbFirstYear.Size = new System.Drawing.Size(83, 20);
            this.rbFirstYear.TabIndex = 12;
            this.rbFirstYear.TabStop = true;
            this.rbFirstYear.Text = "First year";
            this.rbFirstYear.UseVisualStyleBackColor = true;
            // 
            // rbSecondYear
            // 
            this.rbSecondYear.AutoSize = true;
            this.rbSecondYear.Location = new System.Drawing.Point(691, 191);
            this.rbSecondYear.Name = "rbSecondYear";
            this.rbSecondYear.Size = new System.Drawing.Size(107, 20);
            this.rbSecondYear.TabIndex = 13;
            this.rbSecondYear.TabStop = true;
            this.rbSecondYear.Text = "Second Year";
            this.rbSecondYear.UseVisualStyleBackColor = true;
            // 
            // rbThirdYear
            // 
            this.rbThirdYear.AutoSize = true;
            this.rbThirdYear.Location = new System.Drawing.Point(871, 191);
            this.rbThirdYear.Name = "rbThirdYear";
            this.rbThirdYear.Size = new System.Drawing.Size(91, 20);
            this.rbThirdYear.TabIndex = 14;
            this.rbThirdYear.TabStop = true;
            this.rbThirdYear.Text = "Third Year";
            this.rbThirdYear.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1340, 502);
            this.Controls.Add(this.rbThirdYear);
            this.Controls.Add(this.rbSecondYear);
            this.Controls.Add(this.rbFirstYear);
            this.Controls.Add(this.lblLevelofstudy);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblHeading);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.CheckBox chkCSharp;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkDatabase;
        private System.Windows.Forms.CheckBox chkJava;
        private System.Windows.Forms.CheckBox chkVB;
        private System.Windows.Forms.CheckBox chkCpp;
        private System.Windows.Forms.Label lblLevelofstudy;
        private System.Windows.Forms.RadioButton rbFirstYear;
        private System.Windows.Forms.RadioButton rbSecondYear;
        private System.Windows.Forms.RadioButton rbThirdYear;
    }
}

