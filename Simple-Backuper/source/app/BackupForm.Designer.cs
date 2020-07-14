﻿namespace Simple_Backuper.app
{
    partial class BackupForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BackupForm));
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAddBackup = new System.Windows.Forms.Button();
            this.numericUpDownBackupsAmount = new System.Windows.Forms.NumericUpDown();
            this.checkBoxBackupsAmount = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelAmount = new System.Windows.Forms.Label();
            this.panelBackupsAmount = new System.Windows.Forms.Panel();
            this.panelTimer = new System.Windows.Forms.Panel();
            this.checkBoxTimer = new System.Windows.Forms.CheckBox();
            this.numericUpDownTimer = new System.Windows.Forms.NumericUpDown();
            this.labelTimer = new System.Windows.Forms.Label();
            this.panelOptions = new System.Windows.Forms.Panel();
            this.buttonStartBackuping = new System.Windows.Forms.Button();
            this.buttonStopBackuping = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.Main = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBoxBackups = new System.Windows.Forms.ComboBox();
            this.panelControls = new System.Windows.Forms.Panel();
            this.Backups = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxBackupsManaging = new System.Windows.Forms.ComboBox();
            this.panelBackupManage = new System.Windows.Forms.Panel();
            this.buttonCreateBackupStamp = new System.Windows.Forms.Button();
            this.listViewBackups = new System.Windows.Forms.ListView();
            this.buttonReplaceSourceWithStamp = new System.Windows.Forms.Button();
            this.buttonDeleteBackupStamp = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.Settings = new System.Windows.Forms.TabPage();
            this.panelStartWithWindow = new System.Windows.Forms.Panel();
            this.checkBoxAutoStart = new System.Windows.Forms.CheckBox();
            this.labelBoot = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBackupsAmount)).BeginInit();
            this.panelBackupsAmount.SuspendLayout();
            this.panelTimer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTimer)).BeginInit();
            this.panelOptions.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.Main.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelControls.SuspendLayout();
            this.Backups.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelBackupManage.SuspendLayout();
            this.Settings.SuspendLayout();
            this.panelStartWithWindow.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Backups";
            // 
            // buttonAddBackup
            // 
            this.buttonAddBackup.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonAddBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddBackup.Font = new System.Drawing.Font("Open Sans Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddBackup.Location = new System.Drawing.Point(313, 30);
            this.buttonAddBackup.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonAddBackup.Name = "buttonAddBackup";
            this.buttonAddBackup.Size = new System.Drawing.Size(107, 38);
            this.buttonAddBackup.TabIndex = 2;
            this.buttonAddBackup.Text = "Add Backup";
            this.buttonAddBackup.UseVisualStyleBackColor = false;
            this.buttonAddBackup.Click += new System.EventHandler(this.ButtonAddBackup_Click);
            // 
            // numericUpDownBackupsAmount
            // 
            this.numericUpDownBackupsAmount.Enabled = false;
            this.numericUpDownBackupsAmount.Location = new System.Drawing.Point(296, 23);
            this.numericUpDownBackupsAmount.Name = "numericUpDownBackupsAmount";
            this.numericUpDownBackupsAmount.Size = new System.Drawing.Size(101, 31);
            this.numericUpDownBackupsAmount.TabIndex = 0;
            this.numericUpDownBackupsAmount.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownBackupsAmount.ValueChanged += new System.EventHandler(this.NumericUpDowns_ValueChanged);
            // 
            // checkBoxBackupsAmount
            // 
            this.checkBoxBackupsAmount.AutoSize = true;
            this.checkBoxBackupsAmount.Location = new System.Drawing.Point(3, 3);
            this.checkBoxBackupsAmount.Name = "checkBoxBackupsAmount";
            this.checkBoxBackupsAmount.Size = new System.Drawing.Size(278, 27);
            this.checkBoxBackupsAmount.TabIndex = 2;
            this.checkBoxBackupsAmount.Text = "Custom Backup Stamps Amount";
            this.checkBoxBackupsAmount.UseVisualStyleBackColor = true;
            this.checkBoxBackupsAmount.CheckedChanged += new System.EventHandler(this.CheckBoxBackupsAmount_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Options";
            // 
            // labelAmount
            // 
            this.labelAmount.AutoSize = true;
            this.labelAmount.Enabled = false;
            this.labelAmount.Font = new System.Drawing.Font("Open Sans Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAmount.Location = new System.Drawing.Point(23, 31);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(263, 23);
            this.labelAmount.TabIndex = 4;
            this.labelAmount.Text = "Choose new max stamps amount";
            // 
            // panelBackupsAmount
            // 
            this.panelBackupsAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBackupsAmount.Controls.Add(this.checkBoxBackupsAmount);
            this.panelBackupsAmount.Controls.Add(this.numericUpDownBackupsAmount);
            this.panelBackupsAmount.Controls.Add(this.labelAmount);
            this.panelBackupsAmount.Location = new System.Drawing.Point(0, 35);
            this.panelBackupsAmount.Name = "panelBackupsAmount";
            this.panelBackupsAmount.Size = new System.Drawing.Size(412, 64);
            this.panelBackupsAmount.TabIndex = 6;
            // 
            // panelTimer
            // 
            this.panelTimer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTimer.Controls.Add(this.checkBoxTimer);
            this.panelTimer.Controls.Add(this.numericUpDownTimer);
            this.panelTimer.Controls.Add(this.labelTimer);
            this.panelTimer.Location = new System.Drawing.Point(0, 105);
            this.panelTimer.Name = "panelTimer";
            this.panelTimer.Size = new System.Drawing.Size(412, 64);
            this.panelTimer.TabIndex = 7;
            // 
            // checkBoxTimer
            // 
            this.checkBoxTimer.AutoSize = true;
            this.checkBoxTimer.Location = new System.Drawing.Point(3, 3);
            this.checkBoxTimer.Name = "checkBoxTimer";
            this.checkBoxTimer.Size = new System.Drawing.Size(136, 27);
            this.checkBoxTimer.TabIndex = 2;
            this.checkBoxTimer.Text = "Backup Timer";
            this.checkBoxTimer.UseVisualStyleBackColor = true;
            this.checkBoxTimer.CheckedChanged += new System.EventHandler(this.CheckBoxTimer_CheckedChanged);
            // 
            // numericUpDownTimer
            // 
            this.numericUpDownTimer.Enabled = false;
            this.numericUpDownTimer.Location = new System.Drawing.Point(296, 23);
            this.numericUpDownTimer.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownTimer.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownTimer.Name = "numericUpDownTimer";
            this.numericUpDownTimer.Size = new System.Drawing.Size(101, 31);
            this.numericUpDownTimer.TabIndex = 0;
            this.numericUpDownTimer.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numericUpDownTimer.ValueChanged += new System.EventHandler(this.NumericUpDowns_ValueChanged);
            // 
            // labelTimer
            // 
            this.labelTimer.AutoSize = true;
            this.labelTimer.Enabled = false;
            this.labelTimer.Font = new System.Drawing.Font("Open Sans Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTimer.Location = new System.Drawing.Point(23, 31);
            this.labelTimer.Name = "labelTimer";
            this.labelTimer.Size = new System.Drawing.Size(233, 23);
            this.labelTimer.TabIndex = 4;
            this.labelTimer.Text = "Choose timer delay (minutes)";
            // 
            // panelOptions
            // 
            this.panelOptions.Controls.Add(this.label3);
            this.panelOptions.Controls.Add(this.panelTimer);
            this.panelOptions.Controls.Add(this.panelBackupsAmount);
            this.panelOptions.Enabled = false;
            this.panelOptions.Location = new System.Drawing.Point(8, 74);
            this.panelOptions.Name = "panelOptions";
            this.panelOptions.Size = new System.Drawing.Size(412, 174);
            this.panelOptions.TabIndex = 8;
            // 
            // buttonStartBackuping
            // 
            this.buttonStartBackuping.Enabled = false;
            this.buttonStartBackuping.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStartBackuping.Font = new System.Drawing.Font("Open Sans Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStartBackuping.Location = new System.Drawing.Point(0, 31);
            this.buttonStartBackuping.Name = "buttonStartBackuping";
            this.buttonStartBackuping.Size = new System.Drawing.Size(201, 45);
            this.buttonStartBackuping.TabIndex = 10;
            this.buttonStartBackuping.Text = "Start Backuping";
            this.buttonStartBackuping.UseVisualStyleBackColor = true;
            this.buttonStartBackuping.Click += new System.EventHandler(this.ButtonStartBackuping_Click);
            // 
            // buttonStopBackuping
            // 
            this.buttonStopBackuping.Enabled = false;
            this.buttonStopBackuping.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStopBackuping.Font = new System.Drawing.Font("Open Sans Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStopBackuping.Location = new System.Drawing.Point(200, 31);
            this.buttonStopBackuping.Name = "buttonStopBackuping";
            this.buttonStopBackuping.Size = new System.Drawing.Size(212, 45);
            this.buttonStopBackuping.TabIndex = 11;
            this.buttonStopBackuping.Text = "Stop Backuping";
            this.buttonStopBackuping.UseVisualStyleBackColor = true;
            this.buttonStopBackuping.Click += new System.EventHandler(this.ButtonStopBackuping_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 23);
            this.label7.TabIndex = 12;
            this.label7.Text = "Controls";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.Main);
            this.tabControl.Controls.Add(this.Backups);
            this.tabControl.Controls.Add(this.Settings);
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(438, 500);
            this.tabControl.TabIndex = 13;
            // 
            // Main
            // 
            this.Main.Controls.Add(this.panel2);
            this.Main.Controls.Add(this.panelControls);
            this.Main.Controls.Add(this.label1);
            this.Main.Controls.Add(this.buttonAddBackup);
            this.Main.Controls.Add(this.panelOptions);
            this.Main.Location = new System.Drawing.Point(4, 32);
            this.Main.Name = "Main";
            this.Main.Padding = new System.Windows.Forms.Padding(3);
            this.Main.Size = new System.Drawing.Size(430, 464);
            this.Main.TabIndex = 0;
            this.Main.Text = "Main";
            this.Main.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.comboBoxBackups);
            this.panel2.Location = new System.Drawing.Point(8, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(308, 38);
            this.panel2.TabIndex = 15;
            // 
            // comboBoxBackups
            // 
            this.comboBoxBackups.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBackups.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxBackups.FormattingEnabled = true;
            this.comboBoxBackups.Location = new System.Drawing.Point(3, 3);
            this.comboBoxBackups.Name = "comboBoxBackups";
            this.comboBoxBackups.Size = new System.Drawing.Size(300, 31);
            this.comboBoxBackups.TabIndex = 14;
            this.comboBoxBackups.SelectedIndexChanged += new System.EventHandler(this.ComboBoxBackups_SelectedIndexChanged);
            // 
            // panelControls
            // 
            this.panelControls.Controls.Add(this.label7);
            this.panelControls.Controls.Add(this.buttonStartBackuping);
            this.panelControls.Controls.Add(this.buttonStopBackuping);
            this.panelControls.Enabled = false;
            this.panelControls.Location = new System.Drawing.Point(8, 372);
            this.panelControls.Name = "panelControls";
            this.panelControls.Size = new System.Drawing.Size(412, 83);
            this.panelControls.TabIndex = 13;
            // 
            // Backups
            // 
            this.Backups.Controls.Add(this.panel1);
            this.Backups.Controls.Add(this.panelBackupManage);
            this.Backups.Controls.Add(this.label8);
            this.Backups.Location = new System.Drawing.Point(4, 32);
            this.Backups.Name = "Backups";
            this.Backups.Padding = new System.Windows.Forms.Padding(3);
            this.Backups.Size = new System.Drawing.Size(430, 464);
            this.Backups.TabIndex = 1;
            this.Backups.Text = "Backups";
            this.Backups.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.comboBoxBackupsManaging);
            this.panel1.Location = new System.Drawing.Point(144, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(254, 38);
            this.panel1.TabIndex = 6;
            // 
            // comboBoxBackupsManaging
            // 
            this.comboBoxBackupsManaging.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.comboBoxBackupsManaging.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBackupsManaging.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxBackupsManaging.FormattingEnabled = true;
            this.comboBoxBackupsManaging.Location = new System.Drawing.Point(-1, 3);
            this.comboBoxBackupsManaging.Name = "comboBoxBackupsManaging";
            this.comboBoxBackupsManaging.Size = new System.Drawing.Size(254, 31);
            this.comboBoxBackupsManaging.TabIndex = 1;
            this.comboBoxBackupsManaging.SelectedValueChanged += new System.EventHandler(this.ComboBoxBackupsManaging_SelectedValueChanged);
            // 
            // panelBackupManage
            // 
            this.panelBackupManage.Controls.Add(this.buttonCreateBackupStamp);
            this.panelBackupManage.Controls.Add(this.listViewBackups);
            this.panelBackupManage.Controls.Add(this.buttonReplaceSourceWithStamp);
            this.panelBackupManage.Controls.Add(this.buttonDeleteBackupStamp);
            this.panelBackupManage.Enabled = false;
            this.panelBackupManage.Location = new System.Drawing.Point(31, 42);
            this.panelBackupManage.Name = "panelBackupManage";
            this.panelBackupManage.Size = new System.Drawing.Size(381, 426);
            this.panelBackupManage.TabIndex = 5;
            // 
            // buttonCreateBackupStamp
            // 
            this.buttonCreateBackupStamp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCreateBackupStamp.Font = new System.Drawing.Font("Open Sans Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCreateBackupStamp.Location = new System.Drawing.Point(0, 378);
            this.buttonCreateBackupStamp.Name = "buttonCreateBackupStamp";
            this.buttonCreateBackupStamp.Size = new System.Drawing.Size(125, 36);
            this.buttonCreateBackupStamp.TabIndex = 10;
            this.buttonCreateBackupStamp.Text = "Create";
            this.buttonCreateBackupStamp.UseVisualStyleBackColor = true;
            this.buttonCreateBackupStamp.Click += new System.EventHandler(this.ButtonCreateBackupStamp_Click);
            // 
            // listViewBackups
            // 
            this.listViewBackups.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.listViewBackups.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listViewBackups.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewBackups.HideSelection = false;
            this.listViewBackups.Location = new System.Drawing.Point(0, 8);
            this.listViewBackups.MultiSelect = false;
            this.listViewBackups.Name = "listViewBackups";
            this.listViewBackups.Size = new System.Drawing.Size(367, 364);
            this.listViewBackups.TabIndex = 2;
            this.listViewBackups.TileSize = new System.Drawing.Size(328, 50);
            this.listViewBackups.UseCompatibleStateImageBehavior = false;
            this.listViewBackups.View = System.Windows.Forms.View.SmallIcon;
            // 
            // buttonReplaceSourceWithStamp
            // 
            this.buttonReplaceSourceWithStamp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReplaceSourceWithStamp.Font = new System.Drawing.Font("Open Sans Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonReplaceSourceWithStamp.Location = new System.Drawing.Point(246, 378);
            this.buttonReplaceSourceWithStamp.Name = "buttonReplaceSourceWithStamp";
            this.buttonReplaceSourceWithStamp.Size = new System.Drawing.Size(121, 36);
            this.buttonReplaceSourceWithStamp.TabIndex = 4;
            this.buttonReplaceSourceWithStamp.Text = "Replace";
            this.buttonReplaceSourceWithStamp.UseVisualStyleBackColor = true;
            this.buttonReplaceSourceWithStamp.Click += new System.EventHandler(this.ButtonReplaceSourceWithStamp_Click);
            // 
            // buttonDeleteBackupStamp
            // 
            this.buttonDeleteBackupStamp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteBackupStamp.Font = new System.Drawing.Font("Open Sans Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDeleteBackupStamp.Location = new System.Drawing.Point(123, 378);
            this.buttonDeleteBackupStamp.Name = "buttonDeleteBackupStamp";
            this.buttonDeleteBackupStamp.Size = new System.Drawing.Size(124, 36);
            this.buttonDeleteBackupStamp.TabIndex = 3;
            this.buttonDeleteBackupStamp.Text = "Delete";
            this.buttonDeleteBackupStamp.UseVisualStyleBackColor = true;
            this.buttonDeleteBackupStamp.Click += new System.EventHandler(this.ButtonDeleteBackupStamp_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 23);
            this.label8.TabIndex = 0;
            this.label8.Text = "Select Backup";
            // 
            // Settings
            // 
            this.Settings.Controls.Add(this.panelStartWithWindow);
            this.Settings.Location = new System.Drawing.Point(4, 32);
            this.Settings.Name = "Settings";
            this.Settings.Padding = new System.Windows.Forms.Padding(3);
            this.Settings.Size = new System.Drawing.Size(430, 464);
            this.Settings.TabIndex = 2;
            this.Settings.Text = "Settings";
            this.Settings.UseVisualStyleBackColor = true;
            // 
            // panelStartWithWindow
            // 
            this.panelStartWithWindow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelStartWithWindow.Controls.Add(this.checkBoxAutoStart);
            this.panelStartWithWindow.Controls.Add(this.labelBoot);
            this.panelStartWithWindow.Location = new System.Drawing.Point(8, 6);
            this.panelStartWithWindow.Name = "panelStartWithWindow";
            this.panelStartWithWindow.Size = new System.Drawing.Size(412, 64);
            this.panelStartWithWindow.TabIndex = 9;
            // 
            // checkBoxAutoStart
            // 
            this.checkBoxAutoStart.AutoSize = true;
            this.checkBoxAutoStart.Location = new System.Drawing.Point(3, 3);
            this.checkBoxAutoStart.Name = "checkBoxAutoStart";
            this.checkBoxAutoStart.Size = new System.Drawing.Size(181, 27);
            this.checkBoxAutoStart.TabIndex = 2;
            this.checkBoxAutoStart.Text = "Start With Windows";
            this.checkBoxAutoStart.UseVisualStyleBackColor = true;
            this.checkBoxAutoStart.CheckedChanged += new System.EventHandler(this.CheckBoxAutoStart_CheckedChanged);
            // 
            // labelBoot
            // 
            this.labelBoot.AutoSize = true;
            this.labelBoot.Enabled = false;
            this.labelBoot.Font = new System.Drawing.Font("Open Sans Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBoot.Location = new System.Drawing.Point(23, 31);
            this.labelBoot.Name = "labelBoot";
            this.labelBoot.Size = new System.Drawing.Size(323, 23);
            this.labelBoot.TabIndex = 4;
            this.labelBoot.Text = "The application starts with Windows boot";
            // 
            // BackupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(436, 496);
            this.Controls.Add(this.tabControl);
            this.Font = new System.Drawing.Font("Open Sans Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "BackupForm";
            this.Text = "Simple Backuper";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BackupForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBackupsAmount)).EndInit();
            this.panelBackupsAmount.ResumeLayout(false);
            this.panelBackupsAmount.PerformLayout();
            this.panelTimer.ResumeLayout(false);
            this.panelTimer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTimer)).EndInit();
            this.panelOptions.ResumeLayout(false);
            this.panelOptions.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.Main.ResumeLayout(false);
            this.Main.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panelControls.ResumeLayout(false);
            this.panelControls.PerformLayout();
            this.Backups.ResumeLayout(false);
            this.Backups.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panelBackupManage.ResumeLayout(false);
            this.Settings.ResumeLayout(false);
            this.panelStartWithWindow.ResumeLayout(false);
            this.panelStartWithWindow.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAddBackup;
        private System.Windows.Forms.NumericUpDown numericUpDownBackupsAmount;
        private System.Windows.Forms.CheckBox checkBoxBackupsAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelAmount;
        private System.Windows.Forms.Panel panelBackupsAmount;
        private System.Windows.Forms.Panel panelTimer;
        private System.Windows.Forms.CheckBox checkBoxTimer;
        private System.Windows.Forms.NumericUpDown numericUpDownTimer;
        private System.Windows.Forms.Label labelTimer;
        private System.Windows.Forms.Panel panelOptions;
        private System.Windows.Forms.Button buttonStartBackuping;
        private System.Windows.Forms.Button buttonStopBackuping;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage Main;
        private System.Windows.Forms.TabPage Backups;
        private System.Windows.Forms.Panel panelControls;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxBackupsManaging;
        private System.Windows.Forms.ListView listViewBackups;
        private System.Windows.Forms.Button buttonReplaceSourceWithStamp;
        private System.Windows.Forms.Button buttonDeleteBackupStamp;
        private System.Windows.Forms.Panel panelBackupManage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabPage Settings;
        private System.Windows.Forms.Panel panelStartWithWindow;
        private System.Windows.Forms.CheckBox checkBoxAutoStart;
        private System.Windows.Forms.Label labelBoot;
        private System.Windows.Forms.ComboBox comboBoxBackups;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonCreateBackupStamp;
    }
}

