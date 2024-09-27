﻿namespace Builder
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.SelfDelete_Chk = new MetroFramework.Controls.MetroCheckBox();
            this.ObfuscatorChk = new MetroFramework.Controls.MetroCheckBox();
            this.SelectedPath_Box = new System.Windows.Forms.ComboBox();
            this.HideFile_Box = new MetroFramework.Controls.MetroCheckBox();
            this.BuildBtn = new System.Windows.Forms.Button();
            this.SelectFile2 = new MetroFramework.Controls.MetroButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.File2Box = new MetroFramework.Controls.MetroTextBox();
            this.SelectFile1 = new MetroFramework.Controls.MetroButton();
            this.File1Box = new MetroFramework.Controls.MetroTextBox();
            this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AuthorLabel = new System.Windows.Forms.Label();
            this.LabelSupp2 = new System.Windows.Forms.Label();
            this.GitLabel = new System.Windows.Forms.Label();
            this.LabelSupp1 = new System.Windows.Forms.Label();
            this.LabelSupp3 = new System.Windows.Forms.Label();
            this.CreditsLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Builder.Properties.Resources.LogoSoftware;
            this.pictureBox1.Location = new System.Drawing.Point(10, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(105, 59);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage3);
            this.metroTabControl1.Location = new System.Drawing.Point(10, 101);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(456, 286);
            this.metroTabControl1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTabControl1.TabIndex = 1;
            this.metroTabControl1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroTabPage1.Controls.Add(this.SelfDelete_Chk);
            this.metroTabPage1.Controls.Add(this.ObfuscatorChk);
            this.metroTabPage1.Controls.Add(this.SelectedPath_Box);
            this.metroTabPage1.Controls.Add(this.HideFile_Box);
            this.metroTabPage1.Controls.Add(this.BuildBtn);
            this.metroTabPage1.Controls.Add(this.SelectFile2);
            this.metroTabPage1.Controls.Add(this.label2);
            this.metroTabPage1.Controls.Add(this.label1);
            this.metroTabPage1.Controls.Add(this.File2Box);
            this.metroTabPage1.Controls.Add(this.SelectFile1);
            this.metroTabPage1.Controls.Add(this.File1Box);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 35);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(448, 247);
            this.metroTabPage1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Binder";
            this.metroTabPage1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            // 
            // SelfDelete_Chk
            // 
            this.SelfDelete_Chk.Appearance = System.Windows.Forms.Appearance.Button;
            this.SelfDelete_Chk.AutoSize = true;
            this.SelfDelete_Chk.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SelfDelete_Chk.ForeColor = System.Drawing.Color.Cyan;
            this.SelfDelete_Chk.Location = new System.Drawing.Point(5, 180);
            this.SelfDelete_Chk.Name = "SelfDelete_Chk";
            this.SelfDelete_Chk.Size = new System.Drawing.Size(78, 15);
            this.SelfDelete_Chk.Style = MetroFramework.MetroColorStyle.Blue;
            this.SelfDelete_Chk.TabIndex = 13;
            this.SelfDelete_Chk.Text = "Self Delete";
            this.SelfDelete_Chk.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.SelfDelete_Chk.UseVisualStyleBackColor = true;
            // 
            // ObfuscatorChk
            // 
            this.ObfuscatorChk.Appearance = System.Windows.Forms.Appearance.Button;
            this.ObfuscatorChk.AutoSize = true;
            this.ObfuscatorChk.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ObfuscatorChk.ForeColor = System.Drawing.Color.Cyan;
            this.ObfuscatorChk.Location = new System.Drawing.Point(5, 222);
            this.ObfuscatorChk.Name = "ObfuscatorChk";
            this.ObfuscatorChk.Size = new System.Drawing.Size(121, 15);
            this.ObfuscatorChk.Style = MetroFramework.MetroColorStyle.Blue;
            this.ObfuscatorChk.TabIndex = 12;
            this.ObfuscatorChk.Text = "Simple Obfuscator";
            this.ObfuscatorChk.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ObfuscatorChk.UseVisualStyleBackColor = true;
            // 
            // SelectedPath_Box
            // 
            this.SelectedPath_Box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.SelectedPath_Box.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SelectedPath_Box.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SelectedPath_Box.ForeColor = System.Drawing.Color.Cyan;
            this.SelectedPath_Box.FormattingEnabled = true;
            this.SelectedPath_Box.Items.AddRange(new object[] {
            "%temp%",
            "%programdata%",
            "%appdata%",
            "%localappdata%",
            "%public%"});
            this.SelectedPath_Box.Location = new System.Drawing.Point(8, 148);
            this.SelectedPath_Box.Name = "SelectedPath_Box";
            this.SelectedPath_Box.Size = new System.Drawing.Size(165, 23);
            this.SelectedPath_Box.TabIndex = 11;
            // 
            // HideFile_Box
            // 
            this.HideFile_Box.Appearance = System.Windows.Forms.Appearance.Button;
            this.HideFile_Box.AutoSize = true;
            this.HideFile_Box.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.HideFile_Box.ForeColor = System.Drawing.Color.Cyan;
            this.HideFile_Box.Location = new System.Drawing.Point(5, 201);
            this.HideFile_Box.Name = "HideFile_Box";
            this.HideFile_Box.Size = new System.Drawing.Size(74, 15);
            this.HideFile_Box.Style = MetroFramework.MetroColorStyle.Blue;
            this.HideFile_Box.TabIndex = 10;
            this.HideFile_Box.Text = "Hide Files";
            this.HideFile_Box.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.HideFile_Box.UseVisualStyleBackColor = true;
            // 
            // BuildBtn
            // 
            this.BuildBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.BuildBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BuildBtn.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BuildBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.BuildBtn.Location = new System.Drawing.Point(181, 162);
            this.BuildBtn.Name = "BuildBtn";
            this.BuildBtn.Size = new System.Drawing.Size(260, 61);
            this.BuildBtn.TabIndex = 8;
            this.BuildBtn.Text = "Build";
            this.BuildBtn.UseVisualStyleBackColor = false;
            this.BuildBtn.Click += new System.EventHandler(this.BuildBtn_Click);
            // 
            // SelectFile2
            // 
            this.SelectFile2.Location = new System.Drawing.Point(383, 107);
            this.SelectFile2.Name = "SelectFile2";
            this.SelectFile2.Size = new System.Drawing.Size(58, 23);
            this.SelectFile2.Style = MetroFramework.MetroColorStyle.Blue;
            this.SelectFile2.TabIndex = 7;
            this.SelectFile2.Text = "...";
            this.SelectFile2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.SelectFile2.Click += new System.EventHandler(this.SelectFile2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(8, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Select the 2nd file:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(8, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Select the first file:";
            // 
            // File2Box
            // 
            this.File2Box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.File2Box.CustomBackground = true;
            this.File2Box.CustomForeColor = true;
            this.File2Box.ForeColor = System.Drawing.Color.White;
            this.File2Box.Location = new System.Drawing.Point(8, 107);
            this.File2Box.Name = "File2Box";
            this.File2Box.PromptText = "File 2";
            this.File2Box.Size = new System.Drawing.Size(369, 23);
            this.File2Box.Style = MetroFramework.MetroColorStyle.Blue;
            this.File2Box.TabIndex = 4;
            this.File2Box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.File2Box.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.File2Box.UseStyleColors = true;
            // 
            // SelectFile1
            // 
            this.SelectFile1.Location = new System.Drawing.Point(383, 50);
            this.SelectFile1.Name = "SelectFile1";
            this.SelectFile1.Size = new System.Drawing.Size(58, 23);
            this.SelectFile1.Style = MetroFramework.MetroColorStyle.Blue;
            this.SelectFile1.TabIndex = 3;
            this.SelectFile1.Text = "...";
            this.SelectFile1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.SelectFile1.Click += new System.EventHandler(this.SelectFile1_Click);
            // 
            // File1Box
            // 
            this.File1Box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.File1Box.CustomBackground = true;
            this.File1Box.CustomForeColor = true;
            this.File1Box.ForeColor = System.Drawing.Color.White;
            this.File1Box.Location = new System.Drawing.Point(8, 50);
            this.File1Box.Name = "File1Box";
            this.File1Box.PromptText = "File 1";
            this.File1Box.Size = new System.Drawing.Size(369, 23);
            this.File1Box.Style = MetroFramework.MetroColorStyle.Blue;
            this.File1Box.TabIndex = 2;
            this.File1Box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.File1Box.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.File1Box.UseStyleColors = true;
            // 
            // metroTabPage3
            // 
            this.metroTabPage3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroTabPage3.Controls.Add(this.CreditsLabel);
            this.metroTabPage3.Controls.Add(this.LabelSupp3);
            this.metroTabPage3.Controls.Add(this.LabelSupp1);
            this.metroTabPage3.Controls.Add(this.GitLabel);
            this.metroTabPage3.Controls.Add(this.LabelSupp2);
            this.metroTabPage3.Controls.Add(this.AuthorLabel);
            this.metroTabPage3.Controls.Add(this.groupBox1);
            this.metroTabPage3.Controls.Add(this.pictureBox2);
            this.metroTabPage3.HorizontalScrollbarBarColor = true;
            this.metroTabPage3.Location = new System.Drawing.Point(4, 35);
            this.metroTabPage3.Name = "metroTabPage3";
            this.metroTabPage3.Size = new System.Drawing.Size(448, 247);
            this.metroTabPage3.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTabPage3.TabIndex = 2;
            this.metroTabPage3.Text = "About";
            this.metroTabPage3.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabPage3.VerticalScrollbarBarColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Builder.Properties.Resources.luffy;
            this.pictureBox2.Location = new System.Drawing.Point(8, 31);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(142, 132);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(156, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(285, 128);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // AuthorLabel
            // 
            this.AuthorLabel.AutoSize = true;
            this.AuthorLabel.BackColor = System.Drawing.Color.Transparent;
            this.AuthorLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AuthorLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AuthorLabel.Font = new System.Drawing.Font("Consolas", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AuthorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(215)))), ((int)(((byte)(255)))));
            this.AuthorLabel.Location = new System.Drawing.Point(73, 182);
            this.AuthorLabel.Name = "AuthorLabel";
            this.AuthorLabel.Size = new System.Drawing.Size(77, 14);
            this.AuthorLabel.TabIndex = 4;
            this.AuthorLabel.Text = "K3rnel-Dev";
            this.AuthorLabel.Click += new System.EventHandler(this.AuthorLabel_Click);
            // 
            // LabelSupp2
            // 
            this.LabelSupp2.AutoSize = true;
            this.LabelSupp2.BackColor = System.Drawing.Color.Transparent;
            this.LabelSupp2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LabelSupp2.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelSupp2.ForeColor = System.Drawing.Color.White;
            this.LabelSupp2.Location = new System.Drawing.Point(21, 200);
            this.LabelSupp2.Name = "LabelSupp2";
            this.LabelSupp2.Size = new System.Drawing.Size(56, 14);
            this.LabelSupp2.TabIndex = 5;
            this.LabelSupp2.Text = "Github:";
            // 
            // GitLabel
            // 
            this.GitLabel.AutoSize = true;
            this.GitLabel.BackColor = System.Drawing.Color.Transparent;
            this.GitLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GitLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GitLabel.Font = new System.Drawing.Font("Consolas", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GitLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(215)))), ((int)(((byte)(255)))));
            this.GitLabel.Location = new System.Drawing.Point(73, 200);
            this.GitLabel.Name = "GitLabel";
            this.GitLabel.Size = new System.Drawing.Size(210, 14);
            this.GitLabel.TabIndex = 6;
            this.GitLabel.Text = "https://github.com/k3rnel-dev";
            this.GitLabel.Click += new System.EventHandler(this.GitLabel_Click);
            // 
            // LabelSupp1
            // 
            this.LabelSupp1.AutoSize = true;
            this.LabelSupp1.BackColor = System.Drawing.Color.Transparent;
            this.LabelSupp1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LabelSupp1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelSupp1.ForeColor = System.Drawing.Color.White;
            this.LabelSupp1.Location = new System.Drawing.Point(21, 182);
            this.LabelSupp1.Name = "LabelSupp1";
            this.LabelSupp1.Size = new System.Drawing.Size(56, 14);
            this.LabelSupp1.TabIndex = 7;
            this.LabelSupp1.Text = "Author:";
            // 
            // LabelSupp3
            // 
            this.LabelSupp3.AutoSize = true;
            this.LabelSupp3.BackColor = System.Drawing.Color.Transparent;
            this.LabelSupp3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LabelSupp3.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelSupp3.ForeColor = System.Drawing.Color.White;
            this.LabelSupp3.Location = new System.Drawing.Point(21, 219);
            this.LabelSupp3.Name = "LabelSupp3";
            this.LabelSupp3.Size = new System.Drawing.Size(63, 14);
            this.LabelSupp3.TabIndex = 8;
            this.LabelSupp3.Text = "Credits:";
            // 
            // CreditsLabel
            // 
            this.CreditsLabel.AutoSize = true;
            this.CreditsLabel.BackColor = System.Drawing.Color.Transparent;
            this.CreditsLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CreditsLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreditsLabel.Font = new System.Drawing.Font("Consolas", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreditsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(215)))), ((int)(((byte)(255)))));
            this.CreditsLabel.Location = new System.Drawing.Point(83, 219);
            this.CreditsLabel.Name = "CreditsLabel";
            this.CreditsLabel.Size = new System.Drawing.Size(161, 14);
            this.CreditsLabel.TabIndex = 9;
            this.CreditsLabel.Text = "dnlib | MetroFramework";
            this.CreditsLabel.Click += new System.EventHandler(this.CreditsLabel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(167)))), ((int)(((byte)(167)))));
            this.label3.Location = new System.Drawing.Point(8, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(271, 104);
            this.label3.TabIndex = 0;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 402);
            this.Controls.Add(this.metroTabControl1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroForm.MetroFormShadowType.Flat;
            this.Style = MetroFramework.MetroColorStyle.Blue;
            this.Text = "HellSing Binder V1.0";
            this.TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            this.metroTabPage3.ResumeLayout(false);
            this.metroTabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage3;
        private MetroFramework.Controls.MetroTextBox File1Box;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroTextBox File2Box;
        private MetroFramework.Controls.MetroButton SelectFile1;
        private MetroFramework.Controls.MetroButton SelectFile2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BuildBtn;
        private MetroFramework.Controls.MetroCheckBox HideFile_Box;
        private System.Windows.Forms.ComboBox SelectedPath_Box;
        private MetroFramework.Controls.MetroCheckBox ObfuscatorChk;
        private MetroFramework.Controls.MetroCheckBox SelfDelete_Chk;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label GitLabel;
        private System.Windows.Forms.Label LabelSupp2;
        private System.Windows.Forms.Label AuthorLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LabelSupp1;
        private System.Windows.Forms.Label CreditsLabel;
        private System.Windows.Forms.Label LabelSupp3;
        private System.Windows.Forms.Label label3;
    }
}

