﻿namespace webBot
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labelIntro = new System.Windows.Forms.Label();
            this.labelURL = new System.Windows.Forms.Label();
            this.labelSubIntro = new System.Windows.Forms.Label();
            this.textBoxURL = new System.Windows.Forms.TextBox();
            this.buttonRun = new System.Windows.Forms.Button();
            this.groupBoxResults = new System.Windows.Forms.GroupBox();
            this.labelMetaDescriptionLengthOutput = new System.Windows.Forms.Label();
            this.labelMetaDescriptionLength = new System.Windows.Forms.Label();
            this.labelPageTitleLengthOutput = new System.Windows.Forms.Label();
            this.labelPageTitleLength = new System.Windows.Forms.Label();
            this.labelURLOutput = new System.Windows.Forms.Label();
            this.labelPageUrl = new System.Windows.Forms.Label();
            this.labelMetaDescriptionResult = new System.Windows.Forms.Label();
            this.labelMetaDescription = new System.Windows.Forms.Label();
            this.labelResponseCode = new System.Windows.Forms.Label();
            this.labelPageTitleResult = new System.Windows.Forms.Label();
            this.labelPageTitle = new System.Windows.Forms.Label();
            this.toolTipPageTitle = new System.Windows.Forms.ToolTip(this.components);
            this.groupBoxSummary = new System.Windows.Forms.GroupBox();
            this.labelMetaPass = new System.Windows.Forms.Label();
            this.labelMetaDescriptionPassOutput = new System.Windows.Forms.Label();
            this.labelPageTitlePass = new System.Windows.Forms.Label();
            this.labelPageTitlePassOutput = new System.Windows.Forms.Label();
            this.labelResponse = new System.Windows.Forms.Label();
            this.labelResponseOutput = new System.Windows.Forms.Label();
            this.groupBoxResults.SuspendLayout();
            this.groupBoxSummary.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelIntro
            // 
            this.labelIntro.AutoSize = true;
            this.labelIntro.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIntro.Location = new System.Drawing.Point(25, 19);
            this.labelIntro.Name = "labelIntro";
            this.labelIntro.Size = new System.Drawing.Size(181, 19);
            this.labelIntro.TabIndex = 0;
            this.labelIntro.Text = "Welcome to the Web Bot";
            // 
            // labelURL
            // 
            this.labelURL.AutoSize = true;
            this.labelURL.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelURL.Location = new System.Drawing.Point(26, 97);
            this.labelURL.Name = "labelURL";
            this.labelURL.Size = new System.Drawing.Size(65, 15);
            this.labelURL.TabIndex = 1;
            this.labelURL.Text = "Enter URL:";
            // 
            // labelSubIntro
            // 
            this.labelSubIntro.AutoSize = true;
            this.labelSubIntro.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSubIntro.Location = new System.Drawing.Point(27, 48);
            this.labelSubIntro.Name = "labelSubIntro";
            this.labelSubIntro.Size = new System.Drawing.Size(425, 15);
            this.labelSubIntro.TabIndex = 2;
            this.labelSubIntro.Text = "Web Bot will crawl and analyse your webpage. Start by entering a URL below";
            // 
            // textBoxURL
            // 
            this.textBoxURL.Location = new System.Drawing.Point(97, 95);
            this.textBoxURL.Name = "textBoxURL";
            this.textBoxURL.Size = new System.Drawing.Size(355, 20);
            this.textBoxURL.TabIndex = 3;
            // 
            // buttonRun
            // 
            this.buttonRun.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRun.Location = new System.Drawing.Point(323, 139);
            this.buttonRun.Name = "buttonRun";
            this.buttonRun.Size = new System.Drawing.Size(129, 23);
            this.buttonRun.TabIndex = 4;
            this.buttonRun.Text = "Run the Web Bot";
            this.buttonRun.UseVisualStyleBackColor = true;
            this.buttonRun.Click += new System.EventHandler(this.buttonRun_Click);
            // 
            // groupBoxResults
            // 
            this.groupBoxResults.Controls.Add(this.labelMetaDescriptionLengthOutput);
            this.groupBoxResults.Controls.Add(this.labelMetaDescriptionLength);
            this.groupBoxResults.Controls.Add(this.labelPageTitleLengthOutput);
            this.groupBoxResults.Controls.Add(this.labelPageTitleLength);
            this.groupBoxResults.Controls.Add(this.labelURLOutput);
            this.groupBoxResults.Controls.Add(this.labelPageUrl);
            this.groupBoxResults.Controls.Add(this.labelMetaDescriptionResult);
            this.groupBoxResults.Controls.Add(this.labelMetaDescription);
            this.groupBoxResults.Controls.Add(this.labelResponseCode);
            this.groupBoxResults.Controls.Add(this.labelPageTitleResult);
            this.groupBoxResults.Controls.Add(this.labelPageTitle);
            this.groupBoxResults.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxResults.Location = new System.Drawing.Point(12, 178);
            this.groupBoxResults.Name = "groupBoxResults";
            this.groupBoxResults.Size = new System.Drawing.Size(864, 309);
            this.groupBoxResults.TabIndex = 5;
            this.groupBoxResults.TabStop = false;
            this.groupBoxResults.Text = "Web Bot results";
            this.groupBoxResults.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // labelMetaDescriptionLengthOutput
            // 
            this.labelMetaDescriptionLengthOutput.AutoSize = true;
            this.labelMetaDescriptionLengthOutput.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMetaDescriptionLengthOutput.Location = new System.Drawing.Point(126, 107);
            this.labelMetaDescriptionLengthOutput.Name = "labelMetaDescriptionLengthOutput";
            this.labelMetaDescriptionLengthOutput.Size = new System.Drawing.Size(97, 15);
            this.labelMetaDescriptionLengthOutput.TabIndex = 17;
            this.labelMetaDescriptionLengthOutput.Text = "will appear here";
            // 
            // labelMetaDescriptionLength
            // 
            this.labelMetaDescriptionLength.AutoSize = true;
            this.labelMetaDescriptionLength.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMetaDescriptionLength.Location = new System.Drawing.Point(13, 107);
            this.labelMetaDescriptionLength.Name = "labelMetaDescriptionLength";
            this.labelMetaDescriptionLength.Size = new System.Drawing.Size(114, 15);
            this.labelMetaDescriptionLength.TabIndex = 16;
            this.labelMetaDescriptionLength.Text = "Description Length:";
            // 
            // labelPageTitleLengthOutput
            // 
            this.labelPageTitleLengthOutput.AutoSize = true;
            this.labelPageTitleLengthOutput.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPageTitleLengthOutput.Location = new System.Drawing.Point(126, 82);
            this.labelPageTitleLengthOutput.Name = "labelPageTitleLengthOutput";
            this.labelPageTitleLengthOutput.Size = new System.Drawing.Size(97, 15);
            this.labelPageTitleLengthOutput.TabIndex = 15;
            this.labelPageTitleLengthOutput.Text = "will appear here";
            // 
            // labelPageTitleLength
            // 
            this.labelPageTitleLength.AutoSize = true;
            this.labelPageTitleLength.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPageTitleLength.Location = new System.Drawing.Point(13, 82);
            this.labelPageTitleLength.Name = "labelPageTitleLength";
            this.labelPageTitleLength.Size = new System.Drawing.Size(105, 15);
            this.labelPageTitleLength.TabIndex = 14;
            this.labelPageTitleLength.Text = "Page Title Length:";
            // 
            // labelURLOutput
            // 
            this.labelURLOutput.AutoSize = true;
            this.labelURLOutput.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelURLOutput.Location = new System.Drawing.Point(126, 34);
            this.labelURLOutput.Name = "labelURLOutput";
            this.labelURLOutput.Size = new System.Drawing.Size(97, 15);
            this.labelURLOutput.TabIndex = 13;
            this.labelURLOutput.Text = "will appear here";
            // 
            // labelPageUrl
            // 
            this.labelPageUrl.AutoSize = true;
            this.labelPageUrl.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPageUrl.Location = new System.Drawing.Point(15, 34);
            this.labelPageUrl.Name = "labelPageUrl";
            this.labelPageUrl.Size = new System.Drawing.Size(32, 15);
            this.labelPageUrl.TabIndex = 12;
            this.labelPageUrl.Text = "URL:";
            this.labelPageUrl.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelMetaDescriptionResult
            // 
            this.labelMetaDescriptionResult.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMetaDescriptionResult.Location = new System.Drawing.Point(126, 132);
            this.labelMetaDescriptionResult.Name = "labelMetaDescriptionResult";
            this.labelMetaDescriptionResult.Size = new System.Drawing.Size(314, 63);
            this.labelMetaDescriptionResult.TabIndex = 11;
            this.labelMetaDescriptionResult.Text = "will appear here";
            // 
            // labelMetaDescription
            // 
            this.labelMetaDescription.AutoSize = true;
            this.labelMetaDescription.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMetaDescription.Location = new System.Drawing.Point(13, 132);
            this.labelMetaDescription.Name = "labelMetaDescription";
            this.labelMetaDescription.Size = new System.Drawing.Size(105, 15);
            this.labelMetaDescription.TabIndex = 10;
            this.labelMetaDescription.Text = "Meta Description:";
            // 
            // labelResponseCode
            // 
            this.labelResponseCode.AutoSize = true;
            this.labelResponseCode.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResponseCode.Location = new System.Drawing.Point(13, 155);
            this.labelResponseCode.Name = "labelResponseCode";
            this.labelResponseCode.Size = new System.Drawing.Size(0, 15);
            this.labelResponseCode.TabIndex = 8;
            // 
            // labelPageTitleResult
            // 
            this.labelPageTitleResult.AutoSize = true;
            this.labelPageTitleResult.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPageTitleResult.Location = new System.Drawing.Point(126, 58);
            this.labelPageTitleResult.Name = "labelPageTitleResult";
            this.labelPageTitleResult.Size = new System.Drawing.Size(97, 15);
            this.labelPageTitleResult.TabIndex = 7;
            this.labelPageTitleResult.Text = "will appear here";
            // 
            // labelPageTitle
            // 
            this.labelPageTitle.AutoSize = true;
            this.labelPageTitle.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPageTitle.Location = new System.Drawing.Point(13, 58);
            this.labelPageTitle.Name = "labelPageTitle";
            this.labelPageTitle.Size = new System.Drawing.Size(64, 15);
            this.labelPageTitle.TabIndex = 6;
            this.labelPageTitle.Text = "Page Title:";
            this.toolTipPageTitle.SetToolTip(this.labelPageTitle, resources.GetString("labelPageTitle.ToolTip"));
            // 
            // toolTipPageTitle
            // 
            this.toolTipPageTitle.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipPageTitle.ToolTipTitle = "Page Title Information";
            this.toolTipPageTitle.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTipPageTitle_Popup);
            // 
            // groupBoxSummary
            // 
            this.groupBoxSummary.Controls.Add(this.labelResponseOutput);
            this.groupBoxSummary.Controls.Add(this.labelResponse);
            this.groupBoxSummary.Controls.Add(this.labelPageTitlePassOutput);
            this.groupBoxSummary.Controls.Add(this.labelPageTitlePass);
            this.groupBoxSummary.Controls.Add(this.labelMetaDescriptionPassOutput);
            this.groupBoxSummary.Controls.Add(this.labelMetaPass);
            this.groupBoxSummary.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxSummary.Location = new System.Drawing.Point(483, 19);
            this.groupBoxSummary.Name = "groupBoxSummary";
            this.groupBoxSummary.Size = new System.Drawing.Size(393, 143);
            this.groupBoxSummary.TabIndex = 16;
            this.groupBoxSummary.TabStop = false;
            this.groupBoxSummary.Text = "Page Summary";
            // 
            // labelMetaPass
            // 
            this.labelMetaPass.AutoSize = true;
            this.labelMetaPass.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMetaPass.Location = new System.Drawing.Point(6, 33);
            this.labelMetaPass.Name = "labelMetaPass";
            this.labelMetaPass.Size = new System.Drawing.Size(131, 15);
            this.labelMetaPass.TabIndex = 18;
            this.labelMetaPass.Text = "Meta Description Pass:";
            // 
            // labelMetaDescriptionPassOutput
            // 
            this.labelMetaDescriptionPassOutput.AutoSize = true;
            this.labelMetaDescriptionPassOutput.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMetaDescriptionPassOutput.Location = new System.Drawing.Point(143, 32);
            this.labelMetaDescriptionPassOutput.Name = "labelMetaDescriptionPassOutput";
            this.labelMetaDescriptionPassOutput.Size = new System.Drawing.Size(97, 15);
            this.labelMetaDescriptionPassOutput.TabIndex = 18;
            this.labelMetaDescriptionPassOutput.Text = "will appear here";
            // 
            // labelPageTitlePass
            // 
            this.labelPageTitlePass.AutoSize = true;
            this.labelPageTitlePass.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPageTitlePass.Location = new System.Drawing.Point(6, 57);
            this.labelPageTitlePass.Name = "labelPageTitlePass";
            this.labelPageTitlePass.Size = new System.Drawing.Size(90, 15);
            this.labelPageTitlePass.TabIndex = 19;
            this.labelPageTitlePass.Text = "Page Title Pass:";
            // 
            // labelPageTitlePassOutput
            // 
            this.labelPageTitlePassOutput.AutoSize = true;
            this.labelPageTitlePassOutput.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPageTitlePassOutput.Location = new System.Drawing.Point(143, 57);
            this.labelPageTitlePassOutput.Name = "labelPageTitlePassOutput";
            this.labelPageTitlePassOutput.Size = new System.Drawing.Size(97, 15);
            this.labelPageTitlePassOutput.TabIndex = 20;
            this.labelPageTitlePassOutput.Text = "will appear here";
            // 
            // labelResponse
            // 
            this.labelResponse.AutoSize = true;
            this.labelResponse.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResponse.Location = new System.Drawing.Point(6, 81);
            this.labelResponse.Name = "labelResponse";
            this.labelResponse.Size = new System.Drawing.Size(123, 15);
            this.labelResponse.TabIndex = 21;
            this.labelResponse.Text = "Page Response Code:";
            // 
            // labelResponseOutput
            // 
            this.labelResponseOutput.AutoSize = true;
            this.labelResponseOutput.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResponseOutput.Location = new System.Drawing.Point(143, 81);
            this.labelResponseOutput.Name = "labelResponseOutput";
            this.labelResponseOutput.Size = new System.Drawing.Size(97, 15);
            this.labelResponseOutput.TabIndex = 22;
            this.labelResponseOutput.Text = "will appear here";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 499);
            this.Controls.Add(this.groupBoxSummary);
            this.Controls.Add(this.groupBoxResults);
            this.Controls.Add(this.buttonRun);
            this.Controls.Add(this.textBoxURL);
            this.Controls.Add(this.labelSubIntro);
            this.Controls.Add(this.labelURL);
            this.Controls.Add(this.labelIntro);
            this.Name = "Form1";
            this.Text = "Web Bot";
            this.groupBoxResults.ResumeLayout(false);
            this.groupBoxResults.PerformLayout();
            this.groupBoxSummary.ResumeLayout(false);
            this.groupBoxSummary.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelIntro;
        private System.Windows.Forms.Label labelURL;
        private System.Windows.Forms.Label labelSubIntro;
        private System.Windows.Forms.TextBox textBoxURL;
        private System.Windows.Forms.Button buttonRun;
        private System.Windows.Forms.GroupBox groupBoxResults;
        private System.Windows.Forms.Label labelResponseCode;
        private System.Windows.Forms.Label labelPageTitleResult;
        private System.Windows.Forms.Label labelPageTitle;
        private System.Windows.Forms.Label labelMetaDescriptionResult;
        private System.Windows.Forms.Label labelMetaDescription;
        private System.Windows.Forms.Label labelURLOutput;
        private System.Windows.Forms.Label labelPageUrl;
        private System.Windows.Forms.Label labelPageTitleLength;
        private System.Windows.Forms.ToolTip toolTipPageTitle;
        private System.Windows.Forms.Label labelPageTitleLengthOutput;
        private System.Windows.Forms.GroupBox groupBoxSummary;
        private System.Windows.Forms.Label labelMetaDescriptionLengthOutput;
        private System.Windows.Forms.Label labelMetaDescriptionLength;
        private System.Windows.Forms.Label labelMetaPass;
        private System.Windows.Forms.Label labelPageTitlePassOutput;
        private System.Windows.Forms.Label labelPageTitlePass;
        private System.Windows.Forms.Label labelMetaDescriptionPassOutput;
        private System.Windows.Forms.Label labelResponseOutput;
        private System.Windows.Forms.Label labelResponse;
    }
}
