namespace WinFormsApp5
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ReadtextBox = new TextBox();
            TimezonecomboBox = new ComboBox();
            label15 = new Label();
            button1 = new Button();
            MomcomboBox = new ComboBox();
            CoachcomboBox = new ComboBox();
            SGcomboBox = new ComboBox();
            CcomboBox = new ComboBox();
            PFcomboBox = new ComboBox();
            SFcomboBox = new ComboBox();
            PGcomboBox = new ComboBox();
            label14 = new Label();
            label8 = new Label();
            label9 = new Label();
            label7 = new Label();
            label4 = new Label();
            label5 = new Label();
            label3 = new Label();
            CitytextBox = new TextBox();
            label2 = new Label();
            TeamtextBox = new TextBox();
            label1 = new Label();
            BasecomboBox = new ComboBox();
            SuspendLayout();
            // 
            // ReadtextBox
            // 
            ReadtextBox.Location = new Point(32, 164);
            ReadtextBox.Multiline = true;
            ReadtextBox.Name = "ReadtextBox";
            ReadtextBox.ReadOnly = true;
            ReadtextBox.Size = new Size(213, 224);
            ReadtextBox.TabIndex = 69;
            // 
            // TimezonecomboBox
            // 
            TimezonecomboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            TimezonecomboBox.Enabled = false;
            TimezonecomboBox.FormattingEnabled = true;
            TimezonecomboBox.Items.AddRange(new object[] { "Atlantic", "Central", "Mountain", "Pacific" });
            TimezonecomboBox.Location = new Point(373, 92);
            TimezonecomboBox.Name = "TimezonecomboBox";
            TimezonecomboBox.Size = new Size(116, 23);
            TimezonecomboBox.TabIndex = 68;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(288, 95);
            label15.Name = "label15";
            label15.Size = new Size(58, 15);
            label15.TabIndex = 67;
            label15.Text = "Timezone";
            // 
            // button1
            // 
            button1.Location = new Point(527, 210);
            button1.Name = "button1";
            button1.Size = new Size(134, 42);
            button1.TabIndex = 66;
            button1.Text = "Save Changes";
            button1.UseVisualStyleBackColor = true;
            button1.Visible = false;
            button1.Click += button1_Click_1;
            // 
            // MomcomboBox
            // 
            MomcomboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            MomcomboBox.Enabled = false;
            MomcomboBox.FormattingEnabled = true;
            MomcomboBox.Items.AddRange(new object[] { "Very Good", "Good", "Neutral", "Bad", "Low" });
            MomcomboBox.Location = new Point(403, 365);
            MomcomboBox.Name = "MomcomboBox";
            MomcomboBox.Size = new Size(74, 23);
            MomcomboBox.TabIndex = 65;
            // 
            // CoachcomboBox
            // 
            CoachcomboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            CoachcomboBox.Enabled = false;
            CoachcomboBox.FormattingEnabled = true;
            CoachcomboBox.Items.AddRange(new object[] { "A+", "A", "A-", "B+", "B", "B-", "C+", "C", "C-", "D+", "D", "D-", "F" });
            CoachcomboBox.Location = new Point(387, 126);
            CoachcomboBox.Name = "CoachcomboBox";
            CoachcomboBox.Size = new Size(47, 23);
            CoachcomboBox.TabIndex = 64;
            // 
            // SGcomboBox
            // 
            SGcomboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            SGcomboBox.Enabled = false;
            SGcomboBox.FormattingEnabled = true;
            SGcomboBox.Items.AddRange(new object[] { "A+", "A", "A-", "B+", "B", "B-", "C+", "C", "C-", "D+", "D", "D-", "F" });
            SGcomboBox.Location = new Point(387, 205);
            SGcomboBox.Name = "SGcomboBox";
            SGcomboBox.Size = new Size(47, 23);
            SGcomboBox.TabIndex = 63;
            // 
            // CcomboBox
            // 
            CcomboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            CcomboBox.Enabled = false;
            CcomboBox.FormattingEnabled = true;
            CcomboBox.Items.AddRange(new object[] { "A+", "A", "A-", "B+", "B", "B-", "C+", "C", "C-", "D+", "D", "D-", "F" });
            CcomboBox.Location = new Point(387, 323);
            CcomboBox.Name = "CcomboBox";
            CcomboBox.Size = new Size(47, 23);
            CcomboBox.TabIndex = 62;
            // 
            // PFcomboBox
            // 
            PFcomboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            PFcomboBox.Enabled = false;
            PFcomboBox.FormattingEnabled = true;
            PFcomboBox.Items.AddRange(new object[] { "A+", "A", "A-", "B+", "B", "B-", "C+", "C", "C-", "D+", "D", "D-", "F" });
            PFcomboBox.Location = new Point(387, 285);
            PFcomboBox.Name = "PFcomboBox";
            PFcomboBox.Size = new Size(47, 23);
            PFcomboBox.TabIndex = 61;
            // 
            // SFcomboBox
            // 
            SFcomboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            SFcomboBox.Enabled = false;
            SFcomboBox.FormattingEnabled = true;
            SFcomboBox.Items.AddRange(new object[] { "A+", "A", "A-", "B+", "B", "B-", "C+", "C", "C-", "D+", "D", "D-", "F" });
            SFcomboBox.Location = new Point(387, 247);
            SFcomboBox.Name = "SFcomboBox";
            SFcomboBox.Size = new Size(47, 23);
            SFcomboBox.TabIndex = 60;
            // 
            // PGcomboBox
            // 
            PGcomboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            PGcomboBox.Enabled = false;
            PGcomboBox.FormattingEnabled = true;
            PGcomboBox.Items.AddRange(new object[] { "A+", "A", "A-", "B+", "B", "B-", "C+", "C", "C-", "D+", "D", "D-", "F" });
            PGcomboBox.Location = new Point(387, 164);
            PGcomboBox.Name = "PGcomboBox";
            PGcomboBox.Size = new Size(47, 23);
            PGcomboBox.TabIndex = 59;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(329, 134);
            label14.Name = "label14";
            label14.Size = new Size(41, 15);
            label14.TabIndex = 58;
            label14.Text = "Coach";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(348, 331);
            label8.Name = "label8";
            label8.Size = new Size(15, 15);
            label8.TabIndex = 57;
            label8.Text = "C";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(346, 293);
            label9.Name = "label9";
            label9.Size = new Size(20, 15);
            label9.TabIndex = 56;
            label9.Text = "PF";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(346, 252);
            label7.Name = "label7";
            label7.Size = new Size(19, 15);
            label7.TabIndex = 55;
            label7.Text = "SF";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(348, 210);
            label4.Name = "label4";
            label4.Size = new Size(21, 15);
            label4.TabIndex = 54;
            label4.Text = "SG";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(348, 167);
            label5.Name = "label5";
            label5.Size = new Size(22, 15);
            label5.TabIndex = 53;
            label5.Text = "PG";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(317, 368);
            label3.Name = "label3";
            label3.Size = new Size(71, 15);
            label3.TabIndex = 52;
            label3.Text = "Momentum";
            // 
            // CitytextBox
            // 
            CitytextBox.Enabled = false;
            CitytextBox.Location = new Point(373, 48);
            CitytextBox.Name = "CitytextBox";
            CitytextBox.Size = new Size(104, 23);
            CitytextBox.TabIndex = 51;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(288, 56);
            label2.Name = "label2";
            label2.Size = new Size(28, 15);
            label2.TabIndex = 50;
            label2.Text = "City";
            // 
            // TeamtextBox
            // 
            TeamtextBox.Enabled = false;
            TeamtextBox.Location = new Point(373, 4);
            TeamtextBox.Name = "TeamtextBox";
            TeamtextBox.Size = new Size(104, 23);
            TeamtextBox.TabIndex = 49;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(288, 12);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 48;
            label1.Text = "Team Name";
            // 
            // BasecomboBox
            // 
            BasecomboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            BasecomboBox.FormattingEnabled = true;
            BasecomboBox.Location = new Point(32, 12);
            BasecomboBox.Name = "BasecomboBox";
            BasecomboBox.Size = new Size(146, 23);
            BasecomboBox.TabIndex = 47;
            BasecomboBox.SelectedIndexChanged += BasecomboBox_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(679, 425);
            Controls.Add(ReadtextBox);
            Controls.Add(TimezonecomboBox);
            Controls.Add(label15);
            Controls.Add(button1);
            Controls.Add(MomcomboBox);
            Controls.Add(CoachcomboBox);
            Controls.Add(SGcomboBox);
            Controls.Add(CcomboBox);
            Controls.Add(PFcomboBox);
            Controls.Add(SFcomboBox);
            Controls.Add(PGcomboBox);
            Controls.Add(label14);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(CitytextBox);
            Controls.Add(label2);
            Controls.Add(TeamtextBox);
            Controls.Add(label1);
            Controls.Add(BasecomboBox);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox ReadtextBox;
        private ComboBox TimezonecomboBox;
        private Label label15;
        private Button button1;
        private ComboBox MomcomboBox;
        private ComboBox CoachcomboBox;
        private ComboBox SGcomboBox;
        private ComboBox CcomboBox;
        private ComboBox PFcomboBox;
        private ComboBox SFcomboBox;
        private ComboBox PGcomboBox;
        private Label label14;
        private Label label8;
        private Label label9;
        private Label label7;
        private Label label4;
        private Label label5;
        private Label label3;
        private TextBox CitytextBox;
        private Label label2;
        private TextBox TeamtextBox;
        private Label label1;
        private ComboBox BasecomboBox;
    }
}