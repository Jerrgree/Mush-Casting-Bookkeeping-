﻿namespace Mush_Casting_Analyzer
{
    partial class MasterForm
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
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.directorySelectBTN = new System.Windows.Forms.Button();
            this.directoryPath = new System.Windows.Forms.TextBox();
            this.analyzeFilesBTN = new System.Windows.Forms.Button();
            this.analyzeByDaysRadio = new System.Windows.Forms.RadioButton();
            this.analyzeByIntervalRadio = new System.Windows.Forms.RadioButton();
            this.startDatePicker = new System.Windows.Forms.DateTimePicker();
            this.endDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.IntervalPanel = new System.Windows.Forms.Panel();
            this.NumberOfDaysPanel = new System.Windows.Forms.Panel();
            this.NumberOfDaysEntry = new System.Windows.Forms.NumericUpDown();
            this.TimeZoneDropDown = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.OptionsButton = new System.Windows.Forms.Button();
            this.TimeFormatCheckbox = new System.Windows.Forms.CheckBox();
            this.IntervalPanel.SuspendLayout();
            this.NumberOfDaysPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfDaysEntry)).BeginInit();
            this.SuspendLayout();
            // 
            // directorySelectBTN
            // 
            this.directorySelectBTN.Location = new System.Drawing.Point(12, 12);
            this.directorySelectBTN.Name = "directorySelectBTN";
            this.directorySelectBTN.Size = new System.Drawing.Size(103, 23);
            this.directorySelectBTN.TabIndex = 0;
            this.directorySelectBTN.Text = "Select a Directory";
            this.directorySelectBTN.UseVisualStyleBackColor = true;
            this.directorySelectBTN.Click += new System.EventHandler(this.directorySelectBTN_Click);
            // 
            // directoryPath
            // 
            this.directoryPath.Enabled = false;
            this.directoryPath.Location = new System.Drawing.Point(118, 14);
            this.directoryPath.Name = "directoryPath";
            this.directoryPath.Size = new System.Drawing.Size(164, 20);
            this.directoryPath.TabIndex = 1;
            // 
            // analyzeFilesBTN
            // 
            this.analyzeFilesBTN.Location = new System.Drawing.Point(12, 296);
            this.analyzeFilesBTN.Name = "analyzeFilesBTN";
            this.analyzeFilesBTN.Size = new System.Drawing.Size(136, 23);
            this.analyzeFilesBTN.TabIndex = 2;
            this.analyzeFilesBTN.Text = "Analyze Files";
            this.analyzeFilesBTN.UseVisualStyleBackColor = true;
            this.analyzeFilesBTN.Click += new System.EventHandler(this.analyzeFilesBTN_Click);
            // 
            // analyzeByDaysRadio
            // 
            this.analyzeByDaysRadio.AutoSize = true;
            this.analyzeByDaysRadio.Checked = true;
            this.analyzeByDaysRadio.Location = new System.Drawing.Point(12, 103);
            this.analyzeByDaysRadio.Name = "analyzeByDaysRadio";
            this.analyzeByDaysRadio.Size = new System.Drawing.Size(156, 17);
            this.analyzeByDaysRadio.TabIndex = 3;
            this.analyzeByDaysRadio.TabStop = true;
            this.analyzeByDaysRadio.Text = "Analyze By Number of Days";
            this.analyzeByDaysRadio.UseVisualStyleBackColor = true;
            this.analyzeByDaysRadio.CheckedChanged += new System.EventHandler(this.analyzeByDaysRadio_CheckedChanged);
            // 
            // analyzeByIntervalRadio
            // 
            this.analyzeByIntervalRadio.AutoSize = true;
            this.analyzeByIntervalRadio.Location = new System.Drawing.Point(12, 168);
            this.analyzeByIntervalRadio.Name = "analyzeByIntervalRadio";
            this.analyzeByIntervalRadio.Size = new System.Drawing.Size(141, 17);
            this.analyzeByIntervalRadio.TabIndex = 4;
            this.analyzeByIntervalRadio.Text = "Analyze From an Interval";
            this.analyzeByIntervalRadio.UseVisualStyleBackColor = true;
            // 
            // startDatePicker
            // 
            this.startDatePicker.Location = new System.Drawing.Point(3, 19);
            this.startDatePicker.Name = "startDatePicker";
            this.startDatePicker.Size = new System.Drawing.Size(200, 20);
            this.startDatePicker.TabIndex = 6;
            // 
            // endDatePicker
            // 
            this.endDatePicker.Location = new System.Drawing.Point(3, 64);
            this.endDatePicker.Name = "endDatePicker";
            this.endDatePicker.Size = new System.Drawing.Size(200, 20);
            this.endDatePicker.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Starting On";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Ending On";
            // 
            // IntervalPanel
            // 
            this.IntervalPanel.Controls.Add(this.label2);
            this.IntervalPanel.Controls.Add(this.label1);
            this.IntervalPanel.Controls.Add(this.startDatePicker);
            this.IntervalPanel.Controls.Add(this.endDatePicker);
            this.IntervalPanel.Enabled = false;
            this.IntervalPanel.Location = new System.Drawing.Point(13, 191);
            this.IntervalPanel.Name = "IntervalPanel";
            this.IntervalPanel.Size = new System.Drawing.Size(243, 95);
            this.IntervalPanel.TabIndex = 10;
            // 
            // NumberOfDaysPanel
            // 
            this.NumberOfDaysPanel.Controls.Add(this.NumberOfDaysEntry);
            this.NumberOfDaysPanel.Location = new System.Drawing.Point(12, 126);
            this.NumberOfDaysPanel.Name = "NumberOfDaysPanel";
            this.NumberOfDaysPanel.Size = new System.Drawing.Size(244, 36);
            this.NumberOfDaysPanel.TabIndex = 11;
            // 
            // NumberOfDaysEntry
            // 
            this.NumberOfDaysEntry.Location = new System.Drawing.Point(3, 3);
            this.NumberOfDaysEntry.Name = "NumberOfDaysEntry";
            this.NumberOfDaysEntry.Size = new System.Drawing.Size(120, 20);
            this.NumberOfDaysEntry.TabIndex = 12;
            // 
            // TimeZoneDropDown
            // 
            this.TimeZoneDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TimeZoneDropDown.FormattingEnabled = true;
            this.TimeZoneDropDown.Location = new System.Drawing.Point(12, 76);
            this.TimeZoneDropDown.Name = "TimeZoneDropDown";
            this.TimeZoneDropDown.Size = new System.Drawing.Size(156, 21);
            this.TimeZoneDropDown.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "TimeZone";
            // 
            // OptionsButton
            // 
            this.OptionsButton.Location = new System.Drawing.Point(155, 295);
            this.OptionsButton.Name = "OptionsButton";
            this.OptionsButton.Size = new System.Drawing.Size(75, 23);
            this.OptionsButton.TabIndex = 14;
            this.OptionsButton.Text = "Options";
            this.OptionsButton.UseVisualStyleBackColor = true;
            this.OptionsButton.Click += new System.EventHandler(this.OptionsButton_Click);
            // 
            // TimeFormatCheckbox
            // 
            this.TimeFormatCheckbox.AutoSize = true;
            this.TimeFormatCheckbox.Location = new System.Drawing.Point(175, 76);
            this.TimeFormatCheckbox.Name = "TimeFormatCheckbox";
            this.TimeFormatCheckbox.Size = new System.Drawing.Size(79, 17);
            this.TimeFormatCheckbox.TabIndex = 15;
            this.TimeFormatCheckbox.Text = "24hr Time?";
            this.TimeFormatCheckbox.UseVisualStyleBackColor = true;
            // 
            // MasterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 338);
            this.Controls.Add(this.TimeFormatCheckbox);
            this.Controls.Add(this.OptionsButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TimeZoneDropDown);
            this.Controls.Add(this.analyzeByIntervalRadio);
            this.Controls.Add(this.analyzeByDaysRadio);
            this.Controls.Add(this.NumberOfDaysPanel);
            this.Controls.Add(this.IntervalPanel);
            this.Controls.Add(this.analyzeFilesBTN);
            this.Controls.Add(this.directoryPath);
            this.Controls.Add(this.directorySelectBTN);
            this.Name = "MasterForm";
            this.Text = "Mush Casting Analyzer";
            this.IntervalPanel.ResumeLayout(false);
            this.IntervalPanel.PerformLayout();
            this.NumberOfDaysPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfDaysEntry)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button directorySelectBTN;
        private System.Windows.Forms.TextBox directoryPath;
        private System.Windows.Forms.Button analyzeFilesBTN;
        private System.Windows.Forms.RadioButton analyzeByDaysRadio;
        private System.Windows.Forms.RadioButton analyzeByIntervalRadio;
        private System.Windows.Forms.DateTimePicker startDatePicker;
        private System.Windows.Forms.DateTimePicker endDatePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel IntervalPanel;
        private System.Windows.Forms.Panel NumberOfDaysPanel;
        private System.Windows.Forms.NumericUpDown NumberOfDaysEntry;
        private System.Windows.Forms.ComboBox TimeZoneDropDown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button OptionsButton;
        private System.Windows.Forms.CheckBox TimeFormatCheckbox;
    }
}

