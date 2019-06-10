using System;
namespace MSM
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
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.groupsCount = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.vacDays = new MetroFramework.Controls.MetroTextBox();
            this.startedGroup = new MetroFramework.Controls.MetroTextBox();
            this.firstOfAll = new System.Windows.Forms.MonthCalendar();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(196, 333);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(290, 46);
            this.metroButton1.TabIndex = 0;
            this.metroButton1.Text = "Generate Soldier\'s Services Table";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // panel1
            // 
            this.panel1.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.panel1.Controls.Add(this.firstOfAll);
            this.panel1.Controls.Add(this.startedGroup);
            this.panel1.Controls.Add(this.metroLabel4);
            this.panel1.Controls.Add(this.groupsCount);
            this.panel1.Controls.Add(this.metroLabel3);
            this.panel1.Controls.Add(this.metroLabel2);
            this.panel1.Controls.Add(this.metroLabel1);
            this.panel1.Controls.Add(this.vacDays);
            this.panel1.Controls.Add(this.metroButton1);
            this.panel1.Location = new System.Drawing.Point(96, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(743, 406);
            this.panel1.TabIndex = 19;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(31, 151);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(92, 19);
            this.metroLabel4.TabIndex = 7;
            this.metroLabel4.Text = "Started Group";
            // 
            // groupsCount
            // 
            // 
            // 
            // 
            this.groupsCount.CustomButton.Image = null;
            this.groupsCount.CustomButton.Location = new System.Drawing.Point(99, 1);
            this.groupsCount.CustomButton.Name = "";
            this.groupsCount.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.groupsCount.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.groupsCount.CustomButton.TabIndex = 1;
            this.groupsCount.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.groupsCount.CustomButton.UseSelectable = true;
            this.groupsCount.CustomButton.Visible = false;
            this.groupsCount.Lines = new string[] {
        "3"};
            this.groupsCount.Location = new System.Drawing.Point(428, 46);
            this.groupsCount.MaxLength = 32767;
            this.groupsCount.Name = "groupsCount";
            this.groupsCount.PasswordChar = '\0';
            this.groupsCount.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.groupsCount.SelectedText = "";
            this.groupsCount.SelectionLength = 0;
            this.groupsCount.SelectionStart = 0;
            this.groupsCount.ShortcutsEnabled = true;
            this.groupsCount.Size = new System.Drawing.Size(121, 23);
            this.groupsCount.TabIndex = 6;
            this.groupsCount.Text = "3";
            this.groupsCount.UseSelectable = true;
            this.groupsCount.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.groupsCount.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(329, 46);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(87, 19);
            this.metroLabel3.TabIndex = 5;
            this.metroLabel3.Text = "#NO. Groups";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(293, 151);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(123, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "1st Group vacations";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(3, 46);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(120, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "#No Vacation Days";
            // 
            // vacDays
            // 
            // 
            // 
            // 
            this.vacDays.CustomButton.Image = null;
            this.vacDays.CustomButton.Location = new System.Drawing.Point(99, 1);
            this.vacDays.CustomButton.Name = "";
            this.vacDays.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.vacDays.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.vacDays.CustomButton.TabIndex = 1;
            this.vacDays.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.vacDays.CustomButton.UseSelectable = true;
            this.vacDays.CustomButton.Visible = false;
            this.vacDays.Lines = new string[] {
        "7"};
            this.vacDays.Location = new System.Drawing.Point(129, 46);
            this.vacDays.MaxLength = 32767;
            this.vacDays.Name = "vacDays";
            this.vacDays.PasswordChar = '\0';
            this.vacDays.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.vacDays.SelectedText = "";
            this.vacDays.SelectionLength = 0;
            this.vacDays.SelectionStart = 0;
            this.vacDays.ShortcutsEnabled = true;
            this.vacDays.Size = new System.Drawing.Size(121, 23);
            this.vacDays.TabIndex = 1;
            this.vacDays.Text = "7";
            this.vacDays.UseSelectable = true;
            this.vacDays.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.vacDays.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // startedGroup
            // 
            // 
            // 
            // 
            this.startedGroup.CustomButton.Image = null;
            this.startedGroup.CustomButton.Location = new System.Drawing.Point(99, 1);
            this.startedGroup.CustomButton.Name = "";
            this.startedGroup.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.startedGroup.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.startedGroup.CustomButton.TabIndex = 1;
            this.startedGroup.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.startedGroup.CustomButton.UseSelectable = true;
            this.startedGroup.CustomButton.Visible = false;
            this.startedGroup.Lines = new string[] {
        "1"};
            this.startedGroup.Location = new System.Drawing.Point(129, 151);
            this.startedGroup.MaxLength = 32767;
            this.startedGroup.Name = "startedGroup";
            this.startedGroup.PasswordChar = '\0';
            this.startedGroup.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.startedGroup.SelectedText = "";
            this.startedGroup.SelectionLength = 0;
            this.startedGroup.SelectionStart = 0;
            this.startedGroup.ShortcutsEnabled = true;
            this.startedGroup.Size = new System.Drawing.Size(121, 23);
            this.startedGroup.TabIndex = 8;
            this.startedGroup.Text = "1";
            this.startedGroup.UseSelectable = true;
            this.startedGroup.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.startedGroup.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // firstOfAll
            // 
            this.firstOfAll.Location = new System.Drawing.Point(428, 151);
            this.firstOfAll.MaxSelectionCount = 20;
            this.firstOfAll.Name = "firstOfAll";
            this.firstOfAll.SelectionRange = new System.Windows.Forms.SelectionRange(new System.DateTime(2019, 5, 1, 0, 0, 0, 0), new System.DateTime(2019, 5, 3, 0, 0, 0, 0));
            this.firstOfAll.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 547);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Miltary Services Manager";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton metroButton1;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox vacDays;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox groupsCount;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox startedGroup;
        private System.Windows.Forms.MonthCalendar firstOfAll;
    }
}

